namespace TaskRunner.Main.Components
{
    partial class TaskDetailEntry
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.txtDepends = new System.Windows.Forms.TextBox();
            this.lblDepends = new System.Windows.Forms.Label();
            this.txtMaxMinutes = new System.Windows.Forms.TextBox();
            this.lblMaxMin = new System.Windows.Forms.Label();
            this.txtExec = new System.Windows.Forms.TextBox();
            this.lblExec = new System.Windows.Forms.Label();
            this.txtParam = new System.Windows.Forms.TextBox();
            this.lblParam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(66, 21);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(85, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(125, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(85, 44);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(125, 20);
            this.txtTaskName.TabIndex = 3;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(20, 47);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(62, 13);
            this.lblTaskName.TabIndex = 2;
            this.lblTaskName.Text = "Task Name";
            // 
            // txtDepends
            // 
            this.txtDepends.Location = new System.Drawing.Point(314, 18);
            this.txtDepends.Name = "txtDepends";
            this.txtDepends.Size = new System.Drawing.Size(125, 20);
            this.txtDepends.TabIndex = 5;
            // 
            // lblDepends
            // 
            this.lblDepends.AutoSize = true;
            this.lblDepends.Location = new System.Drawing.Point(234, 23);
            this.lblDepends.Name = "lblDepends";
            this.lblDepends.Size = new System.Drawing.Size(77, 13);
            this.lblDepends.TabIndex = 4;
            this.lblDepends.Text = "Dependent Ids";
            // 
            // txtMaxMinutes
            // 
            this.txtMaxMinutes.Location = new System.Drawing.Point(314, 44);
            this.txtMaxMinutes.Name = "txtMaxMinutes";
            this.txtMaxMinutes.Size = new System.Drawing.Size(125, 20);
            this.txtMaxMinutes.TabIndex = 7;
            // 
            // lblMaxMin
            // 
            this.lblMaxMin.AutoSize = true;
            this.lblMaxMin.Location = new System.Drawing.Point(244, 47);
            this.lblMaxMin.Name = "lblMaxMin";
            this.lblMaxMin.Size = new System.Drawing.Size(67, 13);
            this.lblMaxMin.TabIndex = 6;
            this.lblMaxMin.Text = "Max Minutes";
            // 
            // txtExec
            // 
            this.txtExec.Location = new System.Drawing.Point(85, 70);
            this.txtExec.Name = "txtExec";
            this.txtExec.Size = new System.Drawing.Size(354, 20);
            this.txtExec.TabIndex = 9;
            // 
            // lblExec
            // 
            this.lblExec.AutoSize = true;
            this.lblExec.Location = new System.Drawing.Point(22, 73);
            this.lblExec.Name = "lblExec";
            this.lblExec.Size = new System.Drawing.Size(60, 13);
            this.lblExec.TabIndex = 8;
            this.lblExec.Text = "Executable";
            // 
            // txtParam
            // 
            this.txtParam.Location = new System.Drawing.Point(85, 96);
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(354, 20);
            this.txtParam.TabIndex = 11;
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Location = new System.Drawing.Point(22, 100);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(60, 13);
            this.lblParam.TabIndex = 10;
            this.lblParam.Text = "Parameters";
            // 
            // TaskDetailEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtParam);
            this.Controls.Add(this.lblParam);
            this.Controls.Add(this.txtExec);
            this.Controls.Add(this.lblExec);
            this.Controls.Add(this.txtMaxMinutes);
            this.Controls.Add(this.lblMaxMin);
            this.Controls.Add(this.txtDepends);
            this.Controls.Add(this.lblDepends);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "TaskDetailEntry";
            this.Size = new System.Drawing.Size(464, 139);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.TextBox txtDepends;
        private System.Windows.Forms.Label lblDepends;
        private System.Windows.Forms.TextBox txtMaxMinutes;
        private System.Windows.Forms.Label lblMaxMin;
        private System.Windows.Forms.TextBox txtExec;
        private System.Windows.Forms.Label lblExec;
        private System.Windows.Forms.TextBox txtParam;
        private System.Windows.Forms.Label lblParam;
    }
}
