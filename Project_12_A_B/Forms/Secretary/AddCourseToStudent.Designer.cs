namespace Project_12_A_B
{
    partial class AddCourseToStudent
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
            this.AvailableSlotsText = new MetroFramework.Controls.MetroTextBox();
            this.AvailableSlotslbl = new MetroFramework.Controls.MetroLabel();
            this.RegisterBtn = new MetroFramework.Controls.MetroTile();
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
            this.DaySECombo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // AvailableSlotsText
            // 
            this.AvailableSlotsText.Location = new System.Drawing.Point(359, 154);
            this.AvailableSlotsText.Name = "AvailableSlotsText";
            this.AvailableSlotsText.ReadOnly = true;
            this.AvailableSlotsText.Size = new System.Drawing.Size(75, 23);
            this.AvailableSlotsText.TabIndex = 52;
            // 
            // AvailableSlotslbl
            // 
            this.AvailableSlotslbl.AutoSize = true;
            this.AvailableSlotslbl.Location = new System.Drawing.Point(257, 158);
            this.AvailableSlotslbl.Name = "AvailableSlotslbl";
            this.AvailableSlotslbl.Size = new System.Drawing.Size(96, 19);
            this.AvailableSlotslbl.TabIndex = 51;
            this.AvailableSlotslbl.Text = "Available Slots:";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(238, 241);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(208, 33);
            this.RegisterBtn.Style = MetroFramework.MetroColorStyle.Green;
            this.RegisterBtn.TabIndex = 50;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegisterBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Location = new System.Drawing.Point(12, 241);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(220, 32);
            this.BtnClose.Style = MetroFramework.MetroColorStyle.Red;
            this.BtnClose.TabIndex = 49;
            this.BtnClose.Text = "Cancel";
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnClose.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // CoursePractitionText
            // 
            this.CoursePractitionText.Location = new System.Drawing.Point(359, 123);
            this.CoursePractitionText.Name = "CoursePractitionText";
            this.CoursePractitionText.ReadOnly = true;
            this.CoursePractitionText.Size = new System.Drawing.Size(75, 23);
            this.CoursePractitionText.TabIndex = 48;
            // 
            // CourseLabText
            // 
            this.CourseLabText.Location = new System.Drawing.Point(359, 94);
            this.CourseLabText.Name = "CourseLabText";
            this.CourseLabText.ReadOnly = true;
            this.CourseLabText.Size = new System.Drawing.Size(75, 23);
            this.CourseLabText.TabIndex = 47;
            // 
            // CourseCatagoryText
            // 
            this.CourseCatagoryText.Location = new System.Drawing.Point(359, 63);
            this.CourseCatagoryText.Name = "CourseCatagoryText";
            this.CourseCatagoryText.ReadOnly = true;
            this.CourseCatagoryText.Size = new System.Drawing.Size(75, 23);
            this.CourseCatagoryText.TabIndex = 46;
            // 
            // CoursePointsText
            // 
            this.CoursePointsText.Location = new System.Drawing.Point(130, 154);
            this.CoursePointsText.Name = "CoursePointsText";
            this.CoursePointsText.ReadOnly = true;
            this.CoursePointsText.Size = new System.Drawing.Size(122, 23);
            this.CoursePointsText.TabIndex = 45;
            // 
            // CourseHoursText
            // 
            this.CourseHoursText.Location = new System.Drawing.Point(130, 124);
            this.CourseHoursText.Name = "CourseHoursText";
            this.CourseHoursText.ReadOnly = true;
            this.CourseHoursText.Size = new System.Drawing.Size(122, 23);
            this.CourseHoursText.TabIndex = 44;
            // 
            // CourseIdText
            // 
            this.CourseIdText.Location = new System.Drawing.Point(130, 95);
            this.CourseIdText.Name = "CourseIdText";
            this.CourseIdText.ReadOnly = true;
            this.CourseIdText.Size = new System.Drawing.Size(122, 23);
            this.CourseIdText.TabIndex = 43;
            // 
            // CourseNameText
            // 
            this.CourseNameText.Location = new System.Drawing.Point(130, 64);
            this.CourseNameText.Name = "CourseNameText";
            this.CourseNameText.ReadOnly = true;
            this.CourseNameText.Size = new System.Drawing.Size(122, 23);
            this.CourseNameText.TabIndex = 42;
            // 
            // pract
            // 
            this.pract.AutoSize = true;
            this.pract.Location = new System.Drawing.Point(258, 128);
            this.pract.Name = "pract";
            this.pract.Size = new System.Drawing.Size(67, 19);
            this.pract.TabIndex = 41;
            this.pract.Text = "Practition:";
            // 
            // Lab
            // 
            this.Lab.AutoSize = true;
            this.Lab.Location = new System.Drawing.Point(258, 99);
            this.Lab.Name = "Lab";
            this.Lab.Size = new System.Drawing.Size(33, 19);
            this.Lab.TabIndex = 40;
            this.Lab.Text = "Lab:";
            // 
            // Catagory
            // 
            this.Catagory.AutoSize = true;
            this.Catagory.Location = new System.Drawing.Point(258, 64);
            this.Catagory.Name = "Catagory";
            this.Catagory.Size = new System.Drawing.Size(67, 19);
            this.Catagory.TabIndex = 39;
            this.Catagory.Text = "Category:";
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Location = new System.Drawing.Point(12, 153);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(46, 19);
            this.points.TabIndex = 38;
            this.points.Text = "Points:";
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Location = new System.Drawing.Point(12, 123);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(105, 19);
            this.Hours.TabIndex = 37;
            this.Hours.Text = "Hours Per Week:";
            // 
            // CourseID
            // 
            this.CourseID.AutoSize = true;
            this.CourseID.Location = new System.Drawing.Point(14, 93);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(69, 19);
            this.CourseID.TabIndex = 36;
            this.CourseID.Text = "Course ID:";
            // 
            // CourseName
            // 
            this.CourseName.AutoSize = true;
            this.CourseName.Location = new System.Drawing.Point(14, 63);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(93, 19);
            this.CourseName.TabIndex = 35;
            this.CourseName.Text = "Course Name:";
            // 
            // DaySECombo
            // 
            this.DaySECombo.FormattingEnabled = true;
            this.DaySECombo.ItemHeight = 23;
            this.DaySECombo.Location = new System.Drawing.Point(158, 196);
            this.DaySECombo.Name = "DaySECombo";
            this.DaySECombo.Size = new System.Drawing.Size(206, 29);
            this.DaySECombo.TabIndex = 56;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(79, 196);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 25);
            this.metroLabel2.TabIndex = 55;
            this.metroLabel2.Text = "Lecturer";
            // 
            // AddCourseToStudent
            // 
            this.AcceptButton = this.RegisterBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(452, 296);
            this.Controls.Add(this.DaySECombo);
            this.Controls.Add(this.metroLabel2);
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
            this.Name = "AddCourseToStudent";
            this.Text = "Course Details";
            this.Load += new System.EventHandler(this.AddCourseToStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox AvailableSlotsText;
        private MetroFramework.Controls.MetroLabel AvailableSlotslbl;
        private MetroFramework.Controls.MetroTile RegisterBtn;
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
        private MetroFramework.Controls.MetroComboBox DaySECombo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}