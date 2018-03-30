namespace Project_12_A_B
{
    partial class EditStudentInfoSec
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.IdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.FindBtn = new MetroFramework.Controls.MetroTile();
            this.EmailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.AddressTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.AddressLbl = new MetroFramework.Controls.MetroLabel();
            this.NameLbl = new MetroFramework.Controls.MetroLabel();
            this.SemesterLabel = new MetroFramework.Controls.MetroLabel();
            this.savebtn = new MetroFramework.Controls.MetroTile();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.StudIDTextBox = new MetroFramework.Controls.MetroTextBox();
            this.Password = new MetroFramework.Controls.MetroLabel();
            this.ID = new MetroFramework.Controls.MetroLabel();
            this.SemesterBox = new MetroFramework.Controls.MetroComboBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(25, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(139, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Enter Student ID:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(165, 78);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(221, 23);
            this.IdTextBox.TabIndex = 1;
            // 
            // FindBtn
            // 
            this.FindBtn.Location = new System.Drawing.Point(392, 78);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(58, 23);
            this.FindBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.FindBtn.TabIndex = 2;
            this.FindBtn.Text = "Find";
            this.FindBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.EmailTextBox.Location = new System.Drawing.Point(165, 264);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(285, 23);
            this.EmailTextBox.TabIndex = 29;
            this.EmailTextBox.Visible = false;
            this.EmailTextBox.Click += new System.EventHandler(this.EmailTextBox_Click);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.AddressTextBox.Location = new System.Drawing.Point(165, 215);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(285, 23);
            this.AddressTextBox.TabIndex = 28;
            this.AddressTextBox.Visible = false;
            this.AddressTextBox.Click += new System.EventHandler(this.AddressTextBox_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(26, 262);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 25);
            this.metroLabel3.TabIndex = 27;
            this.metroLabel3.Text = "Email:";
            this.metroLabel3.Visible = false;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.AddressLbl.Location = new System.Drawing.Point(26, 219);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(76, 25);
            this.AddressLbl.TabIndex = 26;
            this.AddressLbl.Text = "Address:";
            this.AddressLbl.Visible = false;
            this.AddressLbl.Click += new System.EventHandler(this.AddressLbl_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.NameLbl.Location = new System.Drawing.Point(26, 143);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(62, 25);
            this.NameLbl.TabIndex = 25;
            this.NameLbl.Text = "Name:";
            this.NameLbl.Visible = false;
            this.NameLbl.Click += new System.EventHandler(this.NameLbl_Click);
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SemesterLabel.Location = new System.Drawing.Point(26, 307);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(86, 25);
            this.SemesterLabel.TabIndex = 24;
            this.SemesterLabel.Text = "Semester:";
            this.SemesterLabel.Visible = false;
            this.SemesterLabel.Click += new System.EventHandler(this.SemesterLabel_Click);
            // 
            // savebtn
            // 
            this.savebtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.savebtn.Location = new System.Drawing.Point(25, 350);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(219, 23);
            this.savebtn.Style = MetroFramework.MetroColorStyle.Lime;
            this.savebtn.TabIndex = 22;
            this.savebtn.Text = "Save";
            this.savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.savebtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.savebtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.savebtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PasswordTextBox.Location = new System.Drawing.Point(165, 178);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(285, 23);
            this.PasswordTextBox.TabIndex = 21;
            this.PasswordTextBox.Visible = false;
            this.PasswordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.NameTextBox.Location = new System.Drawing.Point(165, 140);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(285, 23);
            this.NameTextBox.TabIndex = 20;
            this.NameTextBox.Visible = false;
            this.NameTextBox.Click += new System.EventHandler(this.NameTextBox_Click);
            // 
            // StudIDTextBox
            // 
            this.StudIDTextBox.BackColor = System.Drawing.Color.White;
            this.StudIDTextBox.Enabled = false;
            this.StudIDTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.StudIDTextBox.Location = new System.Drawing.Point(165, 107);
            this.StudIDTextBox.Name = "StudIDTextBox";
            this.StudIDTextBox.ReadOnly = true;
            this.StudIDTextBox.Size = new System.Drawing.Size(285, 23);
            this.StudIDTextBox.TabIndex = 19;
            this.StudIDTextBox.Visible = false;
            this.StudIDTextBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Password.Location = new System.Drawing.Point(25, 182);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(86, 25);
            this.Password.TabIndex = 18;
            this.Password.Text = "Password:";
            this.Password.Visible = false;
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ID.Location = new System.Drawing.Point(26, 107);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(32, 25);
            this.ID.TabIndex = 17;
            this.ID.Text = "ID:";
            this.ID.Visible = false;
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // SemesterBox
            // 
            this.SemesterBox.FormattingEnabled = true;
            this.SemesterBox.ItemHeight = 23;
            this.SemesterBox.Location = new System.Drawing.Point(165, 307);
            this.SemesterBox.Name = "SemesterBox";
            this.SemesterBox.Size = new System.Drawing.Size(58, 29);
            this.SemesterBox.TabIndex = 30;
            this.SemesterBox.Visible = false;
            this.SemesterBox.SelectedIndexChanged += new System.EventHandler(this.SemesterBox_SelectedIndexChanged);
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(250, 350);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(200, 23);
            this.metroTile1.TabIndex = 31;
            this.metroTile1.Text = "Close";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // EditStudentInfoSec
            // 
            this.AcceptButton = this.FindBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 396);
            this.ControlBox = false;
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.SemesterBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.SemesterLabel);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.StudIDTextBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Movable = false;
            this.Name = "EditStudentInfoSec";
            this.Resizable = false;
            this.Text = "Student Information";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.EditStudentInfoSec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox IdTextBox;
        private MetroFramework.Controls.MetroTile FindBtn;
        private MetroFramework.Controls.MetroTextBox EmailTextBox;
        private MetroFramework.Controls.MetroTextBox AddressTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel AddressLbl;
        private MetroFramework.Controls.MetroLabel NameLbl;
        private MetroFramework.Controls.MetroLabel SemesterLabel;
        private MetroFramework.Controls.MetroTile savebtn;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private MetroFramework.Controls.MetroTextBox NameTextBox;
        private MetroFramework.Controls.MetroTextBox StudIDTextBox;
        private MetroFramework.Controls.MetroLabel Password;
        private MetroFramework.Controls.MetroLabel ID;
        private MetroFramework.Controls.MetroComboBox SemesterBox;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}