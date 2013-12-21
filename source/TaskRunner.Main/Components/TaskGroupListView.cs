using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskRunner.Util;
using TaskRunner.Core;

namespace TaskRunner.Main.Components
{
    /// <summary>
    /// Rights to use any portion of this code for any Production related purposes
    /// require explicit written permission from the author Johnson Fan and can be
    /// reached at JohnsonFan@yahoo.com.
    /// </summary>
    public partial class TaskGroupListView : UserControl
    {
        #region Private Members
        private TaskGroup m_taskGroup = null;
        #endregion Private Members

        #region Events and Delegates
        public delegate void TaskRowFocusChangedHandler(Task task);
        public event TaskRowFocusChangedHandler TaskRowFocusChanged;
        #endregion Events and Delegates

        #region Constructor

        public TaskGroupListView()
        {
            InitializeComponent();           
            RegisterEvents();
        }

        #endregion Constructor

        #region Private Methods
        private void RegisterEvents()
        {
            this.m_listTaskGroup.SelectedIndexChanged +=new EventHandler(m_listTaskGroup_SelectedIndexChanged);
        }


        private TaskGroup GetCurrentTaskGroup()
        {
            TaskGroup tg = new TaskGroup();
            foreach (ListViewItem lvi in m_listTaskGroup.Items)
            {
                if (lvi.Tag != null)
                {
                    tg.TaskList.Add((Task)lvi.Tag);
                }
            }
            return tg;
        }

        private void SetCurrentTaskGroup()
        {
            if (m_listTaskGroup.Items == null) return;
            if (m_taskGroup == null) return;
            if (m_listTaskGroup.Items.Count > 0) m_listTaskGroup.Items.Clear();
            foreach (Task tg in m_taskGroup.TaskList)
            {
                this.AddTask(tg);
            }
        }
        #endregion Private Methods

        #region Event Handlers
        void m_listTaskGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_listTaskGroup.Items.Count <= 0) return;
            //The currently focused Task has changed on the Gui, broadcast the event of this change
            ListView lv = (ListView)sender;
            if (lv == null) return;
            if (lv.FocusedItem == null) return;
            ListViewItem lvi = lv.FocusedItem;
            CurrentTask = (Task)lvi.Tag;
            if (this.TaskRowFocusChanged != null)
            {
                TaskRowFocusChanged(CurrentTask);
            }
        }
        #endregion Event Handlers

        #region Public Properties
        public Task CurrentTask { get; set; }

        public TaskGroup TaskGroup 
        { 
            get
            {
                return GetCurrentTaskGroup();
            }
            set
            {
                m_taskGroup = value;
                SetCurrentTaskGroup();
            }
                
        }
        #endregion Public Properties

        #region Public Methods
        public void RefreshGrid(TaskGroup tg)
        {

        }

        public void AddTask(Task task)
        {
            string[] taskArray = { task.Id.ToString(), task.TaskName, task.MaxDuration.ToString(), task.DependentIds, task.Executable, task.Parameters };
            ListViewUtil.AddListViewItem(m_listTaskGroup, task, taskArray);
        }

        public void UpdateTask(Task task)
        {
            
            string[] taskArray = { task.Id.ToString(), task.TaskName, task.MaxDuration.ToString(), task.DependentIds, task.Executable, task.Parameters };
            ListViewUtil.UpdateListViewItem(m_listTaskGroup, task, taskArray);
        }
        #endregion Public Methods
    }
}
