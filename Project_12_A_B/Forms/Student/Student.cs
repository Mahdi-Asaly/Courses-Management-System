using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework.Forms;
using System.Threading;
namespace Project_12_A_B
{
    public partial class Student : MetroForm
    {
        private User loggin_user;
        public Student()
        {
            InitializeComponent();
            Welcomelbl.Text = "Welcome " + Globals.LoggedUser.getName();
            //Transparents
            Welcomelbl.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            //Updating the Announcement Box.        
            String query = "select * from Announcements";
            SqlCommand cmd = new SqlCommand(query, Globals.conn);
            SqlDataReader dbr;
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                AnnouncementTextBox.Text = dbr[0].ToString();
            }
            AnnouncementTextBox.Font = new Font("Modern No. 20", 15, FontStyle.Bold);
            dbr.Close(); //Do not forget to close the connection everytime you using queries.
            /////////////////////////////////////
        }

        public Student(User loggin_user)
        {
            this.loggin_user = loggin_user;
        }
        private void LogOut_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////////////
            //Reset Status of user to be unLogged in.
            Globals.LoggedUser.setIsLogged("0");
            //Updating DB
            Globals.LoggedUser.saveData(Globals.LoggedUser.getId());
            ////////////////////////////////////////////////////////////
            this.Hide();
            login BackToLogin = new login();
            BackToLogin.ShowDialog();
            Globals.conn.Close(); //closing the connections.
            this.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Student_Load(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////////////
            //Reset Status of user to be unLogged in.
            //Globals.LoggedUser.setIsLogged("0");
            //Updating DB
            //Globals.LoggedUser.saveData(Globals.LoggedUser.getId());
            ////////////////////////////////////////////////////////////
            this.Close();
            Thread th = new Thread(StudentPortal);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            //Globals.conn.Close(); //closing the connections.
        }





        private void StudentPortal()
        {
            Application.Run(new StudentPortalForm());

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Schedule a = new Schedule();
            a.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        void GoSch()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(20);
            }
        }
        private void ScheduleBtn_Click(object sender, EventArgs e)
        {
            using (var Wait = new Project_12_A_B.Loading(GoSch))
            {
                Wait.ShowDialog(this);
            }
            this.Close();
            Thread th = new Thread(ScheduleOpen);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void ScheduleOpen()
        {

            Application.Run(new Schedule());
        }
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(Ann);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void Ann()
        {
            Application.Run(new Announcements());
        }

        private void YouTubeBtn_Click(object sender, EventArgs e)
        {
            YouTube showYoutube = new YouTube();
            showYoutube.ShowDialog();
            //this.Close();
            //Thread th = new Thread(OpenYoutubeForm);
            //th.SetApartmentState(ApartmentState.STA);
            //th.Start();

        }
        private void OpenYoutubeForm()
        {
            Application.Run(new YouTube());
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Project_12_A_B.Forms.Student.Requests ShowReqForm = new Project_12_A_B.Forms.Student.Requests();
            ShowReqForm.ShowDialog();
        }
        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoPortal);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void GoPortal()
        {
            Application.Run(new StudentPortalForm());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void nummsgs_Click(object sender, EventArgs e)
        {

        }
    }
}
