using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using Project_12_A_B.PL;

namespace Project_Sce.PL
{
    public partial class FrmDeleteCourses : Form
    {
        CodeLayer.Course c = new CodeLayer.Course();

        private Project_12_A_B.PL.FormCourses parent;

        public TextBox CourseIDBox_
        {
            get { return this.CourseIDBox; }
            set { this.CourseIDBox = value; }
        }

        public FrmDeleteCourses()
        {
            InitializeComponent();
        }

        public FrmDeleteCourses(Project_12_A_B.PL.FormCourses parent_)
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

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(Login);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void DeleteCoursebtn_Click(object sender, EventArgs e)
        {

            if (c.Delete_Course((CourseIDBox.Text)) == true)
            {
                MessageBox.Show("The course was successfully deleted from the database!", "Deleting Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.parent.RefreshDataSource();
                this.Close();
            }
            else
                MessageBox.Show("An error has occurred! Failed to delete course", "Deleting Course", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
        }

        public void GoBack()
        {
            Application.Run(new FormCourses());
        }

        public void Login()
        {
            Application.Run(new LogIn());
        }

        private void CourseIDBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
