namespace Project_Sce.PL
{
    partial class FrmAddCourses
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CourseName = new System.Windows.Forms.TextBox();
            this.Points = new System.Windows.Forms.TextBox();
            this.HoursPerWk = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.ComboBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.pract = new System.Windows.Forms.CheckBox();
            this.lab = new System.Windows.Forms.CheckBox();
            this.semester = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxCourseId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(20, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Points :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(20, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hours Per Week :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(20, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Category :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(20, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Practition Lesson :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(20, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "LAB :";
            // 
            // CourseName
            // 
            this.CourseName.Location = new System.Drawing.Point(245, 18);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(100, 26);
            this.CourseName.TabIndex = 8;
            // 
            // Points
            // 
            this.Points.Location = new System.Drawing.Point(245, 97);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(100, 26);
            this.Points.TabIndex = 10;
            // 
            // HoursPerWk
            // 
            this.HoursPerWk.Location = new System.Drawing.Point(245, 139);
            this.HoursPerWk.Name = "HoursPerWk";
            this.HoursPerWk.Size = new System.Drawing.Size(100, 26);
            this.HoursPerWk.TabIndex = 11;
            // 
            // Category
            // 
            this.Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "Required",
            "Optional",
            "General"});
            this.Category.Location = new System.Drawing.Point(245, 178);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(121, 27);
            this.Category.TabIndex = 14;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.ForeColor = System.Drawing.Color.Green;
            this.btnAddCourse.Location = new System.Drawing.Point(24, 338);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(178, 49);
            this.btnAddCourse.TabIndex = 18;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // pract
            // 
            this.pract.AutoSize = true;
            this.pract.Location = new System.Drawing.Point(273, 292);
            this.pract.Name = "pract";
            this.pract.Size = new System.Drawing.Size(18, 17);
            this.pract.TabIndex = 19;
            this.pract.UseVisualStyleBackColor = true;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(273, 259);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(18, 17);
            this.lab.TabIndex = 20;
            this.lab.UseVisualStyleBackColor = true;
            // 
            // semester
            // 
            this.semester.AutoSize = true;
            this.semester.ForeColor = System.Drawing.SystemColors.Highlight;
            this.semester.Location = new System.Drawing.Point(20, 223);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(129, 19);
            this.semester.TabIndex = 21;
            this.semester.Text = "Semester: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 22;
            // 
            // textBoxCourseId
            // 
            this.textBoxCourseId.Location = new System.Drawing.Point(245, 56);
            this.textBoxCourseId.Name = "textBoxCourseId";
            this.textBoxCourseId.Size = new System.Drawing.Size(100, 26);
            this.textBoxCourseId.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Course ID :";
            // 
            // FrmAddCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 424);
            this.Controls.Add(this.textBoxCourseId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.semester);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.pract);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.HoursPerWk);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.CourseName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Miriam Fixed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "FrmAddCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CourseName;
        private System.Windows.Forms.TextBox Points;
        private System.Windows.Forms.TextBox HoursPerWk;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.CheckBox pract;
        private System.Windows.Forms.CheckBox lab;
        private System.Windows.Forms.Label semester;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxCourseId;
        private System.Windows.Forms.Label label2;
    }
}