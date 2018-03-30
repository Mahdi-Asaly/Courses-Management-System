namespace Project_Sce.PL
{
    partial class FrmDelClassroom
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
            this.name = new System.Windows.Forms.TextBox();
            this.DeleteCoursebtn = new System.Windows.Forms.Button();
            this.Logout_Button = new System.Windows.Forms.Button();
            this.Return_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(73, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the classroom name: ";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(129, 146);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 1;
            // 
            // DeleteCoursebtn
            // 
            this.DeleteCoursebtn.ForeColor = System.Drawing.Color.Red;
            this.DeleteCoursebtn.Location = new System.Drawing.Point(12, 245);
            this.DeleteCoursebtn.Name = "DeleteCoursebtn";
            this.DeleteCoursebtn.Size = new System.Drawing.Size(112, 49);
            this.DeleteCoursebtn.TabIndex = 5;
            this.DeleteCoursebtn.Text = "Delete classroom";
            this.DeleteCoursebtn.UseVisualStyleBackColor = true;
            this.DeleteCoursebtn.Click += new System.EventHandler(this.DeleteCoursebtn_Click);
            // 
            // Logout_Button
            // 
            this.Logout_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Logout_Button.Location = new System.Drawing.Point(270, 246);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Size = new System.Drawing.Size(112, 48);
            this.Logout_Button.TabIndex = 6;
            this.Logout_Button.Text = "Logout";
            this.Logout_Button.UseVisualStyleBackColor = true;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click);
            // 
            // Return_Button
            // 
            this.Return_Button.ForeColor = System.Drawing.Color.Navy;
            this.Return_Button.Location = new System.Drawing.Point(140, 247);
            this.Return_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(112, 47);
            this.Return_Button.TabIndex = 7;
            this.Return_Button.Text = "Return";
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
            // 
            // FrmDelClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 375);
            this.Controls.Add(this.Return_Button);
            this.Controls.Add(this.Logout_Button);
            this.Controls.Add(this.DeleteCoursebtn);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "FrmDelClassroom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDelClassroom";
            this.Load += new System.EventHandler(this.FrmDelClassroom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button DeleteCoursebtn;
        private System.Windows.Forms.Button Logout_Button;
        private System.Windows.Forms.Button Return_Button;
    }
}