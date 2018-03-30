using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace Project_Sce.PL
{
    public partial class FrmLecturer : Form
    {
        public string user, pass;

        public FrmLecturer()
        {
            InitializeComponent();
        }

        public FrmLecturer(string USER, string PASS)
        {
            InitializeComponent();
            this.user = USER;
            this.pass = PASS;
        }

        private void Schedulebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoToSchedule);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void GoToSchedule()
        {
            Application.Run(new FrmViewSchedule(user,pass));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Development");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Development");
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(HomePage);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
        public void HomePage()
        {
            Application.Run(new LogIn());
        }
        private void FrmLecturer_Load(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoUpdateForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void buttonCourses_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoCoursesForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void GoCoursesForm()
        {
            Project_12_A_B.PL.FormCourses form = new Project_12_A_B.PL.FormCourses();
            form.Permission = 5;
            Application.Run(form);
        }

        private void GoUpdateForm()
        {
            FormUpdateLecturerBySelf form = new FormUpdateLecturerBySelf(this);
            Application.Run(form);
        }

        private void GoLecturersForm()
        {
            Project_12_A_B.PL.FormLecturers form = new Project_12_A_B.PL.FormLecturers();
            form.Permission = 5;
            Application.Run(form);
        }

        private void GoConstraintForm()
        {
            Project_12_A_B.PL.FormLecturerConstraint form = new Project_12_A_B.PL.FormLecturerConstraint(this.user);
            Application.Run(form);
        }

        private void buttonLecturers_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoLecturersForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void buttonConstraints_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoConstraintForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
       

        public void UpdateLecture()
        {
            //Application.Run(new UpdateLecturerInfo(user,pass));
        }

    }
}
