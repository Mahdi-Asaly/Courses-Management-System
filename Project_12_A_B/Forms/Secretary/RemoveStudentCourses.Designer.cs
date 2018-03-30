namespace Project_12_A_B
{
    partial class RemoveStudentCourses
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
            this.AvailableSlotsLBl = new MetroFramework.Controls.MetroLabel();
            this.RemoveBtn = new MetroFramework.Controls.MetroTile();
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
            this.SuspendLayout();
            // 
            // AvailableSlotsText
            // 
            this.AvailableSlotsText.Location = new System.Drawing.Point(405, 170);
            this.AvailableSlotsText.Name = "AvailableSlotsText";
            this.AvailableSlotsText.ReadOnly = true;
            this.AvailableSlotsText.Size = new System.Drawing.Size(75, 23);
            this.AvailableSlotsText.TabIndex = 35;
            // 
            // AvailableSlotsLBl
            // 
            this.AvailableSlotsLBl.AutoSize = true;
            this.AvailableSlotsLBl.Location = new System.Drawing.Point(303, 174);
            this.AvailableSlotsLBl.Name = "AvailableSlotsLBl";
            this.AvailableSlotsLBl.Size = new System.Drawing.Size(96, 19);
            this.AvailableSlotsLBl.TabIndex = 34;
            this.AvailableSlotsLBl.Text = "Available Slots:";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(23, 205);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(239, 23);
            this.RemoveBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.RemoveBtn.TabIndex = 33;
            this.RemoveBtn.Text = "Remove Course";
            this.RemoveBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RemoveBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Location = new System.Drawing.Point(268, 205);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(212, 23);
            this.BtnClose.Style = MetroFramework.MetroColorStyle.Yellow;
            this.BtnClose.TabIndex = 32;
            this.BtnClose.Text = "Close";
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnClose.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // CoursePractitionText
            // 
            this.CoursePractitionText.Location = new System.Drawing.Point(405, 137);
            this.CoursePractitionText.Name = "CoursePractitionText";
            this.CoursePractitionText.ReadOnly = true;
            this.CoursePractitionText.Size = new System.Drawing.Size(75, 23);
            this.CoursePractitionText.TabIndex = 31;
            // 
            // CourseLabText
            // 
            this.CourseLabText.Location = new System.Drawing.Point(405, 108);
            this.CourseLabText.Name = "CourseLabText";
            this.CourseLabText.ReadOnly = true;
            this.CourseLabText.Size = new System.Drawing.Size(75, 23);
            this.CourseLabText.TabIndex = 30;
            // 
            // CourseCatagoryText
            // 
            this.CourseCatagoryText.Location = new System.Drawing.Point(405, 77);
            this.CourseCatagoryText.Name = "CourseCatagoryText";
            this.CourseCatagoryText.ReadOnly = true;
            this.CourseCatagoryText.Size = new System.Drawing.Size(75, 23);
            this.CourseCatagoryText.TabIndex = 29;
            // 
            // CoursePointsText
            // 
            this.CoursePointsText.Location = new System.Drawing.Point(139, 168);
            this.CoursePointsText.Name = "CoursePointsText";
            this.CoursePointsText.ReadOnly = true;
            this.CoursePointsText.Size = new System.Drawing.Size(123, 23);
            this.CoursePointsText.TabIndex = 28;
            // 
            // CourseHoursText
            // 
            this.CourseHoursText.Location = new System.Drawing.Point(139, 138);
            this.CourseHoursText.Name = "CourseHoursText";
            this.CourseHoursText.ReadOnly = true;
            this.CourseHoursText.Size = new System.Drawing.Size(123, 23);
            this.CourseHoursText.TabIndex = 27;
            // 
            // CourseIdText
            // 
            this.CourseIdText.Location = new System.Drawing.Point(139, 109);
            this.CourseIdText.Name = "CourseIdText";
            this.CourseIdText.ReadOnly = true;
            this.CourseIdText.Size = new System.Drawing.Size(123, 23);
            this.CourseIdText.TabIndex = 26;
            // 
            // CourseNameText
            // 
            this.CourseNameText.Location = new System.Drawing.Point(139, 78);
            this.CourseNameText.Name = "CourseNameText";
            this.CourseNameText.ReadOnly = true;
            this.CourseNameText.Size = new System.Drawing.Size(123, 23);
            this.CourseNameText.TabIndex = 25;
            // 
            // pract
            // 
            this.pract.AutoSize = true;
            this.pract.Location = new System.Drawing.Point(304, 142);
            this.pract.Name = "pract";
            this.pract.Size = new System.Drawing.Size(67, 19);
            this.pract.TabIndex = 24;
            this.pract.Text = "Practition:";
            // 
            // Lab
            // 
            this.Lab.AutoSize = true;
            this.Lab.Location = new System.Drawing.Point(304, 113);
            this.Lab.Name = "Lab";
            this.Lab.Size = new System.Drawing.Size(33, 19);
            this.Lab.TabIndex = 23;
            this.Lab.Text = "Lab:";
            // 
            // Catagory
            // 
            this.Catagory.AutoSize = true;
            this.Catagory.Location = new System.Drawing.Point(304, 78);
            this.Catagory.Name = "Catagory";
            this.Catagory.Size = new System.Drawing.Size(67, 19);
            this.Catagory.TabIndex = 22;
            this.Catagory.Text = "Catagory:";
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Location = new System.Drawing.Point(21, 167);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(46, 19);
            this.points.TabIndex = 21;
            this.points.Text = "Points:";
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Location = new System.Drawing.Point(21, 137);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(105, 19);
            this.Hours.TabIndex = 20;
            this.Hours.Text = "Hours Per Week:";
            // 
            // CourseID
            // 
            this.CourseID.AutoSize = true;
            this.CourseID.Location = new System.Drawing.Point(23, 107);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(69, 19);
            this.CourseID.TabIndex = 19;
            this.CourseID.Text = "Course ID:";
            // 
            // CourseName
            // 
            this.CourseName.AutoSize = true;
            this.CourseName.Location = new System.Drawing.Point(23, 77);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(93, 19);
            this.CourseName.TabIndex = 18;
            this.CourseName.Text = "Course Name:";
            // 
            // RemoveStudentCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 260);
            this.Controls.Add(this.AvailableSlotsText);
            this.Controls.Add(this.AvailableSlotsLBl);
            this.Controls.Add(this.RemoveBtn);
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
            this.Name = "RemoveStudentCourses";
            this.Load += new System.EventHandler(this.RemoveStudentCourses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox AvailableSlotsText;
        private MetroFramework.Controls.MetroLabel AvailableSlotsLBl;
        private MetroFramework.Controls.MetroTile RemoveBtn;
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
    }
}