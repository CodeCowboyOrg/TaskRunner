namespace TaskRunner.Main
{
    partial class TaskRunnerMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TaskRunner.Core.TaskGroup taskGroup2 = new TaskRunner.Core.TaskGroup();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskRunnerMain));
            this.tabTask = new System.Windows.Forms.TabControl();
            this.tabTaskProperty = new System.Windows.Forms.TabPage();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.m_taskList = new TaskRunner.Main.Components.TaskGroupListView();
            this.tabRunStatus = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabTask.SuspendLayout();
            this.tabTaskProperty.SuspendLayout();
            this.tabRunStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTask
            // 
            this.tabTask.Controls.Add(this.tabTaskProperty);
            this.tabTask.Controls.Add(this.tabRunStatus);
            this.tabTask.Location = new System.Drawing.Point(5, 8);
            this.tabTask.Name = "tabTask";
            this.tabTask.SelectedIndex = 0;
            this.tabTask.Size = new System.Drawing.Size(766, 408);
            this.tabTask.TabIndex = 2;
            // 
            // tabTaskProperty
            // 
            this.tabTaskProperty.BackColor = System.Drawing.SystemColors.Control;
            this.tabTaskProperty.Controls.Add(this.btnDeleteTask);
            this.tabTaskProperty.Controls.Add(this.btnEditTask);
            this.tabTaskProperty.Controls.Add(this.btnAddTask);
            this.tabTaskProperty.Controls.Add(this.m_taskList);
            this.tabTaskProperty.Location = new System.Drawing.Point(4, 22);
            this.tabTaskProperty.Name = "tabTaskProperty";
            this.tabTaskProperty.Padding = new System.Windows.Forms.Padding(3);
            this.tabTaskProperty.Size = new System.Drawing.Size(758, 382);
            this.tabTaskProperty.TabIndex = 0;
            this.tabTaskProperty.Text = "Task Properties";
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(671, 307);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(75, 28);
            this.btnDeleteTask.TabIndex = 3;
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.Location = new System.Drawing.Point(590, 307);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(75, 28);
            this.btnEditTask.TabIndex = 2;
            this.btnEditTask.Text = "Edit Task";
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(509, 307);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 28);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // m_taskList
            // 
            this.m_taskList.CurrentTask = null;
            this.m_taskList.Location = new System.Drawing.Point(0, 0);
            this.m_taskList.Name = "m_taskList";
            this.m_taskList.Size = new System.Drawing.Size(758, 301);
            this.m_taskList.TabIndex = 0;
            this.m_taskList.TaskGroup = taskGroup2;
            // 
            // tabRunStatus
            // 
            this.tabRunStatus.Controls.Add(this.textBox1);
            this.tabRunStatus.Location = new System.Drawing.Point(4, 22);
            this.tabRunStatus.Name = "tabRunStatus";
            this.tabRunStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabRunStatus.Size = new System.Drawing.Size(758, 382);
            this.tabRunStatus.TabIndex = 1;
            this.tabRunStatus.Text = "Task Run Status";
            this.tabRunStatus.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(752, 376);
            this.textBox1.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(656, 431);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(105, 30);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 431);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(105, 30);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load Task Group";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(123, 431);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Task Group";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TaskRunnerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 481);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tabTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TaskRunnerMain";
            this.Text = "Johnson Fan Task Runner";
            this.Load += new System.EventHandler(this.TaskRunnerMain_Load);
            this.tabTask.ResumeLayout(false);
            this.tabTaskProperty.ResumeLayout(false);
            this.tabRunStatus.ResumeLayout(false);
            this.tabRunStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTask;
        private System.Windows.Forms.TabPage tabTaskProperty;
        private System.Windows.Forms.TabPage tabRunStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private Components.TaskGroupListView m_taskList;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnEditTask;
    }
}

