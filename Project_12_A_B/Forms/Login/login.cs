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
using Facebook;

namespace Project_12_A_B
{
    public partial class login : MetroForm
    {

        //facebook
        private const string AppId = "239010066477815";
        private const string ExtendedPermissions = "public_profile,user_friends,email";
        private string _accessToken;
        //private Uri loginUrl;
        FacebookClient fbClient = new FacebookClient();
        //private bool _authorized;
        //private string _currentName;
        //private string _currentEmail;
        //Analyze fbAnalyze;




        public login()
        {
            //Globals.loggin_user = new User();

            InitializeComponent();
            this.BringToFront();
            this.Activate();
            pictureBox2.BackColor = Color.Transparent;
            LoginLbl.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*This method Invoke the button login when user press enter*/
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoginBtn_Click(sender, e);
        }
        /*This method Invoke the button login when user press enter*/

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                LoginBtn_Click(sender, e);

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome,\n- Enter your ID and password to gain access\nSecretary: UserName:123456 Pass:1234\nAnother Users: UserName:123 Pass:1234 \nUserName:12345678 Pass:1234", "Help");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.conn.Close(); //closing the connections.
            this.Close();
        }

        private void visitUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://sce.ac.il");//Redirection to website
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        void GoSch()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(20);
            }
        }

        private void passwordtext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoginBtn_Click(sender, e);
        }

        private void OpenStudentPortal()
        {
            Application.Run(new StudentPortalForm());

        }
        private void OpenSecretaryPortal()
        {
            Application.Run(new SecretaryFrm());

        }
        private void GoTechnical()
        {
            Application.Run(new Technical());
        }
        private void GoAdmin()
        {
            Application.Run(new Admin());
        }
        private void nametext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoginBtn_Click(sender, e);
        }

        private void passwordtext_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            int permission2, count = 0;
            String Address, Semester, Email;
            Address = Semester = Email = "";

            string permission, name, id, pass, islogged;//, Email,Semester,Address;
            islogged = "0";
            name = pass = permission = id = null;
            try
            {
                if (!(IdText.Text == string.Empty))
                {
                    if (!(passwordtext.Text == string.Empty))
                    {

                        String query = "select * from Login where Id = '" + IdText.Text + "'and Password = '" + this.passwordtext.Text + "'";
                        StringBuilder sb = new StringBuilder();
                        using (SqlCommand q = new SqlCommand(query, Globals.conn))
                        {
                            using (SqlDataReader dr = q.ExecuteReader())
                            {
                                if (!dr.HasRows)
                                {
                                    //MessageBox.Show("No Such this username or password!", "ERROR", MessageBoxButtons.OK);
                                    ErrorLbl.Visible = true;
                                    return;
                                }
                                ErrorLbl.Visible = false;
                                while (dr.Read())
                                {
                                    //getting the information from database.
                                    permission = dr[3].ToString(); //getting the field of User : Student/Admin/..
                                    id = dr[0].ToString();
                                    name = dr[1].ToString();
                                    pass = dr[2].ToString();
                                    islogged = dr[4].ToString();
                                    //Student Fields
                                    Email = dr[5].ToString();
                                    Semester = dr[6].ToString();
                                    Address = dr[7].ToString();
                                    ///////////////////////////////////
                                    //Updating the Instance fields.
                                    Globals.LoggedUser.setName(name);
                                    Globals.LoggedUser.setPerm(permission);
                                    Globals.LoggedUser.setId(id);
                                    Globals.LoggedUser.setPwd(pass);
                                    Globals.LoggedUser.setIsLogged(islogged);

                                    //////////////////////////////////
                                    count = count + 1;
                                }
                            }
                        }
                        /*Check If Another user already logged*/
                        if (Int32.Parse(Globals.LoggedUser.getisLogged()) == 1)
                        {
                            MessageBox.Show("ERROR: This account is already logged in.");
                            return;
                        }
                        //dbr.Close(); //closing Reader
                        //Globals.LoggedUser.setIsLogged("1"); //to prevent dual-login.
                        //Globals.LoggedUser.saveData(id); //updating the database.
                        permission2 = Int32.Parse(permission); //converting to int , to check field.

                        //Loading Screen
                        using (var Wait = new Project_12_A_B.Loading(GoSch))
                        {
                            Wait.ShowDialog(this);
                        }
                        if (count == 1)
                        {

                            if (permission2 == 0)
                            {
                                Globals.LoggedUser = new User();
                                Globals.LoggedUser = new Classes.Student(Globals.LoggedUser);

                                Globals.LoggedUser.setName(name);
                                Globals.LoggedUser.setPerm(permission);
                                Globals.LoggedUser.setId(id);
                                Globals.LoggedUser.setPwd(pass);
                                Globals.LoggedUser.setIsLogged(islogged);
                                //Student fields

                                (Globals.LoggedUser as Classes.Student).setAddress(Address);
                                (Globals.LoggedUser as Classes.Student).setSemester(Semester);
                                (Globals.LoggedUser as Classes.Student).setMail(Email);
                                //View Student Panel
                                this.Close();
                                Thread th = new Thread(OpenStudentPortal);
                                th.SetApartmentState(ApartmentState.STA);
                                th.Start();
                            }
                            if (permission2 == 1)
                            {
                                Globals.GlobalSecretary.setName(name);
                                Globals.GlobalSecretary.setPerm(permission);
                                Globals.GlobalSecretary.setId(id);
                                Globals.GlobalSecretary.setPwd(pass);
                                Globals.GlobalSecretary.setIsLogged(islogged);
                                //View Student Panel
                                this.Close();
                                Thread th = new Thread(OpenSecretaryPortal);
                                th.SetApartmentState(ApartmentState.STA);
                                th.Start();

                            }
                            if (permission2 == 2)
                            {
                                Globals.GlobalAdmin.setName(name);
                                Globals.GlobalAdmin.setPerm(permission);
                                Globals.GlobalAdmin.setId(id);
                                Globals.GlobalAdmin.setPwd(pass);
                                Globals.GlobalAdmin.setIsLogged(islogged);

                                //View Student Panel
                                this.Close();
                                Thread th = new Thread(GoAdmin);
                                th.SetApartmentState(ApartmentState.STA);
                                th.Start();

                            }
                            if (permission2 == 3)
                            {
                                Globals.GlobalTechnican.setName(name);
                                Globals.GlobalTechnican.setPerm(permission);
                                Globals.GlobalTechnican.setId(id);
                                Globals.GlobalTechnican.setPwd(pass);
                                Globals.GlobalTechnican.setIsLogged(islogged);
                                //View Student Panel
                                this.Close();
                                Thread th = new Thread(GoTechnical);
                                th.SetApartmentState(ApartmentState.STA);
                                th.Start();
                            }

                        }
                        else if (count > 1)
                        {
                            MessageBox.Show("Duplicate username and password", "login page");

                        }
                        else
                        {
                            MessageBox.Show("Username and password are incorrect", "login page");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Password is Empty!", "login page");

                    }
                }

                else
                {
                    MessageBox.Show("UserName is Empty!", "login page");
                }

            }
            catch
            {
                MessageBox.Show("UnExcpected Exception, ask owner to fix!!", "ERROR", MessageBoxButtons.OK);

            }
        }
        /// <summary>
        /// accessing via FACEBOOK , note that all the below code is related only to FACEBOOK.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            /*this.Close();
            Thread th = new Thread(LogViaFB);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();*/
            //var fbLoginDialog = new FB_LoginDialog(AppId, ExtendedPermissions);
            //fbLoginDialog.ShowDialog();

            //DisplayAppropriateMessage(fbLoginDialog.FacebookOAuthResult);
        }
       /* private void DisplayAppropriateMessage(FacebookOAuthResult facebookOAuthResult)
        {
            if (facebookOAuthResult != null)
            {
                if (facebookOAuthResult.IsSuccess)
                {
                    _accessToken = facebookOAuthResult.AccessToken;
                    var fb = new FacebookClient(facebookOAuthResult.AccessToken);

                    fbAnalyze = new Analyze(fb);
                    fbAnalyze.Show();
                }
                else
                {
                    MessageBox.Show(facebookOAuthResult.ErrorDescription);
                }
            }
        }*/

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
