using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sce.PL
{
    public partial class FrmLessons : Form
    {
        public FrmLessons()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(AddLesson);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void AddLesson()
        {
            Application.Run(new FrmAddLesson());
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
            Application.Run(new Project_12_A_B.SecretaryFrm());
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoToLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void GoToLogin()
        {
            Application.Run(new LogIn());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoToDel);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void GoToDel()
        {
            Application.Run(new FrmDeleteLesson());
        }

        private void editLesson_click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(EditLesson);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void EditLesson()
        {
            Application.Run(new FrmEditLesson());
        }

        private void FrmLessons_Load(object sender, EventArgs e)
        {

        }
    }
}
