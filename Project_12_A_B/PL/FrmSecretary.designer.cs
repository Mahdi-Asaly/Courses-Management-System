namespace Project_Sce.PL
{
    partial class FrmSecretary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSecretary));
            this.label1 = new System.Windows.Forms.Label();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Course_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lessons = new System.Windows.Forms.Button();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonLecturers = new System.Windows.Forms.Button();
            this.buttonConstraints = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(268, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.Red;
            this.Logout_btn.Location = new System.Drawing.Point(390, 86);
            this.Logout_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(238, 125);
            this.Logout_btn.TabIndex = 1;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // Course_btn
            // 
            this.Course_btn.BackColor = System.Drawing.Color.Transparent;
            this.Course_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Course_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_btn.Location = new System.Drawing.Point(59, 74);
            this.Course_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Course_btn.Name = "Course_btn";
            this.Course_btn.Size = new System.Drawing.Size(125, 34);
            this.Course_btn.TabIndex = 2;
            this.Course_btn.Text = "Courses";
            this.Course_btn.UseVisualStyleBackColor = false;
            this.Course_btn.Click += new System.EventHandler(this.Course_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(59, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Classrooms";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.classroom_Click);
            // 
            // lessons
            // 
            this.lessons.BackColor = System.Drawing.Color.Transparent;
            this.lessons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessons.Location = new System.Drawing.Point(59, 219);
            this.lessons.Margin = new System.Windows.Forms.Padding(4);
            this.lessons.Name = "lessons";
            this.lessons.Size = new System.Drawing.Size(125, 39);
            this.lessons.TabIndex = 5;
            this.lessons.Text = "Lessons";
            this.lessons.UseVisualStyleBackColor = false;
            this.lessons.Click += new System.EventHandler(this.lesson_Click);
            // 
            // buttonStudents
            // 
            this.buttonStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudents.Location = new System.Drawing.Point(246, 86);
            this.buttonStudents.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(145, 125);
            this.buttonStudents.TabIndex = 7;
            this.buttonStudents.Text = "Students";
            this.buttonStudents.UseVisualStyleBackColor = false;
            this.buttonStudents.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonLecturers
            // 
            this.buttonLecturers.BackColor = System.Drawing.Color.Transparent;
            this.buttonLecturers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLecturers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLecturers.Location = new System.Drawing.Point(237, 219);
            this.buttonLecturers.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLecturers.Name = "buttonLecturers";
            this.buttonLecturers.Size = new System.Drawing.Size(145, 39);
            this.buttonLecturers.TabIndex = 8;
            this.buttonLecturers.Text = "Lecturers";
            this.buttonLecturers.UseVisualStyleBackColor = false;
            this.buttonLecturers.Click += new System.EventHandler(this.buttonLecturers_Click);
            // 
            // buttonConstraints
            // 
            this.buttonConstraints.BackColor = System.Drawing.Color.Transparent;
            this.buttonConstraints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConstraints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConstraints.Location = new System.Drawing.Point(237, 286);
            this.buttonConstraints.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConstraints.Name = "buttonConstraints";
            this.buttonConstraints.Size = new System.Drawing.Size(145, 39);
            this.buttonConstraints.TabIndex = 9;
            this.buttonConstraints.Text = "Constraints";
            this.buttonConstraints.UseVisualStyleBackColor = false;
            this.buttonConstraints.Click += new System.EventHandler(this.buttonConstraints_Click);
            // 
            // FrmSecretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(836, 394);
            this.Controls.Add(this.buttonConstraints);
            this.Controls.Add(this.buttonLecturers);
            this.Controls.Add(this.buttonStudents);
            this.Controls.Add(this.lessons);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Course_btn);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSecretary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSecretary";
            this.Load += new System.EventHandler(this.FrmSecretary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Button Course_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button lessons;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonLecturers;
        private System.Windows.Forms.Button buttonConstraints;
    }
}