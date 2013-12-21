namespace TaskRunner.Main.Components
{
    partial class TaskGroupListView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_listTaskGroup = new System.Windows.Forms.ListView();
            this.guiColId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guiColTaskName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guiColMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guiColDepends = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guiColExec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guiColParams = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // m_listTaskGroup
            // 
            this.m_listTaskGroup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.guiColId,
            this.guiColTaskName,
            this.guiColMax,
            this.guiColDepends,
            this.guiColExec,
            this.guiColParams});
            this.m_listTaskGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_listTaskGroup.FullRowSelect = true;
            this.m_listTaskGroup.GridLines = true;
            this.m_listTaskGroup.HideSelection = false;
            this.m_listTaskGroup.Location = new System.Drawing.Point(0, 0);
            this.m_listTaskGroup.MultiSelect = false;
            this.m_listTaskGroup.Name = "m_listTaskGroup";
            this.m_listTaskGroup.Size = new System.Drawing.Size(755, 300);
            this.m_listTaskGroup.TabIndex = 1;
            this.m_listTaskGroup.UseCompatibleStateImageBehavior = false;
            this.m_listTaskGroup.View = System.Windows.Forms.View.Details;
            // 
            // guiColId
            // 
            this.guiColId.Text = "Id";
            this.guiColId.Width = 35;
            // 
            // guiColTaskName
            // 
            this.guiColTaskName.Text = "TaskName";
            this.guiColTaskName.Width = 142;
            // 
            // guiColMax
            // 
            this.guiColMax.Text = "Max Minutes";
            this.guiColMax.Width = 75;
            // 
            // guiColDepends
            // 
            this.guiColDepends.Text = "Dependency";
            this.guiColDepends.Width = 96;
            // 
            // guiColExec
            // 
            this.guiColExec.Text = "Executable";
            this.guiColExec.Width = 110;
            // 
            // guiColParams
            // 
            this.guiColParams.Text = "Parameters";
            this.guiColParams.Width = 250;
            // 
            // TaskGroupListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_listTaskGroup);
            this.Name = "TaskGroupListView";
            this.Size = new System.Drawing.Size(755, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView m_listTaskGroup;
        private System.Windows.Forms.ColumnHeader guiColId;
        private System.Windows.Forms.ColumnHeader guiColDepends;
        private System.Windows.Forms.ColumnHeader guiColTaskName;
        private System.Windows.Forms.ColumnHeader guiColMax;
        private System.Windows.Forms.ColumnHeader guiColExec;
        private System.Windows.Forms.ColumnHeader guiColParams;
    }
}
