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
using Project_12_A_B.PL;
using Project_Sce.PL;

namespace Project_12_A_B
{
    public partial class SecretaryFrm : MetroForm
    {
        public SecretaryFrm()
        {
            InitializeComponent();
            WelcomeLabel.Text = "Welcome, " + Globals.LoggedUser.getName();
            WelcomeLabel.BackColor = Color.Transparent;
            NewsPic.BackColor = Color.Transparent;
            AnnoucementLbl.BackColor = Color.Transparent;

            //Updating the Announcement Box.

            String query = "select * from Announcements";
            SqlCommand cmd = new SqlCommand(query, Globals.conn);
            SqlDataReader dbr;
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
            AnnouncementBox.Text = dbr[0].ToString();
            }
            AnnouncementBox.Font = new Font("Modern No. 20", 15, FontStyle.Bold);
            dbr.Close(); //Do not forget to close the connection everytime you using queries.
            /////////////////////////////////////

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void Secretary_Load(object sender, EventArgs e)
        {
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForStudent a = new SearchForStudent();
            a.Show();

        }
        /*Button to back to the main*/
        private void button1_Click(object sender, EventArgs e)
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



        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Secretary_Load_1(object sender, EventArgs e)
        {

        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void iDToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SearchForStudent a = new SearchForStudent();
            a.Show();

        }

        private void menuStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        /*method to invoke search form*/
        private void iDToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SearchForStudent a = new SearchForStudent();
            a.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void Technical_Support_Button_Click(object sender, EventArgs e)
        {
            RequestTechSup_Secretary a = new RequestTechSup_Secretary();
            a.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void AddStudentSecretary_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("In Development Process!", "Under Development", MessageBoxButtons.OK);
        }

        private void RemoveStudentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Development Process!", "Under Development", MessageBoxButtons.OK);

        }

        private void SearchStudentButton_Click(object sender, EventArgs e)
        {
            SearchForStudent a = new SearchForStudent();
            a.Show();
        }

        /*Modify Personal Info of student button*/

        private void ModifyPersonalInfoStdntButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Development Process!", "Under Development", MessageBoxButtons.OK);

        }
        /*this button adds new announcement*/
        private void PostAnnButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(ShowAnnouncement);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void ShowAnnouncement()
        {
            Application.Run(new AddAnnouncement());
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(OpenLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenLogin()
        {
            Application.Run(new Project_Sce.PL.LogIn());
        }
        //enable registeration in courses.
        private void EnableRegisteration_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update Courses SET RegisterOption='1'", Globals.conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException v)
            {
                MessageBox.Show("Error Occured while submitting request reason:" + v, "ERROR", MessageBoxButtons.OK);
            }
            MessageBox.Show("You'v Enabled The registeration in Courses!");
        }
        //disable registeration in courses.
        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update Courses SET RegisterOption='0'", Globals.conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException v)
            {
                MessageBox.Show("Error Occured while submitting request reason:" + v, "ERROR", MessageBoxButtons.OK);
            }
            MessageBox.Show("You'v Disable The registeration in Courses!");
        }

        private void TechSupportBtn_Click(object sender, EventArgs e)
        {
            RequestTechSup_Secretary a = new RequestTechSup_Secretary();
            a.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoAnnouncement);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void GoAnnouncement()
        {
            Application.Run(new AddAnnouncement());
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction");
        }
        private void ModifyStudentBtn_Click(object sender, EventArgs e)
        {
            EditStudentInfoSec Go = new EditStudentInfoSec();
            Go.ShowDialog();
        }
        private void NewsPic_Click(object sender, EventArgs e)
        {

        }
        private void changeschedulebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoStudentSchedule);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void GoStudentSchedule()
        {
            Application.Run(new EditStudentSchedule());
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            SearchForStudent SearchS = new SearchForStudent();
            SearchS.ShowDialog();
        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoToCourse);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void GoToCourse()
        {
            Project_12_A_B.PL.FormClasses form = new Project_12_A_B.PL.FormClasses();
            form.Permission = 4;
            Application.Run(form);
        }
        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoStudentForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoLecturerForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void LessonBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoToLessons);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void ConstraintsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoConstraintsForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void ClassroomBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoToCourses);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void GoToCourses()
        {
            Application.Run(new FormCourses());
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
    }
}
