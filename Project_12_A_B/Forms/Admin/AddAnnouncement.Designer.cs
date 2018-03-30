namespace Project_12_A_B
{
    partial class AddAnnouncement
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
            this.AnnouncementTextBox = new System.Windows.Forms.TextBox();
            this.PostAnnButtonAdmin = new System.Windows.Forms.Button();
            this.CancelAnnadmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(100, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Whats on your mind?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AnnouncementTextBox
            // 
            this.AnnouncementTextBox.Location = new System.Drawing.Point(12, 135);
            this.AnnouncementTextBox.Multiline = true;
            this.AnnouncementTextBox.Name = "AnnouncementTextBox";
            this.AnnouncementTextBox.Size = new System.Drawing.Size(633, 80);
            this.AnnouncementTextBox.TabIndex = 1;
            // 
            // PostAnnButtonAdmin
            // 
            this.PostAnnButtonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostAnnButtonAdmin.Location = new System.Drawing.Point(559, 235);
            this.PostAnnButtonAdmin.Name = "PostAnnButtonAdmin";
            this.PostAnnButtonAdmin.Size = new System.Drawing.Size(86, 32);
            this.PostAnnButtonAdmin.TabIndex = 2;
            this.PostAnnButtonAdmin.Text = "Post";
            this.PostAnnButtonAdmin.UseVisualStyleBackColor = true;
            this.PostAnnButtonAdmin.Click += new System.EventHandler(this.PostAnnButtonAdmin_Click);
            // 
            // CancelAnnadmin
            // 
            this.CancelAnnadmin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAnnadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelAnnadmin.Location = new System.Drawing.Point(470, 235);
            this.CancelAnnadmin.Name = "CancelAnnadmin";
            this.CancelAnnadmin.Size = new System.Drawing.Size(83, 32);
            this.CancelAnnadmin.TabIndex = 3;
            this.CancelAnnadmin.Text = "Cancel";
            this.CancelAnnadmin.UseVisualStyleBackColor = true;
            this.CancelAnnadmin.Click += new System.EventHandler(this.CancelAnnadmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_12_A_B.Properties.Resources.announcement;
            this.pictureBox1.Location = new System.Drawing.Point(23, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 70);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AddAnnouncement
            // 
            this.AcceptButton = this.PostAnnButtonAdmin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelAnnadmin;
            this.ClientSize = new System.Drawing.Size(664, 290);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CancelAnnadmin);
            this.Controls.Add(this.PostAnnButtonAdmin);
            this.Controls.Add(this.AnnouncementTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddAnnouncement";
            this.Text = "Puplish Announcement";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AddAnnouncement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AnnouncementTextBox;
        private System.Windows.Forms.Button PostAnnButtonAdmin;
        private System.Windows.Forms.Button CancelAnnadmin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}