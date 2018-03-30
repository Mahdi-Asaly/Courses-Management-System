namespace Project_Sce.PL
{
    partial class FrmAddLesson
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
            this.label5 = new System.Windows.Forms.Label();
            this.category_cat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.class_cat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.course_cat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lecturer_cat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.day_cat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.strt_cat = new System.Windows.Forms.ComboBox();
            this.end_cat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddLesson = new System.Windows.Forms.Button();
            this.Return_Button = new System.Windows.Forms.Button();
            this.Logout_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(202, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Category :";
            // 
            // category_cat
            // 
            this.category_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_cat.FormattingEnabled = true;
            this.category_cat.Items.AddRange(new object[] {
            "Lecture",
            "Practition Lesson",
            "Lab"});
            this.category_cat.Location = new System.Drawing.Point(339, 172);
            this.category_cat.Name = "category_cat";
            this.category_cat.Size = new System.Drawing.Size(266, 24);
            this.category_cat.TabIndex = 7;
            this.category_cat.SelectedIndexChanged += new System.EventHandler(this.category_cat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(201, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Classroom: ";
            // 
            // class_cat
            // 
            this.class_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.class_cat.FormattingEnabled = true;
            this.class_cat.Location = new System.Drawing.Point(339, 475);
            this.class_cat.Name = "class_cat";
            this.class_cat.Size = new System.Drawing.Size(266, 24);
            this.class_cat.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(202, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Course ID:";
            // 
            // course_cat
            // 
            this.course_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.course_cat.FormattingEnabled = true;
            this.course_cat.Location = new System.Drawing.Point(339, 219);
            this.course_cat.Name = "course_cat";
            this.course_cat.Size = new System.Drawing.Size(266, 24);
            this.course_cat.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(201, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lecturer ID:";
            // 
            // lecturer_cat
            // 
            this.lecturer_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lecturer_cat.FormattingEnabled = true;
            this.lecturer_cat.Location = new System.Drawing.Point(335, 426);
            this.lecturer_cat.Name = "lecturer_cat";
            this.lecturer_cat.Size = new System.Drawing.Size(266, 24);
            this.lecturer_cat.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(202, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Day:";
            // 
            // day_cat
            // 
            this.day_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.day_cat.FormattingEnabled = true;
            this.day_cat.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday"});
            this.day_cat.Location = new System.Drawing.Point(336, 280);
            this.day_cat.Name = "day_cat";
            this.day_cat.Size = new System.Drawing.Size(266, 24);
            this.day_cat.TabIndex = 15;
            this.day_cat.SelectedIndexChanged += new System.EventHandler(this.day_cat_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(202, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Start time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(202, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "End time:";
            // 
            // strt_cat
            // 
            this.strt_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.strt_cat.FormattingEnabled = true;
            this.strt_cat.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.strt_cat.Location = new System.Drawing.Point(336, 336);
            this.strt_cat.Name = "strt_cat";
            this.strt_cat.Size = new System.Drawing.Size(73, 24);
            this.strt_cat.TabIndex = 18;
            this.strt_cat.SelectedIndexChanged += new System.EventHandler(this.strt_cat_SelectedIndexChanged);
            // 
            // end_cat
            // 
            this.end_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.end_cat.FormattingEnabled = true;
            this.end_cat.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.end_cat.Location = new System.Drawing.Point(336, 381);
            this.end_cat.Name = "end_cat";
            this.end_cat.Size = new System.Drawing.Size(73, 24);
            this.end_cat.TabIndex = 19;
            this.end_cat.SelectedIndexChanged += new System.EventHandler(this.end_cat_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(585, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 46);
            this.label8.TabIndex = 20;
            this.label8.Text = "Adding Lesson";
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLesson.ForeColor = System.Drawing.Color.Green;
            this.btnAddLesson.Location = new System.Drawing.Point(1105, 182);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(126, 49);
            this.btnAddLesson.TabIndex = 21;
            this.btnAddLesson.Text = "Add Lesson";
            this.btnAddLesson.UseVisualStyleBackColor = true;
            this.btnAddLesson.Click += new System.EventHandler(this.btnAddLesson_Click);
            // 
            // Return_Button
            // 
            this.Return_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_Button.Location = new System.Drawing.Point(1106, 300);
            this.Return_Button.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(125, 49);
            this.Return_Button.TabIndex = 22;
            this.Return_Button.Text = "Return";
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
            // 
            // Logout_Button
            // 
            this.Logout_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Logout_Button.Location = new System.Drawing.Point(1109, 415);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Size = new System.Drawing.Size(122, 49);
            this.Logout_Button.TabIndex = 23;
            this.Logout_Button.Text = "Logout";
            this.Logout_Button.UseVisualStyleBackColor = true;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click);
            // 
            // FrmAddLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.Logout_Button);
            this.Controls.Add(this.Return_Button);
            this.Controls.Add(this.btnAddLesson);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.end_cat);
            this.Controls.Add(this.strt_cat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.day_cat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lecturer_cat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.course_cat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.class_cat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.category_cat);
            this.Controls.Add(this.label5);
            this.Name = "FrmAddLesson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddLesson";
            this.Load += new System.EventHandler(this.FrmAddLesson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox category_cat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox class_cat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox course_cat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lecturer_cat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox day_cat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox strt_cat;
        private System.Windows.Forms.ComboBox end_cat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddLesson;
        private System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.Button Logout_Button;
    }
}