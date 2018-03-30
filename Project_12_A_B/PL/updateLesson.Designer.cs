namespace Project_Sce.PL
{
    partial class updateLesson
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lecturer_cat = new System.Windows.Forms.ComboBox();
            this.class_cat = new System.Windows.Forms.ComboBox();
            this.Logout_Button = new System.Windows.Forms.Button();
            this.Return_Button = new System.Windows.Forms.Button();
            this.btnAddLesson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update lesson";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lecturer ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Classroom:";
            // 
            // lecturer_cat
            // 
            this.lecturer_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lecturer_cat.FormattingEnabled = true;
            this.lecturer_cat.Location = new System.Drawing.Point(250, 198);
            this.lecturer_cat.Name = "lecturer_cat";
            this.lecturer_cat.Size = new System.Drawing.Size(266, 24);
            this.lecturer_cat.TabIndex = 14;
            this.lecturer_cat.SelectedIndexChanged += new System.EventHandler(this.lecturer_cat_SelectedIndexChanged);
            // 
            // class_cat
            // 
            this.class_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.class_cat.FormattingEnabled = true;
            this.class_cat.Location = new System.Drawing.Point(250, 328);
            this.class_cat.Name = "class_cat";
            this.class_cat.Size = new System.Drawing.Size(266, 24);
            this.class_cat.TabIndex = 15;
            this.class_cat.SelectedIndexChanged += new System.EventHandler(this.class_cat_SelectedIndexChanged);
            // 
            // Logout_Button
            // 
            this.Logout_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Logout_Button.Location = new System.Drawing.Point(718, 369);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Size = new System.Drawing.Size(122, 49);
            this.Logout_Button.TabIndex = 28;
            this.Logout_Button.Text = "Logout";
            this.Logout_Button.UseVisualStyleBackColor = true;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click);
            // 
            // Return_Button
            // 
            this.Return_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_Button.Location = new System.Drawing.Point(715, 254);
            this.Return_Button.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(125, 49);
            this.Return_Button.TabIndex = 27;
            this.Return_Button.Text = "Return";
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLesson.ForeColor = System.Drawing.Color.Green;
            this.btnAddLesson.Location = new System.Drawing.Point(714, 136);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(126, 49);
            this.btnAddLesson.TabIndex = 26;
            this.btnAddLesson.Text = "Update Lesson";
            this.btnAddLesson.UseVisualStyleBackColor = true;
            this.btnAddLesson.Click += new System.EventHandler(this.btnAddLesson_Click);
            // 
            // updateLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 568);
            this.Controls.Add(this.Logout_Button);
            this.Controls.Add(this.Return_Button);
            this.Controls.Add(this.btnAddLesson);
            this.Controls.Add(this.class_cat);
            this.Controls.Add(this.lecturer_cat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "updateLesson";
            this.Text = "_updateLesson";
            this.Load += new System.EventHandler(this.updateLesson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lecturer_cat;
        private System.Windows.Forms.ComboBox class_cat;
        private System.Windows.Forms.Button Logout_Button;
        private System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.Button btnAddLesson;
    }
}