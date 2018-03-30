namespace Project_12_A_B
{
    partial class StudentPortalForm
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
            this.warpper = new MetroFramework.Controls.MetroPanel();
            this.LogoutBtn = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GotoStudentForm_btn = new MetroFramework.Controls.MetroTile();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.info_btn = new MetroFramework.Controls.MetroTile();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.userNameLable = new System.Windows.Forms.Label();
            this.warpper.SuspendLayout();
            this.LogoutBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GotoStudentForm_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.info_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // warpper
            // 
            this.warpper.Controls.Add(this.LogoutBtn);
            this.warpper.Controls.Add(this.GotoStudentForm_btn);
            this.warpper.Controls.Add(this.info_btn);
            this.warpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warpper.HorizontalScrollbarBarColor = true;
            this.warpper.HorizontalScrollbarHighlightOnWheel = false;
            this.warpper.HorizontalScrollbarSize = 0;
            this.warpper.Location = new System.Drawing.Point(20, 60);
            this.warpper.Name = "warpper";
            this.warpper.Size = new System.Drawing.Size(615, 207);
            this.warpper.TabIndex = 5;
            this.warpper.VerticalScrollbarBarColor = true;
            this.warpper.VerticalScrollbarHighlightOnWheel = false;
            this.warpper.VerticalScrollbarSize = 0;
            this.warpper.Paint += new System.Windows.Forms.PaintEventHandler(this.warpper_Paint);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Controls.Add(this.pictureBox1);
            this.LogoutBtn.Location = new System.Drawing.Point(437, 0);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(175, 203);
            this.LogoutBtn.Style = MetroFramework.MetroColorStyle.Magenta;
            this.LogoutBtn.TabIndex = 10;
            this.LogoutBtn.Text = "LogOut";
            this.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LogoutBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.LogoutBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_12_A_B.Properties.Resources.logout5;
            this.pictureBox1.Location = new System.Drawing.Point(38, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 59);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GotoStudentForm_btn
            // 
            this.GotoStudentForm_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.GotoStudentForm_btn.Controls.Add(this.pictureBox2);
            this.GotoStudentForm_btn.Location = new System.Drawing.Point(201, 3);
            this.GotoStudentForm_btn.Name = "GotoStudentForm_btn";
            this.GotoStudentForm_btn.Size = new System.Drawing.Size(230, 200);
            this.GotoStudentForm_btn.Style = MetroFramework.MetroColorStyle.Lime;
            this.GotoStudentForm_btn.TabIndex = 9;
            this.GotoStudentForm_btn.Text = "Schedule";
            this.GotoStudentForm_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GotoStudentForm_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.GotoStudentForm_btn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.GotoStudentForm_btn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.GotoStudentForm_btn.Click += new System.EventHandler(this.GotoStudentForm_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_12_A_B.Properties.Resources.c21;
            this.pictureBox2.Location = new System.Drawing.Point(64, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 71);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // info_btn
            // 
            this.info_btn.Controls.Add(this.pictureBox3);
            this.info_btn.Location = new System.Drawing.Point(3, 3);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(192, 200);
            this.info_btn.Style = MetroFramework.MetroColorStyle.Yellow;
            this.info_btn.TabIndex = 2;
            this.info_btn.Text = "My profile";
            this.info_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.info_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.info_btn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.info_btn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Project_12_A_B.Properties.Resources.Settings_502;
            this.pictureBox3.Location = new System.Drawing.Point(14, 78);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 68);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // userNameLable
            // 
            this.userNameLable.AutoSize = true;
            this.userNameLable.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLable.Location = new System.Drawing.Point(279, 22);
            this.userNameLable.Name = "userNameLable";
            this.userNameLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userNameLable.Size = new System.Drawing.Size(0, 22);
            this.userNameLable.TabIndex = 4;
            this.userNameLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StudentPortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 287);
            this.Controls.Add(this.warpper);
            this.Controls.Add(this.userNameLable);
            this.Name = "StudentPortalForm";
            this.Text = "Student Portal";
            this.Load += new System.EventHandler(this.StudentPortalForm_Load);
            this.warpper.ResumeLayout(false);
            this.LogoutBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GotoStudentForm_btn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.info_btn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel warpper;
        private MetroFramework.Controls.MetroTile GotoStudentForm_btn;
        private MetroFramework.Controls.MetroTile info_btn;
        private System.Windows.Forms.Label userNameLable;
        private MetroFramework.Controls.MetroTile LogoutBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}