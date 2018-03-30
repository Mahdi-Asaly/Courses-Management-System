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
using Project_12_A_B.PL;

namespace Project_Sce.PL
{
    public partial class FrmSecretary : Form
    {
        public FrmSecretary()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void FrmSecretary_Load(object sender, EventArgs e) { }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(HomePage);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Course_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoToCourse);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void HomePage()
        {
            Application.Run(new LogIn());
        }

        private void GoToCourse()
        {
            FormCourses form = new FormCourses();
            form.Permission = 4;
            Application.Run(form);
        }

       

        private void classroom_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoToClassrooms);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void GoToClassrooms()
        {
            Application.Run(new FormClasses());
        }

        private void lesson_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoToLessons);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void GoToLessons()
        {
            Application.Run(new FrmLessons());
        }

        private void GoStudentForm()
        {
            FormStudents form = new FormStudents();
            form.Permission = 4;
            Application.Run(form);
        }

        private void GoLecturerForm()
        {
            FormLecturers form = new FormLecturers();
            form.Permission = 4;
            Application.Run(form);
        }

        private void GoConstraintsForm()
        {
            FormConstraints form = new FormConstraints();
            form.Permission = 4;
            Application.Run(form);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoStudentForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void buttonLecturers_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoLecturerForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void buttonConstraints_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoConstraintsForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
