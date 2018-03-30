namespace Project_12_A_B
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ERRORMSGLogin = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LoginLbl = new System.Windows.Forms.Label();
            this.ID = new MetroFramework.Controls.MetroLabel();
            this.Passlbl = new MetroFramework.Controls.MetroLabel();
            this.passwordtext = new MetroFramework.Controls.MetroTextBox();
            this.IdText = new MetroFramework.Controls.MetroTextBox();
            this.LoginBtn = new MetroFramework.Controls.MetroTile();
            this.ErrorLbl = new System.Windows.Forms.Label();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.metroTile1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.visitUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(27, 74);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1019, 31);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Image = global::Project_12_A_B.Properties.Resources.logout;
            this.exitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(69, 27);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 27);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // visitUsToolStripMenuItem
            // 
            this.visitUsToolStripMenuItem.Name = "visitUsToolStripMenuItem";
            this.visitUsToolStripMenuItem.Size = new System.Drawing.Size(69, 27);
            this.visitUsToolStripMenuItem.Text = "Visit Us";
            this.visitUsToolStripMenuItem.Click += new System.EventHandler(this.visitUsToolStripMenuItem_Click);
            // 
            // ERRORMSGLogin
            // 
            this.ERRORMSGLogin.AutoSize = true;
            this.ERRORMSGLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ERRORMSGLogin.Location = new System.Drawing.Point(684, 380);
            this.ERRORMSGLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ERRORMSGLogin.Name = "ERRORMSGLogin";
            this.ERRORMSGLogin.Size = new System.Drawing.Size(0, 29);
            this.ERRORMSGLogin.TabIndex = 7;
            this.ERRORMSGLogin.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // LoginLbl
            // 
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLbl.ForeColor = System.Drawing.Color.Black;
            this.LoginLbl.Location = new System.Drawing.Point(725, 108);
            this.LoginLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(229, 83);
            this.LoginLbl.TabIndex = 0;
            this.LoginLbl.Text = "Login";
            this.LoginLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ID.Location = new System.Drawing.Point(823, 250);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(32, 25);
            this.ID.TabIndex = 10;
            this.ID.Text = "ID";
            this.ID.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ID.UseStyleColors = true;
            this.ID.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Passlbl
            // 
            this.Passlbl.AutoSize = true;
            this.Passlbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Passlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Passlbl.Location = new System.Drawing.Point(796, 337);
            this.Passlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Passlbl.Name = "Passlbl";
            this.Passlbl.Size = new System.Drawing.Size(76, 20);
            this.Passlbl.TabIndex = 11;
            this.Passlbl.Text = "Password";
            this.Passlbl.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Passlbl.UseStyleColors = true;
            // 
            // passwordtext
            // 
            this.passwordtext.BackColor = System.Drawing.Color.White;
            this.passwordtext.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.passwordtext.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.passwordtext.ForeColor = System.Drawing.Color.Lime;
            this.passwordtext.Location = new System.Drawing.Point(761, 364);
            this.passwordtext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.PasswordChar = '●';
            this.passwordtext.Size = new System.Drawing.Size(167, 28);
            this.passwordtext.Style = MetroFramework.MetroColorStyle.Green;
            this.passwordtext.TabIndex = 12;
            this.passwordtext.Text = "password";
            this.passwordtext.UseSystemPasswordChar = true;
            this.passwordtext.Click += new System.EventHandler(this.passwordtext_Click);
            this.passwordtext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordtext_KeyDown);
            // 
            // IdText
            // 
            this.IdText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.IdText.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.IdText.ForeColor = System.Drawing.Color.Lime;
            this.IdText.Location = new System.Drawing.Point(761, 284);
            this.IdText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(167, 28);
            this.IdText.Style = MetroFramework.MetroColorStyle.Green;
            this.IdText.TabIndex = 13;
            this.IdText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nametext_KeyDown);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(761, 425);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(167, 50);
            this.LoginBtn.TabIndex = 14;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.LoginBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ErrorLbl
            // 
            this.ErrorLbl.AutoSize = true;
            this.ErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.ErrorLbl.Location = new System.Drawing.Point(704, 405);
            this.ErrorLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorLbl.Name = "ErrorLbl";
            this.ErrorLbl.Size = new System.Drawing.Size(275, 17);
            this.ErrorLbl.TabIndex = 15;
            this.ErrorLbl.Text = "No such this Username or Password.";
            this.ErrorLbl.Visible = false;
            // 
            // metroTile1
            // 
            this.metroTile1.Controls.Add(this.pictureBox2);
            this.metroTile1.Location = new System.Drawing.Point(379, 31);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(279, 39);
            this.metroTile1.TabIndex = 16;
            this.metroTile1.Text = "Login Via FaceBook|";
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_12_A_B.Properties.Resources.facebook;
            this.pictureBox2.Location = new System.Drawing.Point(245, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 36);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_12_A_B.Properties.Resources.login_img1;
            this.pictureBox1.Location = new System.Drawing.Point(31, 108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 448);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 609);
            this.ControlBox = false;
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.ErrorLbl);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.IdText);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.Passlbl);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ERRORMSGLogin);
            this.Controls.Add(this.LoginLbl);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Movable = false;
            this.Name = "login";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.passwordtext_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.metroTile1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label ERRORMSGLogin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem visitUsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LoginLbl;
        private MetroFramework.Controls.MetroLabel ID;
        private MetroFramework.Controls.MetroLabel Passlbl;
        private MetroFramework.Controls.MetroTextBox passwordtext;
        private MetroFramework.Controls.MetroTextBox IdText;
        private MetroFramework.Controls.MetroTile LoginBtn;
        private System.Windows.Forms.Label ErrorLbl;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

