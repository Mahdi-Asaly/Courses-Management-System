namespace Project_Sce.PL
{
    partial class DirectOfStud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectOfStud));
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonCourses = new System.Windows.Forms.Button();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonLecturers = new System.Windows.Forms.Button();
            this.buttonClasses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(320, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome .. ! ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chocolate;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(531, 328);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(352, 136);
            this.button2.TabIndex = 2;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCourses
            // 
            this.buttonCourses.BackColor = System.Drawing.Color.IndianRed;
            this.buttonCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCourses.ForeColor = System.Drawing.Color.White;
            this.buttonCourses.Location = new System.Drawing.Point(2, 92);
            this.buttonCourses.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCourses.Name = "buttonCourses";
            this.buttonCourses.Size = new System.Drawing.Size(218, 372);
            this.buttonCourses.TabIndex = 3;
            this.buttonCourses.Text = "Courses";
            this.buttonCourses.UseVisualStyleBackColor = false;
            this.buttonCourses.Click += new System.EventHandler(this.buttonCourses_Click);
            // 
            // buttonStudents
            // 
            this.buttonStudents.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudents.ForeColor = System.Drawing.Color.White;
            this.buttonStudents.Location = new System.Drawing.Point(216, 92);
            this.buttonStudents.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(319, 190);
            this.buttonStudents.TabIndex = 4;
            this.buttonStudents.Text = "Students";
            this.buttonStudents.UseVisualStyleBackColor = false;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonLecturers
            // 
            this.buttonLecturers.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonLecturers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLecturers.ForeColor = System.Drawing.Color.White;
            this.buttonLecturers.Location = new System.Drawing.Point(531, 92);
            this.buttonLecturers.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLecturers.Name = "buttonLecturers";
            this.buttonLecturers.Size = new System.Drawing.Size(352, 239);
            this.buttonLecturers.TabIndex = 5;
            this.buttonLecturers.Text = "Lecturers";
            this.buttonLecturers.UseVisualStyleBackColor = false;
            this.buttonLecturers.Click += new System.EventHandler(this.buttonLecturers_Click);
            // 
            // buttonClasses
            // 
            this.buttonClasses.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClasses.ForeColor = System.Drawing.Color.White;
            this.buttonClasses.Location = new System.Drawing.Point(216, 279);
            this.buttonClasses.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClasses.Name = "buttonClasses";
            this.buttonClasses.Size = new System.Drawing.Size(319, 185);
            this.buttonClasses.TabIndex = 6;
            this.buttonClasses.Text = "Classes";
            this.buttonClasses.UseVisualStyleBackColor = false;
            this.buttonClasses.Click += new System.EventHandler(this.buttonClasses_Click);
            // 
            // DirectOfStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(875, 494);
            this.Controls.Add(this.buttonClasses);
            this.Controls.Add(this.buttonLecturers);
            this.Controls.Add(this.buttonStudents);
            this.Controls.Add(this.buttonCourses);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DirectOfStud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DirectOfStud";
            this.Load += new System.EventHandler(this.DirectOfStud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonCourses;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonLecturers;
        private System.Windows.Forms.Button buttonClasses;
    }
}