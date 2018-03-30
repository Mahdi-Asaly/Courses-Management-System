namespace Project_Sce.PL
{
    partial class FrmLessons
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
            this.add_btn = new System.Windows.Forms.Button();
            this.Return_Button = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.DeleteBUTTON = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(354, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lessons";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(631, 147);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(294, 235);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // Return_Button
            // 
            this.Return_Button.BackColor = System.Drawing.Color.Khaki;
            this.Return_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_Button.ForeColor = System.Drawing.Color.Green;
            this.Return_Button.Location = new System.Drawing.Point(1, 381);
            this.Return_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(389, 111);
            this.Return_Button.TabIndex = 4;
            this.Return_Button.Text = "Return";
            this.Return_Button.UseVisualStyleBackColor = false;
            this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.LightPink;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.Red;
            this.LogOut.Location = new System.Drawing.Point(387, 381);
            this.LogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(538, 111);
            this.LogOut.TabIndex = 5;
            this.LogOut.Text = "Logout";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // DeleteBUTTON
            // 
            this.DeleteBUTTON.BackColor = System.Drawing.Color.Salmon;
            this.DeleteBUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBUTTON.Location = new System.Drawing.Point(387, 147);
            this.DeleteBUTTON.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBUTTON.Name = "DeleteBUTTON";
            this.DeleteBUTTON.Size = new System.Drawing.Size(248, 235);
            this.DeleteBUTTON.TabIndex = 6;
            this.DeleteBUTTON.Text = "Delete";
            this.DeleteBUTTON.UseVisualStyleBackColor = false;
            this.DeleteBUTTON.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1, 147);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(389, 235);
            this.button1.TabIndex = 7;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.editLesson_click);
            // 
            // FrmLessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(924, 564);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteBUTTON);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Return_Button);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLessons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLessons";
            this.Load += new System.EventHandler(this.FrmLessons_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button DeleteBUTTON;
        private System.Windows.Forms.Button button1;
    }
}