namespace Project_Sce.PL
{
    partial class FrmStudentRequest
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
            this.Id_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBT = new System.Windows.Forms.Button();
            this.AprroveCB = new System.Windows.Forms.CheckBox();
            this.DenyCB = new System.Windows.Forms.CheckBox();
            this.SaveBT = new System.Windows.Forms.Button();
            this.ReturnBT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReasonTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DetailsTB = new System.Windows.Forms.TextBox();
            this.StudName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Id_TB
            // 
            this.Id_TB.Location = new System.Drawing.Point(140, 26);
            this.Id_TB.Name = "Id_TB";
            this.Id_TB.Size = new System.Drawing.Size(100, 20);
            this.Id_TB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Id :";
            // 
            // SearchBT
            // 
            this.SearchBT.Location = new System.Drawing.Point(277, 24);
            this.SearchBT.Name = "SearchBT";
            this.SearchBT.Size = new System.Drawing.Size(75, 23);
            this.SearchBT.TabIndex = 2;
            this.SearchBT.Text = "Search";
            this.SearchBT.UseVisualStyleBackColor = true;
            this.SearchBT.Click += new System.EventHandler(this.SearchBT_Click);
            // 
            // AprroveCB
            // 
            this.AprroveCB.AutoSize = true;
            this.AprroveCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AprroveCB.ForeColor = System.Drawing.Color.ForestGreen;
            this.AprroveCB.Location = new System.Drawing.Point(405, 23);
            this.AprroveCB.Name = "AprroveCB";
            this.AprroveCB.Size = new System.Drawing.Size(94, 24);
            this.AprroveCB.TabIndex = 4;
            this.AprroveCB.Text = "Approve";
            this.AprroveCB.UseVisualStyleBackColor = true;
            this.AprroveCB.CheckedChanged += new System.EventHandler(this.AprroveCB_CheckedChanged);
            // 
            // DenyCB
            // 
            this.DenyCB.AutoSize = true;
            this.DenyCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DenyCB.ForeColor = System.Drawing.Color.Red;
            this.DenyCB.Location = new System.Drawing.Point(405, 49);
            this.DenyCB.Name = "DenyCB";
            this.DenyCB.Size = new System.Drawing.Size(69, 24);
            this.DenyCB.TabIndex = 5;
            this.DenyCB.Text = "Deny";
            this.DenyCB.UseVisualStyleBackColor = true;
            this.DenyCB.CheckedChanged += new System.EventHandler(this.DenyCB_CheckedChanged);
            // 
            // SaveBT
            // 
            this.SaveBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SaveBT.Location = new System.Drawing.Point(551, 24);
            this.SaveBT.Name = "SaveBT";
            this.SaveBT.Size = new System.Drawing.Size(104, 43);
            this.SaveBT.TabIndex = 6;
            this.SaveBT.Text = "Send";
            this.SaveBT.UseVisualStyleBackColor = true;
            this.SaveBT.Click += new System.EventHandler(this.SaveBT_Click);
            // 
            // ReturnBT
            // 
            this.ReturnBT.Location = new System.Drawing.Point(12, 383);
            this.ReturnBT.Name = "ReturnBT";
            this.ReturnBT.Size = new System.Drawing.Size(75, 23);
            this.ReturnBT.TabIndex = 7;
            this.ReturnBT.Text = "Return";
            this.ReturnBT.UseVisualStyleBackColor = true;
            this.ReturnBT.Click += new System.EventHandler(this.ReturnBT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReasonTB);
            this.groupBox1.Location = new System.Drawing.Point(12, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 145);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reason :";
            // 
            // ReasonTB
            // 
            this.ReasonTB.Location = new System.Drawing.Point(6, 19);
            this.ReasonTB.Multiline = true;
            this.ReasonTB.Name = "ReasonTB";
            this.ReasonTB.Size = new System.Drawing.Size(631, 120);
            this.ReasonTB.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DetailsTB);
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 132);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details :";
            // 
            // DetailsTB
            // 
            this.DetailsTB.Location = new System.Drawing.Point(6, 19);
            this.DetailsTB.Multiline = true;
            this.DetailsTB.Name = "DetailsTB";
            this.DetailsTB.ReadOnly = true;
            this.DetailsTB.Size = new System.Drawing.Size(631, 113);
            this.DetailsTB.TabIndex = 1;
            // 
            // StudName
            // 
            this.StudName.AutoSize = true;
            this.StudName.Location = new System.Drawing.Point(15, 70);
            this.StudName.Name = "StudName";
            this.StudName.Size = new System.Drawing.Size(44, 13);
            this.StudName.TabIndex = 13;
            this.StudName.Text = "Name : ";
            this.StudName.Visible = false;
            // 
            // FrmStudentRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 418);
            this.Controls.Add(this.StudName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ReturnBT);
            this.Controls.Add(this.SaveBT);
            this.Controls.Add(this.DenyCB);
            this.Controls.Add(this.AprroveCB);
            this.Controls.Add(this.SearchBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Id_TB);
            this.Name = "FrmStudentRequest";
            this.Load += new System.EventHandler(this.FrmStudentRequest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Id_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchBT;
        private System.Windows.Forms.CheckBox AprroveCB;
        private System.Windows.Forms.CheckBox DenyCB;
        private System.Windows.Forms.Button SaveBT;
        private System.Windows.Forms.Button ReturnBT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ReasonTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox DetailsTB;
        private System.Windows.Forms.Label StudName;
    }
}