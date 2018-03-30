using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Project_12_A_B.Forms.Student;
using System.Threading;
namespace Project_12_A_B
{
    public partial class StudentPortalForm : MetroForm
    {
        public StudentPortalForm()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
        }

        private void StudentPortalForm_Load(object sender, EventArgs e)
        {
        }

        private void GotoStudentForm_btn_Click(object sender, EventArgs e)
        {      
            this.Close();
            Thread th = new Thread(GoToStudent);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void GoToStudent()
        {
            Application.Run(new Student());
        }
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////////////
            //Reset Status of user to be unLogged in.
            //Globals.LoggedUser.setIsLogged("0");
            ////Updating DB
            //Globals.LoggedUser.saveData(Globals.LoggedUser.getId());
            ////////////////////////////////////////////////////////////

            //Back to login
            /*this.Hide();
            login sistema = new login();
            sistema.ShowDialog();
            this.Close();*/
            //Globals.conn.Close(); //closing the connections.
            this.Close();
            Thread th = new Thread(GoToLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void GoToLogin()
        {
            Application.Run(new Project_Sce.PL.LogIn());
        }
        private void info_btn_Click(object sender, EventArgs e)
        {
            //UpdateInfo a = new UpdateInfo();`
            //a.Show();
            PersonalInfoStudent a = new PersonalInfoStudent();
            a.Show();
        }

        private void warpper_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
