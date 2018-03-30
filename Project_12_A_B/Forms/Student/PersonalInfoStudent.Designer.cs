using System.Windows.Forms;
namespace Project_12_A_B.Forms.Student
{
    partial class PersonalInfoStudent
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
            this.ID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Password = new MetroFramework.Controls.MetroLabel();
            this.IdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.Names = new MetroFramework.Controls.MetroLabel();
            this.savebtn = new MetroFramework.Controls.MetroTile();
            this.SemBox = new MetroFramework.Controls.MetroComboBox();
            this.SemesterLabel = new MetroFramework.Controls.MetroLabel();
            this.NameLbl = new MetroFramework.Controls.MetroLabel();
            this.AddressLbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.AddressTextBox = new MetroFramework.Controls.MetroTextBox();
            this.EmailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ID.Location = new System.Drawing.Point(13, 61);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(32, 25);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID:";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 84);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(0, 0);
            this.metroLabel2.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Password.Location = new System.Drawing.Point(12, 136);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(86, 25);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password:";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.BackColor = System.Drawing.Color.White;
            this.IdTextBox.Enabled = false;
            this.IdTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.IdTextBox.Location = new System.Drawing.Point(152, 61);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(285, 23);
            this.IdTextBox.TabIndex = 3;
            this.IdTextBox.Click += new System.EventHandler(this.IdTextBox_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.NameTextBox.Location = new System.Drawing.Point(152, 94);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(285, 23);
            this.NameTextBox.TabIndex = 4;
            this.NameTextBox.Click += new System.EventHandler(this.NameTextBox_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PasswordTextBox.Location = new System.Drawing.Point(152, 132);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.Size = new System.Drawing.Size(285, 23);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Click);
            // 
            // Names
            // 
            this.Names.AutoSize = true;
            this.Names.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Names.Location = new System.Drawing.Point(12, 98);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(62, 25);
            this.Names.TabIndex = 8;
            this.Names.Text = "Name:";
            // 
            // savebtn
            // 
            this.savebtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.savebtn.Location = new System.Drawing.Point(12, 304);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(210, 23);
            this.savebtn.Style = MetroFramework.MetroColorStyle.Green;
            this.savebtn.TabIndex = 9;
            this.savebtn.Text = "Save";
            this.savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.savebtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click_1);
            // 
            // SemBox
            // 
            this.SemBox.FormattingEnabled = true;
            this.SemBox.ItemHeight = 23;
            this.SemBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.SemBox.Location = new System.Drawing.Point(152, 257);
            this.SemBox.Name = "SemBox";
            this.SemBox.Size = new System.Drawing.Size(121, 29);
            this.SemBox.TabIndex = 10;
            this.SemBox.SelectedIndexChanged += new System.EventHandler(this.SemBox_SelectedIndexChanged);
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SemesterLabel.Location = new System.Drawing.Point(13, 261);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(86, 25);
            this.SemesterLabel.TabIndex = 11;
            this.SemesterLabel.Text = "Semester:";
            this.SemesterLabel.Click += new System.EventHandler(this.SemesterLabel_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.NameLbl.Location = new System.Drawing.Point(13, 97);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(62, 25);
            this.NameLbl.TabIndex = 12;
            this.NameLbl.Text = "Name:";
            this.NameLbl.Click += new System.EventHandler(this.NameLbl_Click);
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.AddressLbl.Location = new System.Drawing.Point(13, 173);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(76, 25);
            this.AddressLbl.TabIndex = 13;
            this.AddressLbl.Text = "Address:";
            this.AddressLbl.Click += new System.EventHandler(this.AddressLbl_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(13, 216);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 25);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Email:";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.AddressTextBox.Location = new System.Drawing.Point(152, 169);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(285, 23);
            this.AddressTextBox.TabIndex = 15;
            this.AddressTextBox.Click += new System.EventHandler(this.AddressTextBox_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.EmailTextBox.Location = new System.Drawing.Point(152, 218);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(285, 23);
            this.EmailTextBox.TabIndex = 16;
            this.EmailTextBox.Click += new System.EventHandler(this.EmailTextBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_12_A_B.Properties.Resources.profileofstudent;
            this.pictureBox1.Location = new System.Drawing.Point(461, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 294);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(228, 304);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(209, 23);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 18;
            this.metroTile1.Text = "Close";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // PersonalInfoStudent
            // 
            this.AcceptButton = this.savebtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.savebtn;
            this.ClientSize = new System.Drawing.Size(688, 350);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.SemesterLabel);
            this.Controls.Add(this.SemBox);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.ID);
            this.Name = "PersonalInfoStudent";
            this.Text = "Modify Personal Information";
            this.Load += new System.EventHandler(this.PersonalInfoStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel ID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel Password;
        private MetroFramework.Controls.MetroTextBox IdTextBox;
        private MetroFramework.Controls.MetroTextBox NameTextBox;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private MetroFramework.Controls.MetroLabel Names;
        private MetroFramework.Controls.MetroTile savebtn;
        private MetroFramework.Controls.MetroComboBox SemBox;
        private MetroFramework.Controls.MetroLabel SemesterLabel;
        private MetroFramework.Controls.MetroLabel NameLbl;
        private MetroFramework.Controls.MetroLabel AddressLbl;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox AddressTextBox;
        private MetroFramework.Controls.MetroTextBox EmailTextBox;
        private PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}