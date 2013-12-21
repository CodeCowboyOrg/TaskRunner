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
    public partial class TaskDetailNew : Form
    {
        private Task m_task = new Task();

        public TaskDetailNew()
        {
            InitializeComponent();
            m_taskDetailEntry.SetTask(m_task);
        }


        public Task CurrentTask
        {
            get { return m_taskDetailEntry.CurrentTask; }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

 
}
