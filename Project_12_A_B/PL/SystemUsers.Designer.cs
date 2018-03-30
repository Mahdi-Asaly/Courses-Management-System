namespace Project_12_A_B.PL
{
    partial class SystemUsers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete_User = new System.Windows.Forms.Button();
            this.Add_User = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(602, 21);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(636, 271);
            this.dataGridView1.TabIndex = 1;
            // 
            // Delete_User
            // 
            this.Delete_User.Location = new System.Drawing.Point(34, 21);
            this.Delete_User.Name = "Delete_User";
            this.Delete_User.Size = new System.Drawing.Size(120, 23);
            this.Delete_User.TabIndex = 2;
            this.Delete_User.Text = "Delete User";
            this.Delete_User.UseVisualStyleBackColor = true;
            this.Delete_User.Click += new System.EventHandler(this.Delete_User_Click);
            // 
            // Add_User
            // 
            this.Add_User.Location = new System.Drawing.Point(250, 21);
            this.Add_User.Name = "Add_User";
            this.Add_User.Size = new System.Drawing.Size(145, 23);
            this.Add_User.TabIndex = 3;
            this.Add_User.Text = "Add User";
            this.Add_User.UseVisualStyleBackColor = true;
            this.Add_User.Click += new System.EventHandler(this.Add_User_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(439, 21);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(121, 23);
            this.Refresh.TabIndex = 4;
            this.Refresh.Text = "Refresh Data";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // SystemUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 363);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Add_User);
            this.Controls.Add(this.Delete_User);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Exit);
            this.Name = "SystemUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Delete_User;
        private System.Windows.Forms.Button Add_User;
        private System.Windows.Forms.Button Refresh;
    }
}