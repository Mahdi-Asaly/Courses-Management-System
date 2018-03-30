namespace Project_12_A_B.PL
{
    partial class FormUpdateCourseBySecretary
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
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label hoursPerWkLabel;
            System.Windows.Forms.Label labLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label pointLabel;
            System.Windows.Forms.Label practitionLabel;
            System.Windows.Forms.Label registerOptionLabel;
            System.Windows.Forms.Label semesterLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label labelID;
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoursPerWkTextBox = new System.Windows.Forms.TextBox();
            this.labCheckBox = new System.Windows.Forms.CheckBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pointTextBox = new System.Windows.Forms.TextBox();
            this.practitionCheckBox = new System.Windows.Forms.CheckBox();
            this.registerOptionCheckBox = new System.Windows.Forms.CheckBox();
            this.semesterTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            categoryLabel = new System.Windows.Forms.Label();
            hoursPerWkLabel = new System.Windows.Forms.Label();
            labLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            pointLabel = new System.Windows.Forms.Label();
            practitionLabel = new System.Windows.Forms.Label();
            registerOptionLabel = new System.Windows.Forms.Label();
            semesterLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(77, 134);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(69, 17);
            categoryLabel.TabIndex = 1;
            categoryLabel.Text = "Category:";
            // 
            // hoursPerWkLabel
            // 
            hoursPerWkLabel.AutoSize = true;
            hoursPerWkLabel.Location = new System.Drawing.Point(77, 169);
            hoursPerWkLabel.Name = "hoursPerWkLabel";
            hoursPerWkLabel.Size = new System.Drawing.Size(100, 17);
            hoursPerWkLabel.TabIndex = 3;
            hoursPerWkLabel.Text = "Hours Per Wk:";
            // 
            // labLabel
            // 
            labLabel.AutoSize = true;
            labLabel.Location = new System.Drawing.Point(77, 277);
            labLabel.Name = "labLabel";
            labLabel.Size = new System.Drawing.Size(36, 17);
            labLabel.TabIndex = 7;
            labLabel.Text = "Lab:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(77, 60);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "Name:";
            nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // pointLabel
            // 
            pointLabel.AutoSize = true;
            pointLabel.Location = new System.Drawing.Point(77, 97);
            pointLabel.Name = "pointLabel";
            pointLabel.Size = new System.Drawing.Size(44, 17);
            pointLabel.TabIndex = 11;
            pointLabel.Text = "Point:";
            pointLabel.Click += new System.EventHandler(this.pointLabel_Click);
            // 
            // practitionLabel
            // 
            practitionLabel.AutoSize = true;
            practitionLabel.Location = new System.Drawing.Point(77, 314);
            practitionLabel.Name = "practitionLabel";
            practitionLabel.Size = new System.Drawing.Size(71, 17);
            practitionLabel.TabIndex = 13;
            practitionLabel.Text = "Practition:";
            // 
            // registerOptionLabel
            // 
            registerOptionLabel.AutoSize = true;
            registerOptionLabel.Location = new System.Drawing.Point(77, 351);
            registerOptionLabel.Name = "registerOptionLabel";
            registerOptionLabel.Size = new System.Drawing.Size(111, 17);
            registerOptionLabel.TabIndex = 15;
            registerOptionLabel.Text = "Register Option:";
            // 
            // semesterLabel
            // 
            semesterLabel.AutoSize = true;
            semesterLabel.Location = new System.Drawing.Point(77, 205);
            semesterLabel.Name = "semesterLabel";
            semesterLabel.Size = new System.Drawing.Size(72, 17);
            semesterLabel.TabIndex = 17;
            semesterLabel.Text = "Semester:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(77, 241);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(42, 17);
            yearLabel.TabIndex = 19;
            yearLabel.Text = "Year:";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new System.Drawing.Point(77, 23);
            labelID.Name = "labelID";
            labelID.Size = new System.Drawing.Size(25, 17);
            labelID.TabIndex = 23;
            labelID.Text = "ID:";
            labelID.Click += new System.EventHandler(this.label1_Click);
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(194, 131);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(314, 22);
            this.categoryTextBox.TabIndex = 2;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(Project_Sce.CodeLayer.Course);
            // 
            // hoursPerWkTextBox
            // 
            this.hoursPerWkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "HoursPerWk", true));
            this.hoursPerWkTextBox.Location = new System.Drawing.Point(194, 166);
            this.hoursPerWkTextBox.Name = "hoursPerWkTextBox";
            this.hoursPerWkTextBox.Size = new System.Drawing.Size(314, 22);
            this.hoursPerWkTextBox.TabIndex = 4;
            // 
            // labCheckBox
            // 
            this.labCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.courseBindingSource, "Lab", true));
            this.labCheckBox.Location = new System.Drawing.Point(194, 272);
            this.labCheckBox.Name = "labCheckBox";
            this.labCheckBox.Size = new System.Drawing.Size(314, 24);
            this.labCheckBox.TabIndex = 8;
            this.labCheckBox.Text = "Yes";
            this.labCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(194, 57);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(314, 22);
            this.nameTextBox.TabIndex = 10;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // pointTextBox
            // 
            this.pointTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "Point", true));
            this.pointTextBox.Location = new System.Drawing.Point(194, 94);
            this.pointTextBox.Name = "pointTextBox";
            this.pointTextBox.Size = new System.Drawing.Size(314, 22);
            this.pointTextBox.TabIndex = 12;
            this.pointTextBox.TextChanged += new System.EventHandler(this.pointTextBox_TextChanged);
            // 
            // practitionCheckBox
            // 
            this.practitionCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.courseBindingSource, "Practition", true));
            this.practitionCheckBox.Location = new System.Drawing.Point(194, 309);
            this.practitionCheckBox.Name = "practitionCheckBox";
            this.practitionCheckBox.Size = new System.Drawing.Size(314, 24);
            this.practitionCheckBox.TabIndex = 14;
            this.practitionCheckBox.Text = "Yes";
            this.practitionCheckBox.UseVisualStyleBackColor = true;
            this.practitionCheckBox.CheckedChanged += new System.EventHandler(this.practitionCheckBox_CheckedChanged);
            // 
            // registerOptionCheckBox
            // 
            this.registerOptionCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.courseBindingSource, "RegisterOption", true));
            this.registerOptionCheckBox.Location = new System.Drawing.Point(194, 346);
            this.registerOptionCheckBox.Name = "registerOptionCheckBox";
            this.registerOptionCheckBox.Size = new System.Drawing.Size(314, 24);
            this.registerOptionCheckBox.TabIndex = 16;
            this.registerOptionCheckBox.Text = "Yes";
            this.registerOptionCheckBox.UseVisualStyleBackColor = true;
            // 
            // semesterTextBox
            // 
            this.semesterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "Semester", true));
            this.semesterTextBox.Location = new System.Drawing.Point(194, 202);
            this.semesterTextBox.Name = "semesterTextBox";
            this.semesterTextBox.Size = new System.Drawing.Size(314, 22);
            this.semesterTextBox.TabIndex = 18;
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(194, 238);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(314, 22);
            this.yearTextBox.TabIndex = 20;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(80, 408);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(135, 49);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(221, 408);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(135, 49);
            this.buttonCancel.TabIndex = 22;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "Name", true));
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(194, 20);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(314, 22);
            this.textBoxID.TabIndex = 24;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // FormUpdateCourseBySecretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 480);
            this.Controls.Add(labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(hoursPerWkLabel);
            this.Controls.Add(this.hoursPerWkTextBox);
            this.Controls.Add(labLabel);
            this.Controls.Add(this.labCheckBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(pointLabel);
            this.Controls.Add(this.pointTextBox);
            this.Controls.Add(practitionLabel);
            this.Controls.Add(this.practitionCheckBox);
            this.Controls.Add(registerOptionLabel);
            this.Controls.Add(this.registerOptionCheckBox);
            this.Controls.Add(semesterLabel);
            this.Controls.Add(this.semesterTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Name = "FormUpdateCourseBySecretary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Course";
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox hoursPerWkTextBox;
        private System.Windows.Forms.CheckBox labCheckBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox pointTextBox;
        private System.Windows.Forms.CheckBox practitionCheckBox;
        private System.Windows.Forms.CheckBox registerOptionCheckBox;
        private System.Windows.Forms.TextBox semesterTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxID;
    }
}