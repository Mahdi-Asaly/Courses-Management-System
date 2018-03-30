namespace Project_12_A_B.PL
{
    partial class StudentSectionDirect
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
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StudentID = new System.Windows.Forms.TextBox();
            this.StudentAddress = new System.Windows.Forms.TextBox();
            this.StudentEmail = new System.Windows.Forms.TextBox();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Student_ID = new System.Windows.Forms.Label();
            this.Student_Name = new System.Windows.Forms.Label();
            this.Acadimic = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.Acadimic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(632, 365);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(163, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(601, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 180);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Photo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_12_A_B.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StudentID);
            this.groupBox2.Controls.Add(this.StudentAddress);
            this.groupBox2.Controls.Add(this.StudentEmail);
            this.groupBox2.Controls.Add(this.StudentName);
            this.groupBox2.Controls.Add(this.Email);
            this.groupBox2.Controls.Add(this.Address);
            this.groupBox2.Controls.Add(this.Student_ID);
            this.groupBox2.Controls.Add(this.Student_Name);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 180);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Data";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // StudentID
            // 
            this.StudentID.Location = new System.Drawing.Point(124, 65);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(248, 20);
            this.StudentID.TabIndex = 8;
            // 
            // StudentAddress
            // 
            this.StudentAddress.Location = new System.Drawing.Point(124, 106);
            this.StudentAddress.Name = "StudentAddress";
            this.StudentAddress.Size = new System.Drawing.Size(248, 20);
            this.StudentAddress.TabIndex = 7;
            // 
            // StudentEmail
            // 
            this.StudentEmail.Location = new System.Drawing.Point(124, 137);
            this.StudentEmail.Name = "StudentEmail";
            this.StudentEmail.Size = new System.Drawing.Size(248, 20);
            this.StudentEmail.TabIndex = 6;
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(124, 31);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(248, 20);
            this.StudentName.TabIndex = 5;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(16, 140);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(16, 106);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 3;
            this.Address.Text = "Address";
            // 
            // Student_ID
            // 
            this.Student_ID.AutoSize = true;
            this.Student_ID.Location = new System.Drawing.Point(16, 68);
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.Size = new System.Drawing.Size(58, 13);
            this.Student_ID.TabIndex = 1;
            this.Student_ID.Text = "Student ID";
            // 
            // Student_Name
            // 
            this.Student_Name.AutoSize = true;
            this.Student_Name.Location = new System.Drawing.Point(16, 31);
            this.Student_Name.Name = "Student_Name";
            this.Student_Name.Size = new System.Drawing.Size(35, 13);
            this.Student_Name.TabIndex = 0;
            this.Student_Name.Text = "Name";
            // 
            // Acadimic
            // 
            this.Acadimic.Controls.Add(this.dataGridView1);
            this.Acadimic.Location = new System.Drawing.Point(12, 198);
            this.Acadimic.Name = "Acadimic";
            this.Acadimic.Size = new System.Drawing.Size(783, 161);
            this.Acadimic.TabIndex = 9;
            this.Acadimic.TabStop = false;
            this.Acadimic.Text = "Acadimic";
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
            this.dataGridView1.Size = new System.Drawing.Size(771, 136);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StudentSectionDirect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 400);
            this.Controls.Add(this.Acadimic);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Exit);
            this.Name = "StudentSectionDirect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentSectionDirect";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Acadimic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Student_ID;
        private System.Windows.Forms.Label Student_Name;
        private System.Windows.Forms.GroupBox Acadimic;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.TextBox StudentAddress;
        private System.Windows.Forms.TextBox StudentEmail;
        private System.Windows.Forms.TextBox StudentName;
    }
}