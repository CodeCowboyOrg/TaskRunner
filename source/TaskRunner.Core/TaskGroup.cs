using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace TaskRunner.Core
{
    /// <summary>
    /// Rights to use any portion of this code for any Production related purposes
    /// require explicit written permission from the author Johnson Fan and can be
    /// reached at JohnsonFan@yahoo.com.
    /// </summary>
    public class TaskGroup
    {
        #region Constructor
        public TaskGroup()
        {
            TaskList = new List<Task>();
        }
        #endregion Constructor

        #region Properties
        [XmlArray("TaskList")]
        [XmlArrayItem("Task", typeof(Task))]
        public List<Task> TaskList { get; set; }
        #endregion Properties

        #region Public Methods

        public void SetDependency()
        {
            foreach (Task task in this.TaskList)
            {
                if (task.DependentIds == null) continue;
                string[] ids = task.DependentIds.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string id in ids)
                {
                    var query = from Task dependentTask in this.TaskList
                                where dependentTask.Id == Convert.ToInt32(id)
                                select dependentTask;

                    foreach (Task t in query)
                    {
                        task.ParentTask.Add(t);
                    }
                }
            }
        }

        public void ResetTaskGroup()
        {
            foreach (Task task in this.TaskList)
            {
                task.ResetTask();
            }
        }

        public void Run()
        {
            SetDependency();
            foreach (Task task in TaskList)
            {
                if (task.ParentTask.Count == 0)
                {
                    task.StatusChanged += new Task.StatusChangedHandler(task_StatusChanged);
                    task.Run();
                }
            }

        }

        public void RunNextTask()
        {
            foreach (Task task in TaskList)
            {
                if (task.Status == TaskStatus.NotStarted)
                {
                    bool readyToRun = true;
                    foreach (Task parentTask in task.ParentTask)
                    {
                        if (parentTask.Status != TaskStatus.CompletedSuccessfully)
                        {
                            readyToRun = false;
                            break;
                        }
                    }
                    if (readyToRun)
                    {
                        task.StatusChanged += new Task.StatusChangedHandler(task_StatusChanged);
                        task.Run();
                     }
                }
            }

        }


        private void task_StatusChanged(object sender)
        {
            Task task = (Task)sender;
            if (task.Status == TaskStatus.CompletedSuccessfully)
            {
                RunNextTask();
            }
        }
        #endregion Public Methods
    }
}
