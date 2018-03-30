namespace Project_Sce.PL
{
    partial class AssignStudent_To_Course
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Id : ");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Name : ");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Academic Year : ");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Average : ");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Address : ");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Email : ");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Semester : ");
            this.Return_Button = new System.Windows.Forms.Button();
            this.Id_TextBox = new System.Windows.Forms.TextBox();
            this.StudID_Assign = new System.Windows.Forms.Label();
            this.OK_Button = new System.Windows.Forms.Button();
            this.RegisterBUTTON = new System.Windows.Forms.Button();
            this.Student_LV = new System.Windows.Forms.ListView();
            this.Course_LV = new System.Windows.Forms.ListView();
            this.CourseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoursPerWeek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Points = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lab = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Practition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Semester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegisterOption = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Return_Button
            // 
            this.Return_Button.Location = new System.Drawing.Point(12, 389);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(75, 23);
            this.Return_Button.TabIndex = 18;
            this.Return_Button.Text = "Return";
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
            // 
            // Id_TextBox
            // 
            this.Id_TextBox.Location = new System.Drawing.Point(158, 50);
            this.Id_TextBox.Name = "Id_TextBox";
            this.Id_TextBox.Size = new System.Drawing.Size(139, 20);
            this.Id_TextBox.TabIndex = 19;
            this.Id_TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StudID_Assign
            // 
            this.StudID_Assign.AutoSize = true;
            this.StudID_Assign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.StudID_Assign.Location = new System.Drawing.Point(43, 50);
            this.StudID_Assign.Name = "StudID_Assign";
            this.StudID_Assign.Size = new System.Drawing.Size(109, 18);
            this.StudID_Assign.TabIndex = 21;
            this.StudID_Assign.Text = "Student\'s ID :";
            this.StudID_Assign.Click += new System.EventHandler(this.label1_Click);
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(315, 49);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(45, 21);
            this.OK_Button.TabIndex = 22;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterBUTTON
            // 
            this.RegisterBUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RegisterBUTTON.Location = new System.Drawing.Point(668, 366);
            this.RegisterBUTTON.Name = "RegisterBUTTON";
            this.RegisterBUTTON.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RegisterBUTTON.Size = new System.Drawing.Size(113, 46);
            this.RegisterBUTTON.TabIndex = 23;
            this.RegisterBUTTON.Text = "Register";
            this.RegisterBUTTON.UseVisualStyleBackColor = true;
            this.RegisterBUTTON.Click += new System.EventHandler(this.RegisterBUTTON_Click);
            // 
            // Student_LV
            // 
            this.Student_LV.Cursor = System.Windows.Forms.Cursors.Default;
            this.Student_LV.GridLines = true;
            this.Student_LV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.Student_LV.Location = new System.Drawing.Point(499, 12);
            this.Student_LV.MultiSelect = false;
            this.Student_LV.Name = "Student_LV";
            this.Student_LV.Size = new System.Drawing.Size(282, 124);
            this.Student_LV.TabIndex = 24;
            this.Student_LV.UseCompatibleStateImageBehavior = false;
            this.Student_LV.View = System.Windows.Forms.View.List;
            this.Student_LV.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Course_LV
            // 
            this.Course_LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CourseID,
            this.CourseName,
            this.HoursPerWeek,
            this.Points,
            this.Category,
            this.Lab,
            this.Practition,
            this.Semester,
            this.RegisterOption,
            this.Year});
            this.Course_LV.FullRowSelect = true;
            this.Course_LV.GridLines = true;
            this.Course_LV.Location = new System.Drawing.Point(12, 146);
            this.Course_LV.MultiSelect = false;
            this.Course_LV.Name = "Course_LV";
            this.Course_LV.Size = new System.Drawing.Size(769, 209);
            this.Course_LV.TabIndex = 25;
            this.Course_LV.UseCompatibleStateImageBehavior = false;
            this.Course_LV.View = System.Windows.Forms.View.Details;
            this.Course_LV.SelectedIndexChanged += new System.EventHandler(this.Course_LV_SelectedIndexChanged);
            // 
            // CourseID
            // 
            this.CourseID.Text = "Course ID";
            this.CourseID.Width = 90;
            // 
            // CourseName
            // 
            this.CourseName.Text = "Course Name";
            this.CourseName.Width = 97;
            // 
            // HoursPerWeek
            // 
            this.HoursPerWeek.Text = "Hours P.Week";
            this.HoursPerWeek.Width = 89;
            // 
            // Points
            // 
            this.Points.Text = "Points";
            this.Points.Width = 76;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 97;
            // 
            // Lab
            // 
            this.Lab.Text = "Lab";
            this.Lab.Width = 40;
            // 
            // Practition
            // 
            this.Practition.Text = "Practition";
            // 
            // Semester
            // 
            this.Semester.Text = "Semester";
            this.Semester.Width = 57;
            // 
            // RegisterOption
            // 
            this.RegisterOption.Text = "RegisterOption";
            this.RegisterOption.Width = 91;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            // 
            // AssignStudent_To_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(793, 424);
            this.Controls.Add(this.Course_LV);
            this.Controls.Add(this.Student_LV);
            this.Controls.Add(this.RegisterBUTTON);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.StudID_Assign);
            this.Controls.Add(this.Id_TextBox);
            this.Controls.Add(this.Return_Button);
            this.Name = "AssignStudent_To_Course";
            this.Text = "AssignStudent_To_Course";
            this.Load += new System.EventHandler(this.AssignStudent_To_Course_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.TextBox Id_TextBox;
        private System.Windows.Forms.Label StudID_Assign;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Button RegisterBUTTON;
        private System.Windows.Forms.ListView Student_LV;
        private System.Windows.Forms.ListView Course_LV;
        private System.Windows.Forms.ColumnHeader CourseID;
        private System.Windows.Forms.ColumnHeader CourseName;
        private System.Windows.Forms.ColumnHeader HoursPerWeek;
        private System.Windows.Forms.ColumnHeader Points;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Lab;
        private System.Windows.Forms.ColumnHeader Practition;
        private System.Windows.Forms.ColumnHeader Semester;
        private System.Windows.Forms.ColumnHeader RegisterOption;
        private System.Windows.Forms.ColumnHeader Year;
    }
}