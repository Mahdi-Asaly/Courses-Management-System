using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_12_A_B.PL;
using Project_Sce.PL;
using System.Threading;
namespace Project_12_A_B
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;     
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            WelcomeLblAdmin.Text = "Welcome, "+Globals.LoggedUser.getName();
            WelcomeLblAdmin.BackColor = Color.Transparent;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////////////
            //Reset Status of user to be logged off.
            Globals.LoggedUser.setIsLogged("0");
            //Updating DB
            Globals.LoggedUser.saveData(Globals.LoggedUser.getId());
            ////////////////////////////////////////////////////////////
            //View login Panel
            this.Close();
            Thread th = new Thread(Login);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void Login()
        {
            Application.Run(new Project_Sce.PL.LogIn());
        }
        private void Admin_Load(object sender, EventArgs e)
        {

        }

        //Searches for a student by given ID.
        private void iDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForStudent a = new SearchForStudent();
            a.ShowDialog();
        }

        private void userByToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /*Add Announcement Method*/
        private void button1_Click(object sender, EventArgs e)
        {
            //View login Panel
            this.Close();
            Thread th = new Thread(AddAnnouncement);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void AddAnnouncement()
        {
            Application.Run(new AddAnnouncement());
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////////////
            //Reset Status of user to be logged off.
            //Globals.LoggedUser.setIsLogged("0");
            //Updating DB
            Globals.LoggedUser.saveData(Globals.LoggedUser.getId());
            ////////////////////////////////////////////////////////////
            //View login Panel
            this.Close();
            Thread th = new Thread(Login);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            //View login Panel
            this.Close();
            Thread th = new Thread(AddAnnouncement);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            SearchForStudent a = new SearchForStudent();
            a.ShowDialog();
        }

        private void MngSch_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("UnderConstruction :(");
            this.Close();
            Thread th = new Thread(GoStudentSchedule);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void GoStudentSchedule()
        {
            Application.Run(new EditStudentSchedule());
        }
        private void PermissionsBtn_Click(object sender, EventArgs e)
        {
            Permissions Go = new Permissions();
            Go.Show();

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void ManageProfiles_Click(object sender, EventArgs e)
        {
            EditStudentInfoSec Go = new EditStudentInfoSec();
            Go.ShowDialog();
        }

        private void TechBtn_Click(object sender, EventArgs e)
        {
            Project_12_A_B.Forms.Admin.TechnicalReq TR = new Forms.Admin.TechnicalReq();
            TR.ShowDialog();
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            SystemUsers su = new SystemUsers();
            su.ShowDialog();
        }

        private void RequestsBtn_Click(object sender, EventArgs e)
        {
            //this.Close();
            FrmStudentRequest sr = new FrmStudentRequest();
            sr.ShowDialog();
        }
    }
}
