namespace Prism.Forms.Plugin.Wizard
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
            this.chkNuget = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkiOS
            // 
            this.chkiOS.AutoSize = true;
            this.chkiOS.Checked = true;
            this.chkiOS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkiOS.Location = new System.Drawing.Point(66, 70);
            this.chkiOS.Margin = new System.Windows.Forms.Padding(5);
            this.chkiOS.Name = "chkiOS";
            this.chkiOS.Size = new System.Drawing.Size(58, 23);
            this.chkiOS.TabIndex = 0;
            this.chkiOS.Text = "iOS";
            this.chkiOS.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(66, 158);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(385, 37);
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
            this.chkDroid.Location = new System.Drawing.Point(165, 70);
            this.chkDroid.Margin = new System.Windows.Forms.Padding(5);
            this.chkDroid.Name = "chkDroid";
            this.chkDroid.Size = new System.Drawing.Size(98, 23);
            this.chkDroid.TabIndex = 0;
            this.chkDroid.Text = "Android";
            this.chkDroid.UseVisualStyleBackColor = true;
            // 
            // chkUWP
            // 
            this.chkUWP.AutoSize = true;
            this.chkUWP.Checked = true;
            this.chkUWP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUWP.Location = new System.Drawing.Point(310, 70);
            this.chkUWP.Margin = new System.Windows.Forms.Padding(5);
            this.chkUWP.Name = "chkUWP";
            this.chkUWP.Size = new System.Drawing.Size(58, 23);
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
            this.chkPCL.Location = new System.Drawing.Point(66, 19);
            this.chkPCL.Margin = new System.Windows.Forms.Padding(5);
            this.chkPCL.Name = "chkPCL";
            this.chkPCL.Size = new System.Drawing.Size(58, 23);
            this.chkPCL.TabIndex = 0;
            this.chkPCL.Text = "PCL";
            this.chkPCL.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(66, 204);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(385, 37);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkNuget
            // 
            this.chkNuget.AutoSize = true;
            this.chkNuget.Checked = true;
            this.chkNuget.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNuget.Location = new System.Drawing.Point(165, 19);
            this.chkNuget.Margin = new System.Windows.Forms.Padding(5);
            this.chkNuget.Name = "chkNuget";
            this.chkNuget.Size = new System.Drawing.Size(228, 23);
            this.chkNuget.TabIndex = 0;
            this.chkNuget.Text = "Nuspec(Package File)";
            this.chkNuget.UseVisualStyleBackColor = true;
            this.chkNuget.Visible = false;
            // 
            // PluginNewProjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 269);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.chkUWP);
            this.Controls.Add(this.chkNuget);
            this.Controls.Add(this.chkPCL);
            this.Controls.Add(this.chkDroid);
            this.Controls.Add(this.chkiOS);
            this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PluginNewProjectDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choice the items";
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
        private System.Windows.Forms.CheckBox chkNuget;
    }
}