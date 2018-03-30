namespace Project_12_A_B.PL
{
    partial class FormLecturerConstraint
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dayLabel;
            System.Windows.Forms.Label fromHourLabel;
            System.Windows.Forms.Label lIDLabel;
            System.Windows.Forms.Label toHourLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxToHour = new System.Windows.Forms.ComboBox();
            this.constraintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxFromHour = new System.Windows.Forms.ComboBox();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.lIDTextBox = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            dayLabel = new System.Windows.Forms.Label();
            fromHourLabel = new System.Windows.Forms.Label();
            lIDLabel = new System.Windows.Forms.Label();
            toHourLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.constraintBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Location = new System.Drawing.Point(25, 50);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new System.Drawing.Size(37, 17);
            dayLabel.TabIndex = 14;
            dayLabel.Text = "Day:";
            // 
            // fromHourLabel
            // 
            fromHourLabel.AutoSize = true;
            fromHourLabel.Location = new System.Drawing.Point(25, 80);
            fromHourLabel.Name = "fromHourLabel";
            fromHourLabel.Size = new System.Drawing.Size(79, 17);
            fromHourLabel.TabIndex = 16;
            fromHourLabel.Text = "From Hour:";
            // 
            // lIDLabel
            // 
            lIDLabel.AutoSize = true;
            lIDLabel.Location = new System.Drawing.Point(25, 22);
            lIDLabel.Name = "lIDLabel";
            lIDLabel.Size = new System.Drawing.Size(33, 17);
            lIDLabel.TabIndex = 18;
            lIDLabel.Text = "LID:";
            // 
            // toHourLabel
            // 
            toHourLabel.AutoSize = true;
            toHourLabel.Location = new System.Drawing.Point(25, 110);
            toHourLabel.Name = "toHourLabel";
            toHourLabel.Size = new System.Drawing.Size(64, 17);
            toHourLabel.TabIndex = 20;
            toHourLabel.Text = "To Hour:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxToHour);
            this.panel1.Controls.Add(this.comboBoxFromHour);
            this.panel1.Controls.Add(dayLabel);
            this.panel1.Controls.Add(toHourLabel);
            this.panel1.Controls.Add(this.dayComboBox);
            this.panel1.Controls.Add(this.lIDTextBox);
            this.panel1.Controls.Add(fromHourLabel);
            this.panel1.Controls.Add(lIDLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 148);
            this.panel1.TabIndex = 11;
            // 
            // comboBoxToHour
            // 
            this.comboBoxToHour.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.constraintBindingSource, "Day", true));
            this.comboBoxToHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxToHour.FormattingEnabled = true;
            this.comboBoxToHour.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.comboBoxToHour.Location = new System.Drawing.Point(110, 107);
            this.comboBoxToHour.Name = "comboBoxToHour";
            this.comboBoxToHour.Size = new System.Drawing.Size(161, 24);
            this.comboBoxToHour.TabIndex = 22;
            // 
            // constraintBindingSource
            // 
            this.constraintBindingSource.DataSource = typeof(Project_Sce.CodeLayer.Constraint);
            // 
            // comboBoxFromHour
            // 
            this.comboBoxFromHour.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.constraintBindingSource, "Day", true));
            this.comboBoxFromHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFromHour.FormattingEnabled = true;
            this.comboBoxFromHour.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.comboBoxFromHour.Location = new System.Drawing.Point(110, 77);
            this.comboBoxFromHour.Name = "comboBoxFromHour";
            this.comboBoxFromHour.Size = new System.Drawing.Size(161, 24);
            this.comboBoxFromHour.TabIndex = 21;
            // 
            // dayComboBox
            // 
            this.dayComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.constraintBindingSource, "Day", true));
            this.dayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday"});
            this.dayComboBox.Location = new System.Drawing.Point(110, 47);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(161, 24);
            this.dayComboBox.TabIndex = 15;
            // 
            // lIDTextBox
            // 
            this.lIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.constraintBindingSource, "LID", true));
            this.lIDTextBox.Location = new System.Drawing.Point(110, 19);
            this.lIDTextBox.Name = "lIDTextBox";
            this.lIDTextBox.Size = new System.Drawing.Size(161, 22);
            this.lIDTextBox.TabIndex = 19;
            this.lIDTextBox.TextChanged += new System.EventHandler(this.lIDTextBox_TextChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(12, 176);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(306, 52);
            this.buttonSubmit.TabIndex = 12;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // FormLecturerConstraint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 239);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.panel1);
            this.Name = "FormLecturerConstraint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLecturerConstraint";
            this.Load += new System.EventHandler(this.FormLecturerConstraint_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.constraintBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource constraintBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox dayComboBox;
        private System.Windows.Forms.TextBox lIDTextBox;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ComboBox comboBoxToHour;
        private System.Windows.Forms.ComboBox comboBoxFromHour;
    }
}