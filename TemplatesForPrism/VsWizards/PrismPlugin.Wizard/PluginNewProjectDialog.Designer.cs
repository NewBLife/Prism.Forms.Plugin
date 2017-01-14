namespace PrismPlugin.Wizard
{
    partial class PluginNewProjectDialog
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
            this.chkiOS = new System.Windows.Forms.CheckBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.chkDroid = new System.Windows.Forms.CheckBox();
            this.chkUWP = new System.Windows.Forms.CheckBox();
            this.chkPCL = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkiOS
            // 
            this.chkiOS.AutoSize = true;
            this.chkiOS.Checked = true;
            this.chkiOS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkiOS.Location = new System.Drawing.Point(40, 64);
            this.chkiOS.Name = "chkiOS";
            this.chkiOS.Size = new System.Drawing.Size(42, 16);
            this.chkiOS.TabIndex = 0;
            this.chkiOS.Text = "iOS";
            this.chkiOS.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(40, 100);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(231, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // chkDroid
            // 
            this.chkDroid.AutoSize = true;
            this.chkDroid.Checked = true;
            this.chkDroid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDroid.Location = new System.Drawing.Point(129, 64);
            this.chkDroid.Name = "chkDroid";
            this.chkDroid.Size = new System.Drawing.Size(66, 16);
            this.chkDroid.TabIndex = 0;
            this.chkDroid.Text = "Android";
            this.chkDroid.UseVisualStyleBackColor = true;
            // 
            // chkUWP
            // 
            this.chkUWP.AutoSize = true;
            this.chkUWP.Checked = true;
            this.chkUWP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUWP.Location = new System.Drawing.Point(229, 64);
            this.chkUWP.Name = "chkUWP";
            this.chkUWP.Size = new System.Drawing.Size(42, 16);
            this.chkUWP.TabIndex = 0;
            this.chkUWP.Text = "UWP";
            this.chkUWP.UseVisualStyleBackColor = true;
            // 
            // chkPCL
            // 
            this.chkPCL.AutoSize = true;
            this.chkPCL.Checked = true;
            this.chkPCL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPCL.Enabled = false;
            this.chkPCL.Location = new System.Drawing.Point(129, 12);
            this.chkPCL.Name = "chkPCL";
            this.chkPCL.Size = new System.Drawing.Size(42, 16);
            this.chkPCL.TabIndex = 0;
            this.chkPCL.Text = "PCL";
            this.chkPCL.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(40, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(231, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PluginNewProjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 164);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.chkUWP);
            this.Controls.Add(this.chkPCL);
            this.Controls.Add(this.chkDroid);
            this.Controls.Add(this.chkiOS);
            this.Name = "PluginNewProjectDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select the plartform";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PluginNewProjectDialog_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkiOS;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.CheckBox chkDroid;
        private System.Windows.Forms.CheckBox chkUWP;
        private System.Windows.Forms.CheckBox chkPCL;
        private System.Windows.Forms.Button btnCancel;
    }
}