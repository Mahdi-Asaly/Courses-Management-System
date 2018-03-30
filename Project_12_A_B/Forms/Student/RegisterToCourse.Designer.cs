namespace Project_12_A_B.Forms.Student
{
    partial class RegisterToCourse
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
            this.BtnClose = new MetroFramework.Controls.MetroTile();
            this.CoursePractitionText = new MetroFramework.Controls.MetroTextBox();
            this.CourseLabText = new MetroFramework.Controls.MetroTextBox();
            this.CourseCatagoryText = new MetroFramework.Controls.MetroTextBox();
            this.CoursePointsText = new MetroFramework.Controls.MetroTextBox();
            this.CourseHoursText = new MetroFramework.Controls.MetroTextBox();
            this.CourseIdText = new MetroFramework.Controls.MetroTextBox();
            this.CourseNameText = new MetroFramework.Controls.MetroTextBox();
            this.pract = new MetroFramework.Controls.MetroLabel();
            this.Lab = new MetroFramework.Controls.MetroLabel();
            this.Catagory = new MetroFramework.Controls.MetroLabel();
            this.points = new MetroFramework.Controls.MetroLabel();
            this.Hours = new MetroFramework.Controls.MetroLabel();
            this.CourseID = new MetroFramework.Controls.MetroLabel();
            this.CourseName = new MetroFramework.Controls.MetroLabel();
            this.RegisterBtn = new MetroFramework.Controls.MetroTile();
            this.AvailableSlotslbl = new MetroFramework.Controls.MetroLabel();
            this.AvailableSlotsText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DaySECombo = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Location = new System.Drawing.Point(23, 253);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(208, 32);
            this.BtnClose.Style = MetroFramework.MetroColorStyle.Red;
            this.BtnClose.TabIndex = 29;
            this.BtnClose.Text = "Cancel";
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnClose.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // CoursePractitionText
            // 
            this.CoursePractitionText.Location = new System.Drawing.Point(368, 132);
            this.CoursePractitionText.Name = "CoursePractitionText";
            this.CoursePractitionText.ReadOnly = true;
            this.CoursePractitionText.Size = new System.Drawing.Size(75, 23);
            this.CoursePractitionText.TabIndex = 28;
            // 
            // CourseLabText
            // 
            this.CourseLabText.Location = new System.Drawing.Point(368, 103);
            this.CourseLabText.Name = "CourseLabText";
            this.CourseLabText.ReadOnly = true;
            this.CourseLabText.Size = new System.Drawing.Size(75, 23);
            this.CourseLabText.TabIndex = 27;
            // 
            // CourseCatagoryText
            // 
            this.CourseCatagoryText.Location = new System.Drawing.Point(368, 72);
            this.CourseCatagoryText.Name = "CourseCatagoryText";
            this.CourseCatagoryText.ReadOnly = true;
            this.CourseCatagoryText.Size = new System.Drawing.Size(75, 23);
            this.CourseCatagoryText.TabIndex = 26;
            // 
            // CoursePointsText
            // 
            this.CoursePointsText.Location = new System.Drawing.Point(139, 163);
            this.CoursePointsText.Name = "CoursePointsText";
            this.CoursePointsText.ReadOnly = true;
            this.CoursePointsText.Size = new System.Drawing.Size(103, 23);
            this.CoursePointsText.TabIndex = 25;
            // 
            // CourseHoursText
            // 
            this.CourseHoursText.Location = new System.Drawing.Point(139, 133);
            this.CourseHoursText.Name = "CourseHoursText";
            this.CourseHoursText.ReadOnly = true;
            this.CourseHoursText.Size = new System.Drawing.Size(103, 23);
            this.CourseHoursText.TabIndex = 24;
            // 
            // CourseIdText
            // 
            this.CourseIdText.Location = new System.Drawing.Point(139, 104);
            this.CourseIdText.Name = "CourseIdText";
            this.CourseIdText.ReadOnly = true;
            this.CourseIdText.Size = new System.Drawing.Size(103, 23);
            this.CourseIdText.TabIndex = 23;
            // 
            // CourseNameText
            // 
            this.CourseNameText.Location = new System.Drawing.Point(139, 73);
            this.CourseNameText.Name = "CourseNameText";
            this.CourseNameText.ReadOnly = true;
            this.CourseNameText.Size = new System.Drawing.Size(103, 23);
            this.CourseNameText.TabIndex = 22;
            // 
            // pract
            // 
            this.pract.AutoSize = true;
            this.pract.Location = new System.Drawing.Point(267, 137);
            this.pract.Name = "pract";
            this.pract.Size = new System.Drawing.Size(67, 19);
            this.pract.TabIndex = 21;
            this.pract.Text = "Practition:";
            // 
            // Lab
            // 
            this.Lab.AutoSize = true;
            this.Lab.Location = new System.Drawing.Point(267, 108);
            this.Lab.Name = "Lab";
            this.Lab.Size = new System.Drawing.Size(33, 19);
            this.Lab.TabIndex = 20;
            this.Lab.Text = "Lab:";
            // 
            // Catagory
            // 
            this.Catagory.AutoSize = true;
            this.Catagory.Location = new System.Drawing.Point(267, 73);
            this.Catagory.Name = "Catagory";
            this.Catagory.Size = new System.Drawing.Size(67, 19);
            this.Catagory.TabIndex = 19;
            this.Catagory.Text = "Catagory:";
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Location = new System.Drawing.Point(21, 162);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(46, 19);
            this.points.TabIndex = 18;
            this.points.Text = "Points:";
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Location = new System.Drawing.Point(21, 132);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(105, 19);
            this.Hours.TabIndex = 17;
            this.Hours.Text = "Hours Per Week:";
            // 
            // CourseID
            // 
            this.CourseID.AutoSize = true;
            this.CourseID.Location = new System.Drawing.Point(23, 102);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(69, 19);
            this.CourseID.TabIndex = 16;
            this.CourseID.Text = "Course ID:";
            // 
            // CourseName
            // 
            this.CourseName.AutoSize = true;
            this.CourseName.Location = new System.Drawing.Point(23, 72);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(93, 19);
            this.CourseName.TabIndex = 15;
            this.CourseName.Text = "Course Name:";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(237, 252);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(206, 33);
            this.RegisterBtn.Style = MetroFramework.MetroColorStyle.Green;
            this.RegisterBtn.TabIndex = 30;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegisterBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // AvailableSlotslbl
            // 
            this.AvailableSlotslbl.AutoSize = true;
            this.AvailableSlotslbl.Location = new System.Drawing.Point(266, 167);
            this.AvailableSlotslbl.Name = "AvailableSlotslbl";
            this.AvailableSlotslbl.Size = new System.Drawing.Size(96, 19);
            this.AvailableSlotslbl.TabIndex = 31;
            this.AvailableSlotslbl.Text = "Available Slots:";
            // 
            // AvailableSlotsText
            // 
            this.AvailableSlotsText.Location = new System.Drawing.Point(368, 163);
            this.AvailableSlotsText.Name = "AvailableSlotsText";
            this.AvailableSlotsText.ReadOnly = true;
            this.AvailableSlotsText.Size = new System.Drawing.Size(75, 23);
            this.AvailableSlotsText.TabIndex = 32;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(98, 202);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 25);
            this.metroLabel1.TabIndex = 33;
            this.metroLabel1.Text = "Lecturer";
            // 
            // DaySECombo
            // 
            this.DaySECombo.FormattingEnabled = true;
            this.DaySECombo.ItemHeight = 23;
            this.DaySECombo.Location = new System.Drawing.Point(177, 202);
            this.DaySECombo.Name = "DaySECombo";
            this.DaySECombo.Size = new System.Drawing.Size(206, 29);
            this.DaySECombo.TabIndex = 34;
            // 
            // RegisterToCourse
            // 
            this.AcceptButton = this.RegisterBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(477, 305);
            this.Controls.Add(this.DaySECombo);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.AvailableSlotsText);
            this.Controls.Add(this.AvailableSlotslbl);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.CoursePractitionText);
            this.Controls.Add(this.CourseLabText);
            this.Controls.Add(this.CourseCatagoryText);
            this.Controls.Add(this.CoursePointsText);
            this.Controls.Add(this.CourseHoursText);
            this.Controls.Add(this.CourseIdText);
            this.Controls.Add(this.CourseNameText);
            this.Controls.Add(this.pract);
            this.Controls.Add(this.Lab);
            this.Controls.Add(this.Catagory);
            this.Controls.Add(this.points);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.CourseID);
            this.Controls.Add(this.CourseName);
            this.Name = "RegisterToCourse";
            this.Text = "Course Registeration:";
            this.Load += new System.EventHandler(this.RegisterToCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile BtnClose;
        private MetroFramework.Controls.MetroTextBox CoursePractitionText;
        private MetroFramework.Controls.MetroTextBox CourseLabText;
        private MetroFramework.Controls.MetroTextBox CourseCatagoryText;
        private MetroFramework.Controls.MetroTextBox CoursePointsText;
        private MetroFramework.Controls.MetroTextBox CourseHoursText;
        private MetroFramework.Controls.MetroTextBox CourseIdText;
        private MetroFramework.Controls.MetroTextBox CourseNameText;
        private MetroFramework.Controls.MetroLabel pract;
        private MetroFramework.Controls.MetroLabel Lab;
        private MetroFramework.Controls.MetroLabel Catagory;
        private MetroFramework.Controls.MetroLabel points;
        private MetroFramework.Controls.MetroLabel Hours;
        private MetroFramework.Controls.MetroLabel CourseID;
        private MetroFramework.Controls.MetroLabel CourseName;
        private MetroFramework.Controls.MetroTile RegisterBtn;
        private MetroFramework.Controls.MetroLabel AvailableSlotslbl;
        private MetroFramework.Controls.MetroTextBox AvailableSlotsText;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox DaySECombo;
    }
}