namespace Project_12_A_B
{
    partial class Student
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.AnnouncementTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Welcomelbl = new MetroFramework.Controls.MetroLabel();
            this.ScheduleBtn = new MetroFramework.Controls.MetroTile();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.nummsgs = new MetroFramework.Controls.MetroLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.YouTubeBtn = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Announcements = new MetroFramework.Controls.MetroLabel();
            this.LogOutBtn = new MetroFramework.Controls.MetroTile();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.ScheduleBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroTile1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.metroTile2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.YouTubeBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LogOutBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // AnnouncementTextBox
            // 
            this.AnnouncementTextBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.AnnouncementTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AnnouncementTextBox.ForeColor = System.Drawing.Color.Yellow;
            this.AnnouncementTextBox.Location = new System.Drawing.Point(386, 234);
            this.AnnouncementTextBox.Name = "AnnouncementTextBox";
            this.AnnouncementTextBox.ReadOnly = true;
            this.AnnouncementTextBox.Size = new System.Drawing.Size(531, 96);
            this.AnnouncementTextBox.TabIndex = 3;
            this.AnnouncementTextBox.Text = "No Available Announcements";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1330, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::Project_12_A_B.Properties.Resources.logout1;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Welcomelbl
            // 
            this.Welcomelbl.AutoSize = true;
            this.Welcomelbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Welcomelbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Welcomelbl.Location = new System.Drawing.Point(23, 84);
            this.Welcomelbl.Name = "Welcomelbl";
            this.Welcomelbl.Size = new System.Drawing.Size(86, 25);
            this.Welcomelbl.TabIndex = 16;
            this.Welcomelbl.Text = "Welcome";
            this.Welcomelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ScheduleBtn
            // 
            this.ScheduleBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ScheduleBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScheduleBtn.Controls.Add(this.pictureBox2);
            this.ScheduleBtn.Location = new System.Drawing.Point(386, 336);
            this.ScheduleBtn.Name = "ScheduleBtn";
            this.ScheduleBtn.Size = new System.Drawing.Size(151, 181);
            this.ScheduleBtn.Style = MetroFramework.MetroColorStyle.Lime;
            this.ScheduleBtn.TabIndex = 17;
            this.ScheduleBtn.Text = "My Schedule";
            this.ScheduleBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ScheduleBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ScheduleBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.ScheduleBtn.Click += new System.EventHandler(this.ScheduleBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_12_A_B.Properties.Resources.c31;
            this.pictureBox2.Location = new System.Drawing.Point(45, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 70);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Controls.Add(this.pictureBox4);
            this.metroTile1.Location = new System.Drawing.Point(543, 451);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(280, 66);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroTile1.TabIndex = 19;
            this.metroTile1.Text = "Requests";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Project_12_A_B.Properties.Resources.speech_bubble;
            this.pictureBox4.Location = new System.Drawing.Point(17, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 60);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // metroTile2
            // 
            this.metroTile2.Controls.Add(this.nummsgs);
            this.metroTile2.Controls.Add(this.pictureBox3);
            this.metroTile2.Location = new System.Drawing.Point(543, 336);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(130, 109);
            this.metroTile2.TabIndex = 20;
            this.metroTile2.Text = "Messages:";
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // nummsgs
            // 
            this.nummsgs.AutoSize = true;
            this.nummsgs.BackColor = System.Drawing.Color.LemonChiffon;
            this.nummsgs.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nummsgs.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.nummsgs.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.nummsgs.Location = new System.Drawing.Point(95, 84);
            this.nummsgs.Name = "nummsgs";
            this.nummsgs.Size = new System.Drawing.Size(22, 25);
            this.nummsgs.TabIndex = 1;
            this.nummsgs.Text = "1";
            this.nummsgs.Click += new System.EventHandler(this.nummsgs_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = global::Project_12_A_B.Properties.Resources.mail;
            this.pictureBox3.Location = new System.Drawing.Point(17, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // YouTubeBtn
            // 
            this.YouTubeBtn.Controls.Add(this.pictureBox1);
            this.YouTubeBtn.Location = new System.Drawing.Point(679, 336);
            this.YouTubeBtn.Name = "YouTubeBtn";
            this.YouTubeBtn.Size = new System.Drawing.Size(144, 109);
            this.YouTubeBtn.Style = MetroFramework.MetroColorStyle.Yellow;
            this.YouTubeBtn.TabIndex = 21;
            this.YouTubeBtn.Text = "YouTube";
            this.YouTubeBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.YouTubeBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.YouTubeBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.YouTubeBtn.Click += new System.EventHandler(this.YouTubeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_12_A_B.Properties.Resources.YouTubeIcon1;
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 65);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Announcements
            // 
            this.Announcements.AutoSize = true;
            this.Announcements.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Announcements.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Announcements.Location = new System.Drawing.Point(582, 206);
            this.Announcements.Name = "Announcements";
            this.Announcements.Size = new System.Drawing.Size(151, 25);
            this.Announcements.TabIndex = 22;
            this.Announcements.Text = "Announcements";
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Controls.Add(this.pictureBox5);
            this.LogOutBtn.Location = new System.Drawing.Point(830, 339);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(87, 178);
            this.LogOutBtn.Style = MetroFramework.MetroColorStyle.Purple;
            this.LogOutBtn.TabIndex = 23;
            this.LogOutBtn.Text = "LogOut";
            this.LogOutBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.LogOutBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Project_12_A_B.Properties.Resources.logout3;
            this.pictureBox5.Location = new System.Drawing.Point(20, 53);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 53);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // Student
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.ControlBox = false;
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.Announcements);
            this.Controls.Add(this.YouTubeBtn);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.ScheduleBtn);
            this.Controls.Add(this.Welcomelbl);
            this.Controls.Add(this.AnnouncementTextBox);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Movable = false;
            this.Name = "Student";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Student Portal";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ScheduleBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroTile1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.metroTile2.ResumeLayout(false);
            this.metroTile2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.YouTubeBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LogOutBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.RichTextBox AnnouncementTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel Welcomelbl;
        private MetroFramework.Controls.MetroTile ScheduleBtn;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private MetroFramework.Controls.MetroTile YouTubeBtn;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel Announcements;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroTile LogOutBtn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MetroFramework.Controls.MetroLabel nummsgs;
    }
}