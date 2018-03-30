namespace Project_Sce.PL
{
    partial class FrmDeleteCourses
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
            this.CourseID = new System.Windows.Forms.Label();
            this.CourseIDBox = new System.Windows.Forms.TextBox();
            this.DeleteCoursebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseID
            // 
            this.CourseID.AutoSize = true;
            this.CourseID.Font = new System.Drawing.Font("Miriam Fixed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CourseID.Location = new System.Drawing.Point(55, 101);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(141, 19);
            this.CourseID.TabIndex = 2;
            this.CourseID.Text = "Course ID :";
            // 
            // CourseIDBox
            // 
            this.CourseIDBox.Location = new System.Drawing.Point(193, 98);
            this.CourseIDBox.Name = "CourseIDBox";
            this.CourseIDBox.Size = new System.Drawing.Size(100, 24);
            this.CourseIDBox.TabIndex = 3;
            this.CourseIDBox.TextChanged += new System.EventHandler(this.CourseIDBox_TextChanged);
            // 
            // DeleteCoursebtn
            // 
            this.DeleteCoursebtn.ForeColor = System.Drawing.Color.Red;
            this.DeleteCoursebtn.Location = new System.Drawing.Point(368, 101);
            this.DeleteCoursebtn.Name = "DeleteCoursebtn";
            this.DeleteCoursebtn.Size = new System.Drawing.Size(112, 31);
            this.DeleteCoursebtn.TabIndex = 4;
            this.DeleteCoursebtn.Text = "Delete";
            this.DeleteCoursebtn.UseVisualStyleBackColor = true;
            this.DeleteCoursebtn.Click += new System.EventHandler(this.DeleteCoursebtn_Click);
            // 
            // FrmDeleteCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 261);
            this.Controls.Add(this.DeleteCoursebtn);
            this.Controls.Add(this.CourseIDBox);
            this.Controls.Add(this.CourseID);
            this.Font = new System.Drawing.Font("Miriam Fixed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmDeleteCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDeleteCourses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CourseID;
        private System.Windows.Forms.TextBox CourseIDBox;
        private System.Windows.Forms.Button DeleteCoursebtn;
    }
}