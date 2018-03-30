namespace Project_12_A_B.Forms.Student
{
    partial class Requests
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
            this.ChoiceBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Reasonlbl = new MetroFramework.Controls.MetroLabel();
            this.SubBtn = new MetroFramework.Controls.MetroTile();
            this.CancelBtn = new MetroFramework.Controls.MetroTile();
            this.ReasonBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChoiceBox
            // 
            this.ChoiceBox.FormattingEnabled = true;
            this.ChoiceBox.ItemHeight = 23;
            this.ChoiceBox.Items.AddRange(new object[] {
            "Request HomeWork Cancelletion",
            "Special Exam \t",
            "Delay HomeWork",
            "Another"});
            this.ChoiceBox.Location = new System.Drawing.Point(81, 63);
            this.ChoiceBox.Name = "ChoiceBox";
            this.ChoiceBox.Size = new System.Drawing.Size(121, 29);
            this.ChoiceBox.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Subject";
            // 
            // Reasonlbl
            // 
            this.Reasonlbl.AutoSize = true;
            this.Reasonlbl.Location = new System.Drawing.Point(24, 98);
            this.Reasonlbl.Name = "Reasonlbl";
            this.Reasonlbl.Size = new System.Drawing.Size(54, 19);
            this.Reasonlbl.TabIndex = 3;
            this.Reasonlbl.Text = "Reason:";
            // 
            // SubBtn
            // 
            this.SubBtn.Location = new System.Drawing.Point(395, 268);
            this.SubBtn.Name = "SubBtn";
            this.SubBtn.Size = new System.Drawing.Size(75, 23);
            this.SubBtn.Style = MetroFramework.MetroColorStyle.Lime;
            this.SubBtn.TabIndex = 4;
            this.SubBtn.Text = "Submit";
            this.SubBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.SubBtn.Click += new System.EventHandler(this.SubBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(314, 268);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ReasonBox
            // 
            this.ReasonBox.Location = new System.Drawing.Point(24, 129);
            this.ReasonBox.Multiline = true;
            this.ReasonBox.Name = "ReasonBox";
            this.ReasonBox.Size = new System.Drawing.Size(450, 133);
            this.ReasonBox.TabIndex = 6;
            // 
            // Requests
            // 
            this.AcceptButton = this.SubBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(497, 314);
            this.Controls.Add(this.ReasonBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SubBtn);
            this.Controls.Add(this.Reasonlbl);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ChoiceBox);
            this.Name = "Requests";
            this.Text = "Requests";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Requests_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox ChoiceBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel Reasonlbl;
        private MetroFramework.Controls.MetroTile SubBtn;
        private MetroFramework.Controls.MetroTile CancelBtn;
        private System.Windows.Forms.TextBox ReasonBox;
    }
}