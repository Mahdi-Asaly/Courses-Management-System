namespace Project_12_A_B.Forms.Technican
{
    partial class TechnicalRequests
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
            this.FixedBtn = new MetroFramework.Controls.MetroTile();
            this.markV = new System.Windows.Forms.PictureBox();
            this.DeleteBtn = new MetroFramework.Controls.MetroTile();
            this.BackBtn = new MetroFramework.Controls.MetroTile();
            this.backmark = new System.Windows.Forms.PictureBox();
            this.deletemark = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ReqsList = new System.Windows.Forms.ListView();
            this.IDField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubjectField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FixedBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markV)).BeginInit();
            this.BackBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backmark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletemark)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FixedBtn
            // 
            this.FixedBtn.Controls.Add(this.markV);
            this.FixedBtn.Location = new System.Drawing.Point(692, 118);
            this.FixedBtn.Name = "FixedBtn";
            this.FixedBtn.Size = new System.Drawing.Size(120, 69);
            this.FixedBtn.Style = MetroFramework.MetroColorStyle.Green;
            this.FixedBtn.TabIndex = 0;
            this.FixedBtn.Text = "Fixed";
            this.FixedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FixedBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.FixedBtn.Click += new System.EventHandler(this.FixedBtn_Click);
            // 
            // markV
            // 
            this.markV.Image = global::Project_12_A_B.Properties.Resources.ok;
            this.markV.Location = new System.Drawing.Point(46, 4);
            this.markV.Name = "markV";
            this.markV.Size = new System.Drawing.Size(72, 65);
            this.markV.TabIndex = 0;
            this.markV.TabStop = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(692, 198);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(120, 73);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.DeleteBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Controls.Add(this.backmark);
            this.BackBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackBtn.Location = new System.Drawing.Point(693, 277);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(117, 63);
            this.BackBtn.Style = MetroFramework.MetroColorStyle.Red;
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "BACK";
            this.BackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // backmark
            // 
            this.backmark.Image = global::Project_12_A_B.Properties.Resources.previous;
            this.backmark.Location = new System.Drawing.Point(45, 0);
            this.backmark.Name = "backmark";
            this.backmark.Size = new System.Drawing.Size(74, 60);
            this.backmark.TabIndex = 0;
            this.backmark.TabStop = false;
            this.backmark.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // deletemark
            // 
            this.deletemark.Image = global::Project_12_A_B.Properties.Resources.delete64;
            this.deletemark.Location = new System.Drawing.Point(738, 201);
            this.deletemark.Name = "deletemark";
            this.deletemark.Size = new System.Drawing.Size(74, 67);
            this.deletemark.TabIndex = 3;
            this.deletemark.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ReqsList);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 368);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(243, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Requests List";
            // 
            // ReqsList
            // 
            this.ReqsList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReqsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDField,
            this.SubjectField});
            this.ReqsList.FullRowSelect = true;
            this.ReqsList.GridLines = true;
            this.ReqsList.Location = new System.Drawing.Point(0, 0);
            this.ReqsList.Name = "ReqsList";
            this.ReqsList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReqsList.Size = new System.Drawing.Size(644, 368);
            this.ReqsList.TabIndex = 0;
            this.ReqsList.UseCompatibleStateImageBehavior = false;
            this.ReqsList.View = System.Windows.Forms.View.Details;
            // 
            // IDField
            // 
            this.IDField.Text = "ID";
            this.IDField.Width = 100;
            // 
            // SubjectField
            // 
            this.SubjectField.Text = "Subject";
            this.SubjectField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SubjectField.Width = 550;
            // 
            // TechnicalRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.BackBtn;
            this.ClientSize = new System.Drawing.Size(829, 445);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deletemark);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.FixedBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "TechnicalRequests";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.TechnicalRequests_Load);
            this.FixedBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.markV)).EndInit();
            this.BackBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backmark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletemark)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile FixedBtn;
        private MetroFramework.Controls.MetroTile DeleteBtn;
        private MetroFramework.Controls.MetroTile BackBtn;
        private System.Windows.Forms.PictureBox markV;
        private System.Windows.Forms.PictureBox deletemark;
        private System.Windows.Forms.PictureBox backmark;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ReqsList;
        private System.Windows.Forms.ColumnHeader IDField;
        private System.Windows.Forms.ColumnHeader SubjectField;
    }
}