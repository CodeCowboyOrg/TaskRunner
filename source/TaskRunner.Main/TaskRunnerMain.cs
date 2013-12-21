using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TaskRunner.Util;
using TaskRunner.Core;
using TaskRunner.Main.Components;

namespace TaskRunner.Main
{
    /// <summary>
    /// Rights to use any portion of this code for any Production related purposes
    /// require explicit written permission from the author Johnson Fan and can be
    /// reached at JohnsonFan@yahoo.com.
    /// </summary>
    public partial class TaskRunnerMain : Form
    {

        #region Constructor
        public TaskRunnerMain()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Event Handlers
        private void btnRun_Click(object sender, EventArgs e)
        {
            TaskGroup taskGroup = m_taskList.TaskGroup;
            taskGroup.ResetTaskGroup();
            taskGroup.Run();

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {            
            TaskDetailNew tdn = new TaskDetailNew();
            tdn.StartPosition = FormStartPosition.CenterParent;
            tdn.ShowDialog();
            if (tdn.DialogResult == DialogResult.OK)
            {
                m_taskList.AddTask(tdn.CurrentTask);
            }
            tdn.Dispose();
            tdn = null;

        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (m_taskList.CurrentTask != null)
            {
                TaskDetailEdit tde = new TaskDetailEdit();
                tde.CurrentTask = m_taskList.CurrentTask;
                tde.StartPosition = FormStartPosition.CenterParent;
                tde.ShowDialog();
                if (tde.DialogResult == DialogResult.OK)
                {
                    m_taskList.UpdateTask(tde.CurrentTask);
                }
                tde.Dispose();
                tde = null;
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.FileName = "";
                dialog.Multiselect = false;
                dialog.Filter = "xml files (*.xml)|*.xml";
                if (DialogResult.Cancel == dialog.ShowDialog()) return;
                if (dialog.FileName.Trim().Length <= 0) return;

                TaskGroup tg = XmlSerializer<TaskGroup>.Deserialize(dialog.FileName);
                if (tg != null)
                {
                    m_taskList.TaskGroup = tg;
                }
                Logger.Log(dialog.FileName + "loaded");
            }
            catch (System.IO.IOException ioEx)
            {
                Logger.Log("IO Exception: ", ioEx);
                MessageBox.Show(ioEx.Message);
            }
            catch (Exception ex)
            {
                Logger.Log("General Exception: ", ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.FileName = "";
                dialog.Filter = "xml files (*.xml)|*.xml";
                if (DialogResult.Cancel == dialog.ShowDialog()) return;
                if (dialog.FileName.Trim().Length <= 0) return;
                TaskGroup tg = m_taskList.TaskGroup;
                if (tg != null)
                {
                    XmlSerializer<TaskGroup>.Serialize(dialog.FileName, tg);
                }
                Logger.Log(dialog.FileName + "saved");
            }
            catch (System.IO.IOException ioEx)
            {
                Logger.Log("IO Exception: ", ioEx);
                MessageBox.Show(ioEx.Message);                
            }
            catch (Exception ex)
            {
                Logger.Log("General Exception: ", ex);
                MessageBox.Show(ex.Message);
            }

        }

        private void TaskRunnerMain_Load(object sender, EventArgs e)
        {
            Logger.Log("App Started!");
        }
        #endregion Event Handlers
        
    }
}
