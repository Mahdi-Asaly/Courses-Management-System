namespace Project_Sce.PL
{
    partial class FrmLecturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLecturer));
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.Schedulebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LeturerInfo_BT = new System.Windows.Forms.Button();
            this.buttonCourses = new System.Windows.Forms.Button();
            this.buttonLecturers = new System.Windows.Forms.Button();
            this.buttonConstraints = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.BackColor = System.Drawing.Color.Tomato;
            this.Logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbtn.Location = new System.Drawing.Point(478, 105);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(200, 74);
            this.Logoutbtn.TabIndex = 0;
            this.Logoutbtn.Text = "Logout";
            this.Logoutbtn.UseVisualStyleBackColor = false;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // Schedulebtn
            // 
            this.Schedulebtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.Schedulebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Schedulebtn.Location = new System.Drawing.Point(-4, 105);
            this.Schedulebtn.Name = "Schedulebtn";
            this.Schedulebtn.Size = new System.Drawing.Size(233, 185);
            this.Schedulebtn.TabIndex = 1;
            this.Schedulebtn.Text = "View Schedule";
            this.Schedulebtn.UseVisualStyleBackColor = false;
            this.Schedulebtn.Click += new System.EventHandler(this.Schedulebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(275, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome .. ! ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(478, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 217);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LeturerInfo_BT
            // 
            this.LeturerInfo_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LeturerInfo_BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeturerInfo_BT.Location = new System.Drawing.Point(-4, 288);
            this.LeturerInfo_BT.Name = "LeturerInfo_BT";
            this.LeturerInfo_BT.Size = new System.Drawing.Size(358, 106);
            this.LeturerInfo_BT.TabIndex = 6;
            this.LeturerInfo_BT.Text = "Update Personal Details";
            this.LeturerInfo_BT.UseVisualStyleBackColor = false;
            this.LeturerInfo_BT.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCourses
            // 
            this.buttonCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCourses.Location = new System.Drawing.Point(353, 193);
            this.buttonCourses.Name = "buttonCourses";
            this.buttonCourses.Size = new System.Drawing.Size(126, 201);
            this.buttonCourses.TabIndex = 7;
            this.buttonCourses.Text = "Show Courses";
            this.buttonCourses.UseVisualStyleBackColor = false;
            this.buttonCourses.Click += new System.EventHandler(this.buttonCourses_Click);
            // 
            // buttonLecturers
            // 
            this.buttonLecturers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonLecturers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLecturers.Location = new System.Drawing.Point(228, 105);
            this.buttonLecturers.Name = "buttonLecturers";
            this.buttonLecturers.Size = new System.Drawing.Size(126, 185);
            this.buttonLecturers.TabIndex = 8;
            this.buttonLecturers.Text = "Lecturers";
            this.buttonLecturers.UseVisualStyleBackColor = false;
            this.buttonLecturers.Click += new System.EventHandler(this.buttonLecturers_Click);
            // 
            // buttonConstraints
            // 
            this.buttonConstraints.BackColor = System.Drawing.Color.Peru;
            this.buttonConstraints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConstraints.Location = new System.Drawing.Point(353, 104);
            this.buttonConstraints.Name = "buttonConstraints";
            this.buttonConstraints.Size = new System.Drawing.Size(126, 90);
            this.buttonConstraints.TabIndex = 9;
            this.buttonConstraints.Text = "Constraints";
            this.buttonConstraints.UseVisualStyleBackColor = false;
            this.buttonConstraints.Click += new System.EventHandler(this.buttonConstraints_Click);
            // 
            // FrmLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(678, 440);
            this.Controls.Add(this.buttonConstraints);
            this.Controls.Add(this.buttonLecturers);
            this.Controls.Add(this.buttonCourses);
            this.Controls.Add(this.LeturerInfo_BT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Schedulebtn);
            this.Controls.Add(this.Logoutbtn);
            this.Name = "FrmLecturer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLecturer";
            this.Load += new System.EventHandler(this.FrmLecturer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Button Schedulebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LeturerInfo_BT;
        private System.Windows.Forms.Button buttonCourses;
        private System.Windows.Forms.Button buttonLecturers;
        private System.Windows.Forms.Button buttonConstraints;
    }
}