using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using TaskRunner.Util;
using Microsoft.Win32.TaskScheduler;

namespace TaskRunner.Core
{
    /// <summary>
    /// Rights to use any portion of this code for any Production related purposes
    /// require explicit written permission from the author Johnson Fan and can be
    /// reached at JohnsonFan@yahoo.com.
    /// </summary>
    public class TaskMonitor
    {
        #region Private Members
        private Task m_task = null;
        #endregion Private Members

        #region Constructor
        public TaskMonitor(Task task)
        {
            m_task = task;
        }
        #endregion Constructor

        #region Public Methods
        public void Start()
        {            
            Thread thread = new Thread(CheckStatus);
            thread.Name = "Task Monitor Thread";
            Logger.Log(thread.Name + " Started.");
            thread.Start();
            
        }

        public void CheckStatus()
        {
            do
            {
                m_task.UpdateRunningDurationTime();
                //Task runs over the alloted time, mark as failed and abort
                if (m_task.RunningDuration > m_task.MaxDuration)
                {
                    Debug.WriteLine(m_task.Id.ToString() + ":" + m_task.InternalTaskName + ":Task Running Over Allotted Time, Failed");
                    Logger.Log(m_task.Id.ToString() + ":" + m_task.InternalTaskName + ":Task Running Over Allotted Time, Failed");
                    m_task.Status = TaskStatus.FailedOvertime;
                    m_task.Abort();
                    return;
                }

                Microsoft.Win32.TaskScheduler.Task schedTask = m_task.GetScheduledTask();
                Debug.WriteLine(m_task.Id.ToString() + ":" + m_task.InternalTaskName + ":State:" + schedTask.State.ToString());
                Logger.Log(m_task.Id.ToString() + ":" + m_task.InternalTaskName + ":State:" + schedTask.State.ToString());
                if (schedTask.State == TaskState.Queued)
                {
                    Thread.Sleep(5000);
                    continue;
                }
                else if (schedTask != null && schedTask.State == TaskState.Running) 
                {
                    Debug.WriteLine(m_task.Id.ToString() + ":" + m_task.InternalTaskName + ":Task Running");
                    Logger.Log(m_task.Id.ToString() + ":" + m_task.InternalTaskName + ":Task Running");
                    m_task.Status = TaskStatus.Running;
                    Thread.Sleep(5000);
                }

                //If the task is not running, determine if it was completed successfully or if it failed
                if (schedTask != null && schedTask.State != TaskState.Running)
                {
                    if (schedTask != null && schedTask.LastTaskResult == 0)
                    {
                        Debug.WriteLine(m_task.Id.ToString() + ":" + m_task.InternalTaskName + ":Task Completed");
                        Logger.Log(m_task.Id.ToString() + ":" + m_task.InternalTaskName + ":Task Completed");
                        m_task.Status = TaskStatus.CompletedSuccessfully;
                    }
                    else if (schedTask != null && schedTask.LastTaskResult < 0)
                    {
                        Debug.WriteLine(m_task.Id.ToString() + ":" + m_task.InternalTaskName + ":Task Failed Status(" + schedTask.LastTaskResult.ToString() + ")");
                        Logger.Log(m_task.Id.ToString() + ":" + m_task.InternalTaskName + ":Task Failed(" + schedTask.LastTaskResult.ToString() + ")");
                        m_task.Status = TaskStatus.Failed;
                    }
                    else if (schedTask != null && schedTask.LastTaskResult == 1)
                    {
                        Debug.WriteLine(m_task.Id.ToString() + ":" + m_task.InternalTaskName + ":Task Failed Status(" + schedTask.LastTaskResult.ToString() + ")");
                        Logger.Log(m_task.Id.ToString() + ":" + m_task.InternalTaskName + ":Task Failed(" + schedTask.LastTaskResult.ToString() + ")");
                        m_task.Status = TaskStatus.Failed;
                    }
                    return;
                }
            } while (true);
        }
        #endregion Public Methods
    }
}
