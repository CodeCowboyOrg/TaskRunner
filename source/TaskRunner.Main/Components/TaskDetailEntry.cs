using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskRunner.Core;

namespace TaskRunner.Main.Components
{
    /// <summary>
    /// Rights to use any portion of this code for any Production related purposes
    /// require explicit written permission from the author Johnson Fan and can be
    /// reached at JohnsonFan@yahoo.com.
    /// </summary>
    public partial class TaskDetailEntry : UserControl
    {
        private Task m_task = new Task();

        public TaskDetailEntry()
        {
            InitializeComponent();
        }

        #region Private Methods
        private void BindData()
        {
            txtId.DataBindings.Add("Text", m_task, "Id");
            txtTaskName.DataBindings.Add("Text", m_task, "TaskName");
            txtMaxMinutes.DataBindings.Add("Text", m_task, "MaxDuration");
            txtDepends.DataBindings.Add("Text", m_task, "DependentIds");
            txtParam.DataBindings.Add("Text", m_task, "Parameters");
            txtExec.DataBindings.Add("Text", m_task, "Executable");

        }
        #endregion Private Methods

        #region Public Properties
        public Task CurrentTask
        {
            get
            {
                return m_task;
            }
        }
        #endregion Public Properties

        #region Public Methods
        public void SetTask(Task task)
        {
            m_task = task;
            BindData();
        }
        #endregion Public Methods


        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(m_task.Id);
            Console.WriteLine(m_task.TaskName);
            Console.WriteLine(m_task.DependentIds);
            Console.WriteLine(m_task.Executable);
            Console.WriteLine(m_task.Parameters);
            Console.WriteLine(m_task.MaxDuration);
        }

    }
}
