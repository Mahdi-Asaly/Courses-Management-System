using Project_Sce.CodeLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_12_A_B.PL
{
    public partial class FormUpdateCourseBySecretary : Form
    {
        private FormCourses parent;

        public TextBox IDTextBox
        {
            get { return this.textBoxID; }
            set { this.textBoxID = value; }
        }

        public TextBox NameTextBox
        {
            get { return this.nameTextBox; }
            set { this.nameTextBox = value; }
        }

        public TextBox PointTextBox
        {
            get { return this.pointTextBox; }
            set { this.pointTextBox = value; }
        }

        public TextBox CategoryTextBox
        {
            get { return this.categoryTextBox; }
            set { this.categoryTextBox = value; }
        }

        public TextBox HoursPerWkTextBox
        {
            get { return this.hoursPerWkTextBox; }
            set { this.hoursPerWkTextBox = value; }
        }

        public TextBox SemesterTextBox
        {
            get { return this.semesterTextBox; }
            set { this.semesterTextBox = value; }
        }

        public TextBox YearTextBox
        {
            get { return this.yearTextBox; }
            set { this.yearTextBox = value; }
        }

        public CheckBox LabCheckBox
        {
            get { return this.labCheckBox; }
            set { this.labCheckBox = value; }
        }

        public CheckBox PractitionCheckBox
        {
            get { return this.practitionCheckBox; }
            set { this.practitionCheckBox = value; }
        }

        public CheckBox RegisterOptionCheckBox
        {
            get { return this.registerOptionCheckBox; }
            set { this.registerOptionCheckBox = value; }
        }

        public FormUpdateCourseBySecretary()
        {
            InitializeComponent();
        }

        public FormUpdateCourseBySecretary(FormCourses parent_)
        {
            this.parent = parent_;
            InitializeComponent();
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pointTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pointLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void practitionCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            CodeLayer.Handler h = new CodeLayer.Handler();
            Course cours = new Project_Sce.CodeLayer.Course(this.textBoxID.Text, this.nameTextBox.Text, Convert.ToInt32(this.hoursPerWkTextBox.Text), (float)Convert.ToDouble(this.pointTextBox.Text), this.categoryTextBox.Text, this.practitionCheckBox.Checked, this.labCheckBox.Checked, this.semesterTextBox.Text, Convert.ToInt32(this.yearTextBox.Text), this.registerOptionCheckBox.Checked);

            //Insert into DataBase Coursees table
            if (h.Update<Course>(cours))
            {
                MessageBox.Show("The cours ID " + cours.ID + " was successful updated.");
                this.parent.RefreshDataSource();
                this.Close();
            }
            else
            {
                MessageBox.Show("An error accrued when updating this cours, please try again.");
            }
        }
    }
}
