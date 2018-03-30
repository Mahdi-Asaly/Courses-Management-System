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
using System.Data.SqlClient;
using System.Threading;
namespace Project_12_A_B
{
    public partial class Technical : MetroForm
    {
        public Technical()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            //Updating the Announcement Box.
            WelcomeLabel.Text = "Welcome " + Globals.GlobalTechnican.getName();
            WelcomeLabel.BackColor = Color.Transparent;
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

        //logout button
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

        private void Technical_Load(object sender, EventArgs e)
        {

        }

        /*Contains the list of technical requests*/
        private void technicalRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TechnicalRequestsTable a = new TechnicalRequestsTable();
            a.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AnnouncementTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnnLbl_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

            /////////////////////////////////////////////////////////////
            //Reset Status of user to be unLogged in.
            //Globals.LoggedUser.setIsLogged("0");
            //Updating DB
            //Globals.LoggedUser.saveData(Globals.LoggedUser.getId());
            ////////////////////////////////////////////////////////////
            //Globals.conn.Close(); //closing the connections.
            //View Login
            this.Close();
            Thread th = new Thread(OpenLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenLogin()
        {
            Application.Run(new Project_Sce.PL.LogIn());
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {            
            Project_12_A_B.Forms.Technican.TechnicalRequests ReqList=new Project_12_A_B.Forms.Technican.TechnicalRequests();
            ReqList.ShowDialog();
        }

    }
}
