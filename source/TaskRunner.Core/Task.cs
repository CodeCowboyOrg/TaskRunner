using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.Win32.TaskScheduler;

namespace TaskRunner.Core
{
    /// <summary>
    /// Rights to use any portion of this code for any Production related purposes
    /// require explicit written permission from the author Johnson Fan and can be
    /// reached at JohnsonFan@yahoo.com.
    /// </summary>
    public class Task : IDisposable, ICloneable
    {
        #region Private Members
        private List<Task> m_parentTask = new List<Task>();
        private Dictionary<string, string> m_parameter = new Dictionary<string, string>();
        private Dictionary<string, string> m_defaultParameter = new Dictionary<string, string>();
        private Microsoft.Win32.TaskScheduler.Task m_task = null;
        private Guid m_guid = Guid.NewGuid();
        //private Guid? m_runningInstanceGuid = null;
        private string m_taskName = string.Empty;
        private string m_internalTaskName = string.Empty;
        private TaskMonitor m_taskMonitor = null;
        private TaskStatus m_status = TaskStatus.NotStarted;
        #endregion Private Members

        #region Events and Delegates
        public delegate void StatusChangedHandler(object sender);
        public event StatusChangedHandler StatusChanged;
        #endregion Events and Delegates

        #region Constructor
        public Task()
        {
            Status = TaskStatus.NotStarted;
        }
        #endregion Constructor

        #region Properties
        public int Id { get; set; }
        public double MaxDuration { get; set; }
        public string DependentIds { get; set; }
        public string Executable { get; set; }
        public string Parameters { get; set; }

        [XmlIgnore()]
        public double RunningDuration { get; set; }

        [XmlIgnore()]
        public DateTime StartTime { get; set; }

        [XmlIgnore()]
        public TaskStatus Status 
        {
            get
            {
                return m_status;
            }
            set
            {
                TaskStatus prevStatus = m_status;
                TaskStatus currStatus = value;
                if (prevStatus != currStatus)
                {
                    m_status = currStatus;
                    if (StatusChanged != null)
                    {
                        StatusChanged(this);
                    }
                }

            }
        }
        
        public string TaskName
        {
            get
            {
                return m_taskName;
            }
            set
            {
                m_taskName = value;
                m_internalTaskName = m_taskName + " - (" + m_guid.ToString() + ")";
            }

        }

        [XmlIgnore()]
        public string InternalTaskName
        {
            get
            {
                return m_internalTaskName;
            }
        }

        [XmlIgnore()]
        public Dictionary<string, string> OverrideParameterList
        {
            get
            {
                return m_parameter;
            }
        }

        [XmlIgnore()]
        public Dictionary<string, string> DefaultParameterList
        {
            get
            {
                return m_parameter;
            }
        }

        [XmlIgnore()]
        public List<Task> ParentTask 
        {
            get
            {
                return m_parentTask;
            }
        } 
        #endregion Properties

        #region Public Methods
        public void Run()
        {
            m_task = CreateNewScheduledTask();
            this.Status = TaskStatus.QueuedForRunning;
            m_task.Run();            
            this.StartTime = DateTime.Now;                        
            m_taskMonitor = new TaskMonitor(this);
            m_taskMonitor.Start();
        }

        public void Run(bool checkDependency)
        {
            if (checkDependency && ParentTask.Count > 0)
            {
                foreach (Task task in ParentTask)
                {
                    if (task.Status != TaskStatus.CompletedSuccessfully)
                    {
                        return;
                    }
                }
            }
            this.Run();
        }

        public void Abort()
        {
            if (m_task != null && m_task.State == TaskState.Running)
            {
                this.Status = TaskStatus.Aborted;
                m_task.Stop();
            }
        }

        public void UpdateRunningDurationTime()
        {
            TimeSpan time = DateTime.Now.Subtract(StartTime);
            RunningDuration = time.TotalMinutes;
        }

        public void Clean()
        {
            if (m_task == null) return;
            using (TaskService ts = new TaskService())
            {
                Microsoft.Win32.TaskScheduler.Task t = ts.GetTask(m_internalTaskName);
                if (t != null) ts.RootFolder.DeleteTask(m_internalTaskName);
            }
        }
        #endregion Public Methods

        #region Private Methods
        private Microsoft.Win32.TaskScheduler.Task CreateNewScheduledTask()
        {
            using (TaskService ts = new TaskService())
            {
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = TaskName;
                td.Principal.LogonType = TaskLogonType.InteractiveToken;
                td.Actions.Add(new ExecAction(this.Executable, this.Parameters, null));
                ts.RootFolder.RegisterTaskDefinition(m_internalTaskName, td);
                Microsoft.Win32.TaskScheduler.Task t = ts.GetTask(m_internalTaskName);
                return t;
            }
        }

        public Microsoft.Win32.TaskScheduler.Task GetScheduledTask()
        {
            using (TaskService ts = new TaskService())
            {
                Microsoft.Win32.TaskScheduler.Task t = ts.GetTask(m_internalTaskName);
                return t;
            }
        }

        public void ResetTask()
        {
            this.TaskName = this.TaskName;
            this.Status = TaskStatus.NotStarted;
            this.RunningDuration = 0;
            this.ParentTask.Clear();
        }
        #endregion Private Methods

        #region Interface IDisposeable
        public void Dispose()
        {
            if (m_taskMonitor != null) m_taskMonitor = null;
        }
        #endregion Interface IDisposeable

        #region Interface ICloneable
        public Task Clone()
        {
            Task task = (Task) (this as ICloneable).Clone();
            return task;
        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }
 
        #endregion Interface ICloneable

    }

    public enum TaskStatus
    {
        NotStarted,
        QueuedForRunning,
        Running,
        Aborted,
        Stopped,
        CompletedSuccessfully,
        Failed,
        FailedOvertime
    }
}
