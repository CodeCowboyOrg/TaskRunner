using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class TaskDetailEdit : Form
    {
        private Task m_prevTask = null;
        private Task m_currTask = null;

        public TaskDetailEdit()
        {
            InitializeComponent();
        }



        public Task PreviousTask
        {
            get
            {
                return m_prevTask;
            }
        }

        public Task CurrentTask
        {
            get
            {
                return m_currTask;
            }
            set
            {
                m_currTask = value;
                m_prevTask = m_currTask.Clone();
                m_taskDetailEntry.SetTask(m_currTask);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RestoreTask();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void RestoreTask()
        {
            m_currTask.Id = m_prevTask.Id;
            m_currTask.TaskName = m_prevTask.TaskName;
            m_currTask.MaxDuration = m_prevTask.MaxDuration;
            m_currTask.DependentIds = m_prevTask.DependentIds;
            m_currTask.Executable = m_prevTask.Executable;
            m_currTask.Parameters = m_prevTask.Parameters;
        }
    }
}
