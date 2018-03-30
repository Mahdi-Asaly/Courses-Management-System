namespace Project_Sce.PL
{
    partial class FrmAdmin
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
            this.RequestsB = new System.Windows.Forms.Button();
            this.ReturnBT = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RequestsB
            // 
            this.RequestsB.Location = new System.Drawing.Point(17, 131);
            this.RequestsB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RequestsB.Name = "RequestsB";
            this.RequestsB.Size = new System.Drawing.Size(288, 100);
            this.RequestsB.TabIndex = 0;
            this.RequestsB.Text = "Requests";
            this.RequestsB.UseVisualStyleBackColor = true;
            this.RequestsB.Click += new System.EventHandler(this.RequestsB_Click);
            // 
            // ReturnBT
            // 
            this.ReturnBT.Location = new System.Drawing.Point(17, 659);
            this.ReturnBT.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ReturnBT.Name = "ReturnBT";
            this.ReturnBT.Size = new System.Drawing.Size(288, 100);
            this.ReturnBT.TabIndex = 1;
            this.ReturnBT.Text = "Exit";
            this.ReturnBT.UseVisualStyleBackColor = true;
            this.ReturnBT.Click += new System.EventHandler(this.ReturnBT_Click);
            // 
            // Users
            // 
            this.Users.Location = new System.Drawing.Point(427, 131);
            this.Users.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(288, 100);
            this.Users.TabIndex = 2;
            this.Users.Text = "Users";
            this.Users.UseVisualStyleBackColor = true;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 775);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.ReturnBT);
            this.Controls.Add(this.RequestsB);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHeadDepartment";
            this.Load += new System.EventHandler(this.FrmHeadDepartment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RequestsB;
        private System.Windows.Forms.Button ReturnBT;
        private System.Windows.Forms.Button Users;
    }
}