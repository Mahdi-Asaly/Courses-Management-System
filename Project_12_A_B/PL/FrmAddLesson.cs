using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_12_A_B;

namespace Project_Sce.PL
{
    public partial class FrmAddLesson : Form
    {
        CodeLayer.Lesson l = new CodeLayer.Lesson();
        public FrmAddLesson()
        {
            InitializeComponent();
            course_cat.DataSource = l.get_courseID();
            course_cat.DisplayMember = "CourseID";
            course_cat.ValueMember = "CourseID";

        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            if (l.Verify_lecConstraint(Convert.ToString(lecturer_cat.SelectedValue), day_cat.Text, Convert.ToInt32(strt_cat.Text), Convert.ToInt32(end_cat.Text)).Rows.Count == 0)
            {
                l.Add_Lesson(category_cat.Text, Convert.ToString(class_cat.SelectedValue), Convert.ToString(course_cat.SelectedValue), Convert.ToString(lecturer_cat.SelectedValue), day_cat.Text, Convert.ToInt32(strt_cat.Text), Convert.ToInt32(end_cat.Text), 0);
                MessageBox.Show("The lesson was successfully added to the database!", "Adding lesson", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("The time you cose doesn't suit the lecturer's schedule, select another day/hours!", "Adding Lesson", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoBack);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void GoBack()
        {
            Application.Run(new FrmLessons());
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(Login);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Login()
        {
            Application.Run(new LogIn());
        }

        private void category_cat_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void SetClassroom()
        {
            if (this.strt_cat.SelectedIndex != -1 && this.end_cat.SelectedIndex != -1 && this.day_cat.SelectedIndex != -1)
            {
                if (Convert.ToString(category_cat.SelectedItem) == "Lecture")
                {
                    class_cat.DataSource = l.get_lecClassID(day_cat.Text, Convert.ToInt32(strt_cat.Text), Convert.ToInt32(end_cat.Text));
                    class_cat.DisplayMember = "name";
                    class_cat.ValueMember = "name";
                }
                else if (Convert.ToString(category_cat.SelectedItem) == "Practition Lesson")
                {
                    class_cat.DataSource = l.get_practClassID(day_cat.Text, Convert.ToInt32(strt_cat.Text), Convert.ToInt32(end_cat.Text));
                    class_cat.DisplayMember = "name";
                    class_cat.ValueMember = "name";
                }

                else
                {
                    class_cat.DataSource = l.get_labClassID(day_cat.Text, Convert.ToInt32(strt_cat.Text), Convert.ToInt32(end_cat.Text));
                    class_cat.DisplayMember = "name";
                    class_cat.ValueMember = "name";
                }
            }
        }

        private void end_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetClassroom();
            lecturer_cat.DataSource = l.get_lecID(day_cat.Text, Convert.ToInt32(strt_cat.Text), Convert.ToInt32(end_cat.Text));
            lecturer_cat.DisplayMember = "id";
            lecturer_cat.ValueMember = "id";
        }

        private void FrmAddLesson_Load(object sender, EventArgs e)
        {

        }

        private void strt_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetClassroom();
        }

        private void day_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetClassroom();
        }

        private void lecturer_cat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
