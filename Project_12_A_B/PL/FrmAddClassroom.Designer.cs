namespace Project_Sce.PL
{
    partial class FrmAddClassroom
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.proj = new System.Windows.Forms.CheckBox();
            this.comp = new System.Windows.Forms.CheckBox();
            this.numOfSeats = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.btnAddClassroom = new System.Windows.Forms.Button();
            this.Return_Button = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of seats: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "projector";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "computers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Includes:";
            // 
            // proj
            // 
            this.proj.AutoSize = true;
            this.proj.Location = new System.Drawing.Point(254, 233);
            this.proj.Name = "proj";
            this.proj.Size = new System.Drawing.Size(18, 17);
            this.proj.TabIndex = 6;
            this.proj.UseVisualStyleBackColor = true;
            // 
            // comp
            // 
            this.comp.AutoSize = true;
            this.comp.Location = new System.Drawing.Point(254, 277);
            this.comp.Name = "comp";
            this.comp.Size = new System.Drawing.Size(18, 17);
            this.comp.TabIndex = 7;
            this.comp.UseVisualStyleBackColor = true;
            // 
            // numOfSeats
            // 
            this.numOfSeats.Location = new System.Drawing.Point(224, 122);
            this.numOfSeats.Name = "numOfSeats";
            this.numOfSeats.Size = new System.Drawing.Size(100, 22);
            this.numOfSeats.TabIndex = 9;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(224, 63);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 10;
            // 
            // btnAddClassroom
            // 
            this.btnAddClassroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClassroom.ForeColor = System.Drawing.Color.Green;
            this.btnAddClassroom.Location = new System.Drawing.Point(32, 410);
            this.btnAddClassroom.Name = "btnAddClassroom";
            this.btnAddClassroom.Size = new System.Drawing.Size(114, 49);
            this.btnAddClassroom.TabIndex = 19;
            this.btnAddClassroom.Text = "Add Classroom";
            this.btnAddClassroom.UseVisualStyleBackColor = true;
            this.btnAddClassroom.Click += new System.EventHandler(this.btnAddClassroom_Click);
            // 
            // Return_Button
            // 
            this.Return_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_Button.Location = new System.Drawing.Point(244, 410);
            this.Return_Button.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(125, 49);
            this.Return_Button.TabIndex = 20;
            this.Return_Button.Text = "Return";
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(458, 410);
            this.logout.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(125, 49);
            this.logout.TabIndex = 21;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // FrmAddClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 492);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.Return_Button);
            this.Controls.Add(this.btnAddClassroom);
            this.Controls.Add(this.name);
            this.Controls.Add(this.numOfSeats);
            this.Controls.Add(this.comp);
            this.Controls.Add(this.proj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddClassroom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddClassroom";
            this.Load += new System.EventHandler(this.FrmAddClassroom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox proj;
        private System.Windows.Forms.CheckBox comp;
        private System.Windows.Forms.TextBox numOfSeats;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button btnAddClassroom;
        private System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.Button logout;
    }
}