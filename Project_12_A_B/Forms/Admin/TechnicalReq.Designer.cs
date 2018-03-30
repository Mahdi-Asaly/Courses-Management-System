namespace Project_12_A_B.Forms.Admin
{
    partial class TechnicalReq
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
            this.RequestTextBox_Admin = new System.Windows.Forms.TextBox();
            this.ReqLabel = new System.Windows.Forms.Label();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // RequestTextBox_Admin
            // 
            this.RequestTextBox_Admin.Location = new System.Drawing.Point(23, 79);
            this.RequestTextBox_Admin.Multiline = true;
            this.RequestTextBox_Admin.Name = "RequestTextBox_Admin";
            this.RequestTextBox_Admin.Size = new System.Drawing.Size(804, 135);
            this.RequestTextBox_Admin.TabIndex = 5;
            // 
            // ReqLabel
            // 
            this.ReqLabel.AutoSize = true;
            this.ReqLabel.BackColor = System.Drawing.Color.Black;
            this.ReqLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReqLabel.ForeColor = System.Drawing.Color.Lime;
            this.ReqLabel.Location = new System.Drawing.Point(19, 55);
            this.ReqLabel.Name = "ReqLabel";
            this.ReqLabel.Size = new System.Drawing.Size(409, 21);
            this.ReqLabel.TabIndex = 4;
            this.ReqLabel.Text = "You can enter a maxiumum of 256 characters.";
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(225, 219);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(192, 23);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile1.TabIndex = 8;
            this.metroTile1.Text = "Cancel";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(423, 219);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(201, 23);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile2.TabIndex = 9;
            this.metroTile2.Text = "Save";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // TechnicalReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 253);
            this.ControlBox = false;
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.RequestTextBox_Admin);
            this.Controls.Add(this.ReqLabel);
            this.Movable = false;
            this.Name = "TechnicalReq";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Technical Request";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.TechnicalReq_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox RequestTextBox_Admin;
        private System.Windows.Forms.Label ReqLabel;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}