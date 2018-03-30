namespace Project_Sce.PL
{
    partial class UpdateStudentInfo
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Average = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Return_Button = new System.Windows.Forms.Button();
            this.UpdateB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.StudentName,
            this.Year,
            this.Average,
            this.Address,
            this.Email});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(18, 22);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(608, 251);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 90;
            // 
            // StudentName
            // 
            this.StudentName.Text = "Name";
            this.StudentName.Width = 97;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.Width = 61;
            // 
            // Average
            // 
            this.Average.Text = "Average";
            this.Average.Width = 76;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 124;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 156;
            // 
            // Return_Button
            // 
            this.Return_Button.Location = new System.Drawing.Point(18, 299);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(75, 23);
            this.Return_Button.TabIndex = 18;
            this.Return_Button.Text = "Return";
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
            // 
            // UpdateB
            // 
            this.UpdateB.Location = new System.Drawing.Point(551, 299);
            this.UpdateB.Name = "UpdateB";
            this.UpdateB.Size = new System.Drawing.Size(75, 23);
            this.UpdateB.TabIndex = 19;
            this.UpdateB.Text = "Update";
            this.UpdateB.UseVisualStyleBackColor = true;
            this.UpdateB.Click += new System.EventHandler(this.UpdateB_Click);
            // 
            // UpdateStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 346);
            this.Controls.Add(this.UpdateB);
            this.Controls.Add(this.Return_Button);
            this.Controls.Add(this.listView1);
            this.Name = "UpdateStudentInfo";
            this.Text = "UpdateStudentInfo";
            this.Load += new System.EventHandler(this.UpdateStudentInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader StudentName;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Average;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.Button UpdateB;
    }
}