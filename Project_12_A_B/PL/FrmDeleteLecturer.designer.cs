namespace Project_Sce.PL
{
    partial class FrmDeleteLecturer
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRemoveLecturer = new System.Windows.Forms.Button();
            this.Pid = new System.Windows.Forms.TextBox();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(72, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Lecturer ID :";
            // 
            // buttonRemoveLecturer
            // 
            this.buttonRemoveLecturer.ForeColor = System.Drawing.Color.Red;
            this.buttonRemoveLecturer.Location = new System.Drawing.Point(483, 103);
            this.buttonRemoveLecturer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRemoveLecturer.Name = "buttonRemoveLecturer";
            this.buttonRemoveLecturer.Size = new System.Drawing.Size(172, 23);
            this.buttonRemoveLecturer.TabIndex = 1;
            this.buttonRemoveLecturer.Text = "Delete Lecturer";
            this.buttonRemoveLecturer.UseVisualStyleBackColor = true;
            this.buttonRemoveLecturer.Click += new System.EventHandler(this.buttonRemoveLecturer_Click);
            // 
            // Pid
            // 
            this.Pid.Location = new System.Drawing.Point(258, 103);
            this.Pid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Pid.Name = "Pid";
            this.Pid.Size = new System.Drawing.Size(184, 21);
            this.Pid.TabIndex = 2;
            this.Pid.TextChanged += new System.EventHandler(this.Pid_TextChanged);
            // 
            // ReturnButton
            // 
            this.ReturnButton.ForeColor = System.Drawing.Color.Green;
            this.ReturnButton.Location = new System.Drawing.Point(89, 187);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 3;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            this.LogoutButton.ForeColor = System.Drawing.Color.Red;
            this.LogoutButton.Location = new System.Drawing.Point(526, 40);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(81, 23);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // FrmDeleteLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 261);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.Pid);
            this.Controls.Add(this.buttonRemoveLecturer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Miriam Fixed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmDeleteLecturer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDeleteLecturer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRemoveLecturer;
        private System.Windows.Forms.TextBox Pid;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}