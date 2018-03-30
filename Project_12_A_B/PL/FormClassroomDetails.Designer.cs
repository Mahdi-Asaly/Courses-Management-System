using Project_12_A_B;

namespace Project_12_A_B.PL
{
    partial class FormClassroomDetails
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
            System.Windows.Forms.Label computerLabel;
            System.Windows.Forms.Label projectorLabel;
            System.Windows.Forms.Label seatsNumLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelClassName = new System.Windows.Forms.Label();
            this.groupBoxLessons = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projectSCEDataSet1 = new Project_12_A_B.ProjectSCEDataSet1();
            this.getCorsesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_CorsesTableAdapter = new Project_12_A_B.ProjectSCEDataSet1TableAdapters.Get_CorsesTableAdapter();
            this.projectSCEDataSet2 = new Project_12_A_B.ProjectSCEDataSet2();
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonTableAdapter = new Project_12_A_B.ProjectSCEDataSet2TableAdapters.LessonTableAdapter();
            this.projectSCEDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.classroomNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strtTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.classroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelIsProjector = new System.Windows.Forms.Label();
            this.labelIsComputer = new System.Windows.Forms.Label();
            computerLabel = new System.Windows.Forms.Label();
            projectorLabel = new System.Windows.Forms.Label();
            seatsNumLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxLessons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectSCEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCorsesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectSCEDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectSCEDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // computerLabel
            // 
            computerLabel.AutoSize = true;
            computerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            computerLabel.Location = new System.Drawing.Point(295, 156);
            computerLabel.Name = "computerLabel";
            computerLabel.Size = new System.Drawing.Size(87, 20);
            computerLabel.TabIndex = 2;
            computerLabel.Text = "Computer:";
            // 
            // projectorLabel
            // 
            projectorLabel.AutoSize = true;
            projectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            projectorLabel.Location = new System.Drawing.Point(569, 156);
            projectorLabel.Name = "projectorLabel";
            projectorLabel.Size = new System.Drawing.Size(82, 20);
            projectorLabel.TabIndex = 6;
            projectorLabel.Text = "Projector:";
            // 
            // seatsNumLabel
            // 
            seatsNumLabel.AutoSize = true;
            seatsNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            seatsNumLabel.Location = new System.Drawing.Point(803, 156);
            seatsNumLabel.Name = "seatsNumLabel";
            seatsNumLabel.Size = new System.Drawing.Size(97, 20);
            seatsNumLabel.TabIndex = 8;
            seatsNumLabel.Text = "Seats Num:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.labelClassName);
            this.panel1.Location = new System.Drawing.Point(41, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 66);
            this.panel1.TabIndex = 0;
            // 
            // labelClassName
            // 
            this.labelClassName.AutoSize = true;
            this.labelClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassName.ForeColor = System.Drawing.Color.White;
            this.labelClassName.Location = new System.Drawing.Point(539, 19);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(144, 29);
            this.labelClassName.TabIndex = 0;
            this.labelClassName.Text = "Class Name";
            // 
            // groupBoxLessons
            // 
            this.groupBoxLessons.Controls.Add(this.dataGridView1);
            this.groupBoxLessons.Location = new System.Drawing.Point(41, 212);
            this.groupBoxLessons.Name = "groupBoxLessons";
            this.groupBoxLessons.Size = new System.Drawing.Size(1179, 449);
            this.groupBoxLessons.TabIndex = 10;
            this.groupBoxLessons.TabStop = false;
            this.groupBoxLessons.Text = "Lessons:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classroomNameDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn,
            this.strtTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lessonBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(25, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1129, 392);
            this.dataGridView1.TabIndex = 0;
            // 
            // projectSCEDataSet1
            // 
            this.projectSCEDataSet1.DataSetName = "ProjectSCEDataSet1";
            this.projectSCEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getCorsesBindingSource
            // 
            this.getCorsesBindingSource.DataMember = "Get_Corses";
            this.getCorsesBindingSource.DataSource = this.projectSCEDataSet1;
            // 
            // get_CorsesTableAdapter
            // 
            this.get_CorsesTableAdapter.ClearBeforeFill = true;
            // 
            // projectSCEDataSet2
            // 
            this.projectSCEDataSet2.DataSetName = "ProjectSCEDataSet2";
            this.projectSCEDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lessonBindingSource
            // 
            this.lessonBindingSource.DataMember = "Lesson";
            this.lessonBindingSource.DataSource = this.projectSCEDataSet2;
            // 
            // lessonTableAdapter
            // 
            this.lessonTableAdapter.ClearBeforeFill = true;
            // 
            // projectSCEDataSet1BindingSource
            // 
            this.projectSCEDataSet1BindingSource.DataSource = this.projectSCEDataSet1;
            this.projectSCEDataSet1BindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(906, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // classroomNameDataGridViewTextBoxColumn
            // 
            this.classroomNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.classroomNameDataGridViewTextBoxColumn.DataPropertyName = "ClassroomName";
            this.classroomNameDataGridViewTextBoxColumn.HeaderText = "ClassroomName";
            this.classroomNameDataGridViewTextBoxColumn.Name = "classroomNameDataGridViewTextBoxColumn";
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Day";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            // 
            // strtTimeDataGridViewTextBoxColumn
            // 
            this.strtTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.strtTimeDataGridViewTextBoxColumn.DataPropertyName = "StrtTime";
            this.strtTimeDataGridViewTextBoxColumn.HeaderText = "StrtTime";
            this.strtTimeDataGridViewTextBoxColumn.Name = "strtTimeDataGridViewTextBoxColumn";
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            // 
            // lessonBindingSource1
            // 
            this.lessonBindingSource1.DataSource = typeof(Project_Sce.CodeLayer.Lesson);
            // 
            // classroomBindingSource
            // 
            this.classroomBindingSource.DataSource = typeof(Project_Sce.CodeLayer.Classroom);
            // 
            // labelIsProjector
            // 
            this.labelIsProjector.AutoSize = true;
            this.labelIsProjector.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIsProjector.ForeColor = System.Drawing.Color.Red;
            this.labelIsProjector.Location = new System.Drawing.Point(657, 141);
            this.labelIsProjector.Name = "labelIsProjector";
            this.labelIsProjector.Size = new System.Drawing.Size(40, 39);
            this.labelIsProjector.TabIndex = 12;
            this.labelIsProjector.Text = "✘";
            // 
            // labelIsComputer
            // 
            this.labelIsComputer.AutoSize = true;
            this.labelIsComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIsComputer.ForeColor = System.Drawing.Color.Red;
            this.labelIsComputer.Location = new System.Drawing.Point(388, 141);
            this.labelIsComputer.Name = "labelIsComputer";
            this.labelIsComputer.Size = new System.Drawing.Size(40, 39);
            this.labelIsComputer.TabIndex = 13;
            this.labelIsComputer.Text = "✘";
            // 
            // FormClassroomDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.labelIsComputer);
            this.Controls.Add(this.labelIsProjector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxLessons);
            this.Controls.Add(computerLabel);
            this.Controls.Add(projectorLabel);
            this.Controls.Add(seatsNumLabel);
            this.Controls.Add(this.panel1);
            this.Name = "FormClassroomDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClassroomDetails";
            this.Load += new System.EventHandler(this.FormClassroomDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxLessons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectSCEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCorsesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectSCEDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectSCEDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classroomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelClassName;
        private System.Windows.Forms.BindingSource classroomBindingSource;
        private System.Windows.Forms.GroupBox groupBoxLessons;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectSCEDataSet1 projectSCEDataSet1;
        private System.Windows.Forms.BindingSource getCorsesBindingSource;
        private Project_12_A_B.ProjectSCEDataSet1TableAdapters.Get_CorsesTableAdapter get_CorsesTableAdapter;
        private ProjectSCEDataSet2 projectSCEDataSet2;
        private System.Windows.Forms.BindingSource lessonBindingSource;
        private Project_12_A_B.ProjectSCEDataSet2TableAdapters.LessonTableAdapter lessonTableAdapter;
        private System.Windows.Forms.BindingSource lessonBindingSource1;
        private System.Windows.Forms.BindingSource projectSCEDataSet1BindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classroomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strtTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelIsProjector;
        private System.Windows.Forms.Label labelIsComputer;
    }
}