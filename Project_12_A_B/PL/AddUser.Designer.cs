namespace Project_12_A_B.PL
{
    partial class AddUser
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
            this.User_ID = new System.Windows.Forms.Label();
            this.User_Name = new System.Windows.Forms.Label();
            this.User_Permission = new System.Windows.Forms.Label();
            this.User_Email = new System.Windows.Forms.Label();
            this.User_Address = new System.Windows.Forms.Label();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.isLogged_txt = new System.Windows.Forms.TextBox();
            this.isLogged = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.permission_combo = new System.Windows.Forms.ComboBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.Address_txt = new System.Windows.Forms.TextBox();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(537, 22);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // User_ID
            // 
            this.User_ID.AutoSize = true;
            this.User_ID.Location = new System.Drawing.Point(33, 28);
            this.User_ID.Name = "User_ID";
            this.User_ID.Size = new System.Drawing.Size(43, 13);
            this.User_ID.TabIndex = 1;
            this.User_ID.Text = "User ID";
            // 
            // User_Name
            // 
            this.User_Name.AutoSize = true;
            this.User_Name.Location = new System.Drawing.Point(33, 114);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(35, 13);
            this.User_Name.TabIndex = 2;
            this.User_Name.Text = "Name";
            // 
            // User_Permission
            // 
            this.User_Permission.AutoSize = true;
            this.User_Permission.Location = new System.Drawing.Point(33, 183);
            this.User_Permission.Name = "User_Permission";
            this.User_Permission.Size = new System.Drawing.Size(57, 13);
            this.User_Permission.TabIndex = 4;
            this.User_Permission.Text = "Permission";
            // 
            // User_Email
            // 
            this.User_Email.AutoSize = true;
            this.User_Email.Location = new System.Drawing.Point(322, 178);
            this.User_Email.Name = "User_Email";
            this.User_Email.Size = new System.Drawing.Size(32, 13);
            this.User_Email.TabIndex = 5;
            this.User_Email.Text = "Email";
            // 
            // User_Address
            // 
            this.User_Address.AutoSize = true;
            this.User_Address.Location = new System.Drawing.Point(322, 103);
            this.User_Address.Name = "User_Address";
            this.User_Address.Size = new System.Drawing.Size(45, 13);
            this.User_Address.TabIndex = 6;
            this.User_Address.Text = "Address";
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(126, 25);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(121, 20);
            this.ID_txt.TabIndex = 8;
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(126, 107);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(121, 20);
            this.Name_txt.TabIndex = 9;
            // 
            // isLogged_txt
            // 
            this.isLogged_txt.Location = new System.Drawing.Point(397, 240);
            this.isLogged_txt.Name = "isLogged_txt";
            this.isLogged_txt.Size = new System.Drawing.Size(121, 20);
            this.isLogged_txt.TabIndex = 13;
            // 
            // isLogged
            // 
            this.isLogged.AutoSize = true;
            this.isLogged.Location = new System.Drawing.Point(322, 247);
            this.isLogged.Name = "isLogged";
            this.isLogged.Size = new System.Drawing.Size(51, 13);
            this.isLogged.TabIndex = 14;
            this.isLogged.Text = "IsLogged";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(33, 254);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 16;
            this.Password.Text = "Password";
            // 
            // permission_combo
            // 
            this.permission_combo.FormattingEnabled = true;
            this.permission_combo.Items.AddRange(new object[] {
            "4",
            "6"});
            this.permission_combo.Location = new System.Drawing.Point(126, 180);
            this.permission_combo.Name = "permission_combo";
            this.permission_combo.Size = new System.Drawing.Size(121, 21);
            this.permission_combo.TabIndex = 17;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(126, 244);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(121, 20);
            this.password_txt.TabIndex = 18;
            // 
            // Address_txt
            // 
            this.Address_txt.Location = new System.Drawing.Point(397, 100);
            this.Address_txt.Name = "Address_txt";
            this.Address_txt.Size = new System.Drawing.Size(164, 20);
            this.Address_txt.TabIndex = 19;
            // 
            // Email_txt
            // 
            this.Email_txt.Location = new System.Drawing.Point(397, 175);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(164, 20);
            this.Email_txt.TabIndex = 20;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(382, 22);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(90, 23);
            this.Add.TabIndex = 21;
            this.Add.Text = "Add User";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 317);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.Address_txt);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.permission_combo);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.isLogged);
            this.Controls.Add(this.isLogged_txt);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.User_Address);
            this.Controls.Add(this.User_Email);
            this.Controls.Add(this.User_Permission);
            this.Controls.Add(this.User_Name);
            this.Controls.Add(this.User_ID);
            this.Controls.Add(this.Exit);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label User_ID;
        private System.Windows.Forms.Label User_Name;
        private System.Windows.Forms.Label User_Permission;
        private System.Windows.Forms.Label User_Email;
        private System.Windows.Forms.Label User_Address;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.TextBox isLogged_txt;
        private System.Windows.Forms.Label isLogged;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.ComboBox permission_combo;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox Address_txt;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.Button Add;
    }
}