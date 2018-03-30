namespace Project_12_A_B
{
    partial class RequestTechSup_Secretary
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
            this.ReqLabel = new System.Windows.Forms.Label();
            this.RequestTextBox_Secretary = new System.Windows.Forms.TextBox();
            this.SendReqSupportButton = new System.Windows.Forms.Button();
            this.CancelSupReqButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReqLabel
            // 
            this.ReqLabel.AutoSize = true;
            this.ReqLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReqLabel.ForeColor = System.Drawing.Color.Black;
            this.ReqLabel.Location = new System.Drawing.Point(11, 63);
            this.ReqLabel.Name = "ReqLabel";
            this.ReqLabel.Size = new System.Drawing.Size(409, 21);
            this.ReqLabel.TabIndex = 0;
            this.ReqLabel.Text = "You can enter a maxiumum of 256 characters.";
            // 
            // RequestTextBox_Secretary
            // 
            this.RequestTextBox_Secretary.Location = new System.Drawing.Point(15, 87);
            this.RequestTextBox_Secretary.Multiline = true;
            this.RequestTextBox_Secretary.Name = "RequestTextBox_Secretary";
            this.RequestTextBox_Secretary.Size = new System.Drawing.Size(804, 135);
            this.RequestTextBox_Secretary.TabIndex = 1;
            this.RequestTextBox_Secretary.TextChanged += new System.EventHandler(this.RequestTextBox_Secretary_TextChanged);
            // 
            // SendReqSupportButton
            // 
            this.SendReqSupportButton.Location = new System.Drawing.Point(744, 228);
            this.SendReqSupportButton.Name = "SendReqSupportButton";
            this.SendReqSupportButton.Size = new System.Drawing.Size(75, 23);
            this.SendReqSupportButton.TabIndex = 2;
            this.SendReqSupportButton.Text = "Send";
            this.SendReqSupportButton.UseVisualStyleBackColor = true;
            this.SendReqSupportButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelSupReqButton
            // 
            this.CancelSupReqButton.Location = new System.Drawing.Point(663, 228);
            this.CancelSupReqButton.Name = "CancelSupReqButton";
            this.CancelSupReqButton.Size = new System.Drawing.Size(75, 23);
            this.CancelSupReqButton.TabIndex = 3;
            this.CancelSupReqButton.Text = "Cancel";
            this.CancelSupReqButton.UseVisualStyleBackColor = true;
            this.CancelSupReqButton.Click += new System.EventHandler(this.CancelSupReqButton_Click);
            // 
            // RequestTechSup_Secretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 274);
            this.Controls.Add(this.CancelSupReqButton);
            this.Controls.Add(this.SendReqSupportButton);
            this.Controls.Add(this.RequestTextBox_Secretary);
            this.Controls.Add(this.ReqLabel);
            this.Name = "RequestTechSup_Secretary";
            this.Text = "Request Support";
            this.Load += new System.EventHandler(this.RequestTechSup_Secretary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReqLabel;
        private System.Windows.Forms.TextBox RequestTextBox_Secretary;
        private System.Windows.Forms.Button SendReqSupportButton;
        private System.Windows.Forms.Button CancelSupReqButton;
    }
}