using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskRunner.Core;

namespace TaskRunner.Main.Components
{
    /// <summary>
    /// Rights to use any portion of this code for any Production related purposes
    /// require explicit written permission from the author Johnson Fan and can be
    /// reached at JohnsonFan@yahoo.com.
    /// </summary>
    interface ITaskRunnerMainView
    {
        void AddTask(Task task);
        void EditTask(Task task);
        void DeleteTask(Task task);

        void LoadTaskGroup(TaskGroup taskGroup);
        void SaveTaskGroup(TaskGroup taskGroup);
        void RunTaskGroup(TaskGroup taskGroup);

        void LoadView();
    }
}
