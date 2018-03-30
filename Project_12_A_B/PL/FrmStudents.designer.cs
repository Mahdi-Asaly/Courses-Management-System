namespace Project_Sce.PL
{
    partial class FrmStudents
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
            this.AddStudBtn = new System.Windows.Forms.Button();
            this.DeleteStudBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.EditStudentB = new System.Windows.Forms.Button();
            this.AssignStudentToCourse = new System.Windows.Forms.Button();
            this.Actions = new System.Windows.Forms.GroupBox();
            this.Students = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Open = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Student = new System.Windows.Forms.Label();
            this.StudentID_txt = new System.Windows.Forms.TextBox();
            this.Actions.SuspendLayout();
            this.Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddStudBtn
            // 
            this.AddStudBtn.Location = new System.Drawing.Point(648, 35);
            this.AddStudBtn.Name = "AddStudBtn";
            this.AddStudBtn.Size = new System.Drawing.Size(118, 40);
            this.AddStudBtn.TabIndex = 0;
            this.AddStudBtn.Text = "Add Student";
            this.AddStudBtn.UseVisualStyleBackColor = true;
            this.AddStudBtn.Click += new System.EventHandler(this.AddStudBtn_Click);
            // 
            // DeleteStudBtn
            // 
            this.DeleteStudBtn.Location = new System.Drawing.Point(6, 35);
            this.DeleteStudBtn.Name = "DeleteStudBtn";
            this.DeleteStudBtn.Size = new System.Drawing.Size(118, 40);
            this.DeleteStudBtn.TabIndex = 1;
            this.DeleteStudBtn.Text = "Delete Student";
            this.DeleteStudBtn.UseVisualStyleBackColor = true;
            this.DeleteStudBtn.Click += new System.EventHandler(this.DeleteStudBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(703, 11);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(85, 26);
            this.ReturnBtn.TabIndex = 2;
            this.ReturnBtn.Text = "Back";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // EditStudentB
            // 
            this.EditStudentB.Location = new System.Drawing.Point(456, 35);
            this.EditStudentB.Name = "EditStudentB";
            this.EditStudentB.Size = new System.Drawing.Size(118, 40);
            this.EditStudentB.TabIndex = 3;
            this.EditStudentB.Text = "Edit Student";
            this.EditStudentB.UseVisualStyleBackColor = true;
            this.EditStudentB.Click += new System.EventHandler(this.button1_Click);
            // 
            // AssignStudentToCourse
            // 
            this.AssignStudentToCourse.Location = new System.Drawing.Point(212, 35);
            this.AssignStudentToCourse.Name = "AssignStudentToCourse";
            this.AssignStudentToCourse.Size = new System.Drawing.Size(181, 40);
            this.AssignStudentToCourse.TabIndex = 4;
            this.AssignStudentToCourse.Text = "Assign Student to Course";
            this.AssignStudentToCourse.UseVisualStyleBackColor = true;
            this.AssignStudentToCourse.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Actions
            // 
            this.Actions.Controls.Add(this.DeleteStudBtn);
            this.Actions.Controls.Add(this.EditStudentB);
            this.Actions.Controls.Add(this.AddStudBtn);
            this.Actions.Controls.Add(this.AssignStudentToCourse);
            this.Actions.Location = new System.Drawing.Point(3, 278);
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(785, 102);
            this.Actions.TabIndex = 6;
            this.Actions.TabStop = false;
            this.Actions.Text = "Actions";
            // 
            // Students
            // 
            this.Students.Controls.Add(this.dataGridView1);
            this.Students.Location = new System.Drawing.Point(12, 45);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(776, 227);
            this.Students.TabIndex = 7;
            this.Students.TabStop = false;
            this.Students.Text = "Students";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(764, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(552, 14);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 8;
            this.Open.Text = "Show";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(15, 18);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(41, 13);
            this.Search.TabIndex = 9;
            this.Search.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Location = new System.Drawing.Point(332, 17);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(64, 13);
            this.Student.TabIndex = 10;
            this.Student.Text = "Student ID :";
            // 
            // StudentID_txt
            // 
            this.StudentID_txt.Location = new System.Drawing.Point(423, 14);
            this.StudentID_txt.Name = "StudentID_txt";
            this.StudentID_txt.Size = new System.Drawing.Size(100, 20);
            this.StudentID_txt.TabIndex = 11;
            this.StudentID_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FrmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 383);
            this.Controls.Add(this.StudentID_txt);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.Actions);
            this.Controls.Add(this.ReturnBtn);
            this.Name = "FrmStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Director Of Students";
            this.Load += new System.EventHandler(this.FrmStudents_Load);
            this.Actions.ResumeLayout(false);
            this.Students.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddStudBtn;
        private System.Windows.Forms.Button DeleteStudBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button EditStudentB;
        private System.Windows.Forms.Button AssignStudentToCourse;
        private System.Windows.Forms.GroupBox Actions;
        private System.Windows.Forms.GroupBox Students;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Student;
        private System.Windows.Forms.TextBox StudentID_txt;
    }
}