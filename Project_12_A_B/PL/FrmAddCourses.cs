using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;
using Project_12_A_B.PL;

namespace Project_Sce.PL
{
    public partial class FrmAddCourses : Form
    {
        CodeLayer.Course c = new CodeLayer.Course();
        private Project_12_A_B.PL.FormCourses parent;

        public FrmAddCourses()
        {
            InitializeComponent();
        }

        public FrmAddCourses(Project_12_A_B.PL.FormCourses parent_)
        {
            this.parent = parent_;
            InitializeComponent();
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {

            this.Close();
            Thread th = new Thread(GoBack);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
       
        private void label8_Click(object sender, EventArgs e){}

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(Login);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            bool ans;
            if (c.Verify_CourseID(this.textBoxCourseId.Text).Rows.Count == 0)
            {
                try {
                    ans = c.Add_Course(this.textBoxCourseId.Text, CourseName.Text, Convert.ToInt32(HoursPerWk.Text), (float)Convert.ToDouble(Points.Text), Category.Text, Convert.ToBoolean(pract.Checked), Convert.ToBoolean(lab.Checked), textBox1.Text);
                    if (ans == true)
                    {
                        MessageBox.Show("The course was successfully added to the database!", "Adding Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CourseName.Text = "";
                        Points.Text = "";
                        HoursPerWk.Text = "";
                        Category.Text = "";
                        pract.Text = "";
                        lab.Text = "";
                        textBox1.Text = "";
                        this.parent.RefreshDataSource();
                        this.Close();
                    }

                    else
                        MessageBox.Show("Invalid input, try again!", "Adding Course", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Empty fields error!", "Adding Course", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Course ID already exist!", "Adding Course", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void Login()
        {
            Application.Run(new LogIn());
        }

        private void GoBack()
        {
            Application.Run(new FormCourses());
        }
    }
}
