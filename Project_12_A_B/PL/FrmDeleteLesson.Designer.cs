namespace Project_Sce.PL
{
    partial class FrmDeleteLesson
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
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.Return_Button = new System.Windows.Forms.Button();
            this.DeleteLessonLV = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClassRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LecturerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Day = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumOfStud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Location = new System.Drawing.Point(533, 300);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(99, 34);
            this.Delete_Btn.TabIndex = 19;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // Return_Button
            // 
            this.Return_Button.Location = new System.Drawing.Point(12, 311);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(75, 23);
            this.Return_Button.TabIndex = 20;
            this.Return_Button.Text = "Return";
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
            // 
            // DeleteLessonLV
            // 
            this.DeleteLessonLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.ClassRoom,
            this.CourseID,
            this.LecturerID,
            this.Day,
            this.StartTime,
            this.EndTime,
            this.NumOfStud});
            this.DeleteLessonLV.FullRowSelect = true;
            this.DeleteLessonLV.GridLines = true;
            this.DeleteLessonLV.Location = new System.Drawing.Point(12, 22);
            this.DeleteLessonLV.MultiSelect = false;
            this.DeleteLessonLV.Name = "DeleteLessonLV";
            this.DeleteLessonLV.Size = new System.Drawing.Size(620, 251);
            this.DeleteLessonLV.TabIndex = 21;
            this.DeleteLessonLV.UseCompatibleStateImageBehavior = false;
            this.DeleteLessonLV.View = System.Windows.Forms.View.Details;
            this.DeleteLessonLV.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 69;
            // 
            // ClassRoom
            // 
            this.ClassRoom.Text = "Class Room";
            this.ClassRoom.Width = 86;
            // 
            // CourseID
            // 
            this.CourseID.Text = "Course ID";
            this.CourseID.Width = 61;
            // 
            // LecturerID
            // 
            this.LecturerID.Text = "Lecturer ID";
            this.LecturerID.Width = 76;
            // 
            // Day
            // 
            this.Day.Text = "Day";
            this.Day.Width = 69;
            // 
            // StartTime
            // 
            this.StartTime.Text = "Start Time";
            this.StartTime.Width = 83;
            // 
            // EndTime
            // 
            this.EndTime.Text = "End Time";
            this.EndTime.Width = 62;
            // 
            // NumOfStud
            // 
            this.NumOfStud.Text = "Num of Students";
            this.NumOfStud.Width = 103;
            // 
            // FrmDeleteLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 346);
            this.Controls.Add(this.DeleteLessonLV);
            this.Controls.Add(this.Return_Button);
            this.Controls.Add(this.Delete_Btn);
            this.Name = "FrmDeleteLesson";
            this.Text = "FrmDeleteLesson";
            this.Load += new System.EventHandler(this.FrmDeleteLesson_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.ListView DeleteLessonLV;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader ClassRoom;
        private System.Windows.Forms.ColumnHeader CourseID;
        private System.Windows.Forms.ColumnHeader LecturerID;
        private System.Windows.Forms.ColumnHeader Day;
        private System.Windows.Forms.ColumnHeader StartTime;
        private System.Windows.Forms.ColumnHeader EndTime;
        private System.Windows.Forms.ColumnHeader NumOfStud;
    }
}