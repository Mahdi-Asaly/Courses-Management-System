namespace Project_12_A_B
{
    partial class Technical
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.technicalRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnnLbl = new System.Windows.Forms.Label();
            this.AnnouncementTextBox = new System.Windows.Forms.RichTextBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.metroTile1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTile3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Yellow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.technicalRequestsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // technicalRequestsToolStripMenuItem
            // 
            this.technicalRequestsToolStripMenuItem.Name = "technicalRequestsToolStripMenuItem";
            this.technicalRequestsToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.technicalRequestsToolStripMenuItem.Text = "Technical Requests";
            this.technicalRequestsToolStripMenuItem.Click += new System.EventHandler(this.technicalRequestsToolStripMenuItem_Click);
            // 
            // AnnLbl
            // 
            this.AnnLbl.AutoSize = true;
            this.AnnLbl.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnLbl.ForeColor = System.Drawing.Color.Yellow;
            this.AnnLbl.Location = new System.Drawing.Point(774, 212);
            this.AnnLbl.Name = "AnnLbl";
            this.AnnLbl.Size = new System.Drawing.Size(256, 38);
            this.AnnLbl.TabIndex = 3;
            this.AnnLbl.Text = "Announcements";
            this.AnnLbl.Click += new System.EventHandler(this.AnnLbl_Click);
            // 
            // AnnouncementTextBox
            // 
            this.AnnouncementTextBox.BackColor = System.Drawing.Color.Yellow;
            this.AnnouncementTextBox.Font = new System.Drawing.Font("Miriam Fixed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnouncementTextBox.ForeColor = System.Drawing.Color.Blue;
            this.AnnouncementTextBox.Location = new System.Drawing.Point(683, 275);
            this.AnnouncementTextBox.Name = "AnnouncementTextBox";
            this.AnnouncementTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.AnnouncementTextBox.Size = new System.Drawing.Size(474, 209);
            this.AnnouncementTextBox.TabIndex = 4;
            this.AnnouncementTextBox.Text = "No Availble Messages";
            this.AnnouncementTextBox.TextChanged += new System.EventHandler(this.AnnouncementTextBox_TextChanged);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.Yellow;
            this.WelcomeLabel.Location = new System.Drawing.Point(3, 102);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(93, 24);
            this.WelcomeLabel.TabIndex = 5;
            this.WelcomeLabel.Text = "Welcome";
            // 
            // metroTile1
            // 
            this.metroTile1.Controls.Add(this.pictureBox1);
            this.metroTile1.Location = new System.Drawing.Point(207, 291);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(266, 96);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroTile1.TabIndex = 6;
            this.metroTile1.Text = "Logout";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_12_A_B.Properties.Resources.logout4;
            this.pictureBox1.Location = new System.Drawing.Point(100, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 51);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroTile3
            // 
            this.metroTile3.Controls.Add(this.pictureBox3);
            this.metroTile3.Location = new System.Drawing.Point(207, 393);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(266, 91);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile3.TabIndex = 8;
            this.metroTile3.Text = "Technical Requests";
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Project_12_A_B.Properties.Resources.url;
            this.pictureBox3.Location = new System.Drawing.Point(100, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 50);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Project_12_A_B.Properties.Resources.announcement;
            this.pictureBox5.Location = new System.Drawing.Point(888, 156);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(68, 69);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // Technical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.AnnouncementTextBox);
            this.Controls.Add(this.AnnLbl);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = false;
            this.MainMenuStrip = this.menuStrip1;
            this.Movable = false;
            this.Name = "Technical";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Technical";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Technical_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.metroTile1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTile3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem technicalRequestsToolStripMenuItem;
        private System.Windows.Forms.Label AnnLbl;
        private System.Windows.Forms.RichTextBox AnnouncementTextBox;
        private System.Windows.Forms.Label WelcomeLabel;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}