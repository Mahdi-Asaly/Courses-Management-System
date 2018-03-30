using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sce.PL
{
    public partial class updateLesson : Form
    {
        CodeLayer.Lesson l = new CodeLayer.Lesson();
        private string type, day, StrtTime, EndTime, classroom, LecturerID, id;
        public updateLesson(string type, string classroom, string LecturerID, string _day, string _StrtTime, string _EndTime, string id)
        {
            InitializeComponent();
            this.type = type;
            this.classroom = classroom;
            this.LecturerID = LecturerID;
            this.day = _day;
            this.StrtTime = _StrtTime;
            this.EndTime = _EndTime;
            this.id = id;
            this.setLecID();
            this.SetClassroom();
        }

        private void setLecID()
        {
            if (l.get_lecID(this.day, Convert.ToInt32(StrtTime), Convert.ToInt32(EndTime)).Rows.Count == 0)
            {
                lecturer_cat.Items.Add(LecturerID);
                lecturer_cat.Text = LecturerID;
            }
            else
            {
                lecturer_cat.DataSource = l.get_lecID(this.day, Convert.ToInt32(StrtTime), Convert.ToInt32(EndTime));
                lecturer_cat.DisplayMember = "id";
                lecturer_cat.ValueMember = "id";

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lecturer_cat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void class_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this.SetClassroom();
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            if (l.Verify_lecConstraint(Convert.ToString(lecturer_cat.SelectedValue), day, Convert.ToInt32(StrtTime), Convert.ToInt32(EndTime)).Rows.Count == 0)
            {
                l.Update_Lesson(Convert.ToString(class_cat.SelectedValue), Convert.ToString(lecturer_cat.SelectedValue), Convert.ToInt32(id));
                MessageBox.Show("The lesson was successfully updated in the database!", "Updating lesson", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("The lecturer you chose has constraints in this time, select another lecturer!", "Updating Lesson", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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

        private void updateLesson_Load(object sender, EventArgs e)
        {

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


        private void SetClassroom()
        {

            if (type == "Lecture")
            {
                if (l.get_lecClassID(day, Convert.ToInt32(StrtTime), Convert.ToInt32(EndTime)).Rows.Count == 0)
                {
                    class_cat.Items.Add(classroom);
                    class_cat.Text = classroom;
                }
                else
                {
                    class_cat.DataSource = l.get_lecClassID(day, Convert.ToInt32(StrtTime), Convert.ToInt32(EndTime));
                    class_cat.DisplayMember = "name";
                    class_cat.ValueMember = "name";
                }
            }
            else if (type == "Practition Lesson")
            {
                if (l.get_practClassID(day, Convert.ToInt32(StrtTime), Convert.ToInt32(EndTime)).Rows.Count == 0)
                {
                    class_cat.Items.Add(classroom);
                    class_cat.Text = classroom;
                }
                else
                {
                    class_cat.DataSource = l.get_practClassID(day, Convert.ToInt32(StrtTime), Convert.ToInt32(EndTime));
                    class_cat.DisplayMember = "name";
                    class_cat.ValueMember = "name";
                }
            }
            else
            {
                if (l.get_labClassID(day, Convert.ToInt32(StrtTime), Convert.ToInt32(EndTime)).Rows.Count == 0)
                {
                    class_cat.Items.Add(classroom);
                    class_cat.Text = classroom;
                }
                else
                {
                    class_cat.DataSource = l.get_labClassID(day, Convert.ToInt32(StrtTime), Convert.ToInt32(EndTime));
                    class_cat.DisplayMember = "name";
                    class_cat.ValueMember = "name";
                }
            }


        }
    }
}
