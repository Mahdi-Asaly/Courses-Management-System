namespace Project_12_A_B
{
    partial class Announcements
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
            this.AnnouncementTextBox = new System.Windows.Forms.RichTextBox();
            this.CloseBtn = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // AnnouncementTextBox
            // 
            this.AnnouncementTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnouncementTextBox.Location = new System.Drawing.Point(133, 94);
            this.AnnouncementTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AnnouncementTextBox.Name = "AnnouncementTextBox";
            this.AnnouncementTextBox.ReadOnly = true;
            this.AnnouncementTextBox.Size = new System.Drawing.Size(473, 163);
            this.AnnouncementTextBox.TabIndex = 4;
            this.AnnouncementTextBox.Text = "No Announcements Available";
            // 
            // CloseBtn
            // 
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBtn.Location = new System.Drawing.Point(306, 324);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(124, 26);
            this.CloseBtn.Style = MetroFramework.MetroColorStyle.Teal;
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CloseBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Announcements
            // 
            this.AcceptButton = this.CloseBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.CloseBtn;
            this.ClientSize = new System.Drawing.Size(758, 377);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AnnouncementTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Announcements";
            this.Padding = new System.Windows.Forms.Padding(24, 69, 24, 23);
            this.Text = "Announcements";
            this.Load += new System.EventHandler(this.Announcements_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox AnnouncementTextBox;
        private MetroFramework.Controls.MetroTile CloseBtn;
    }
}