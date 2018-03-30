using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Sce.CodeLayer;
using System.Threading;
using Project_Sce.PL;
using System.Data.SqlClient;
using Facebook;
using Facebook.MiniJSON;
using FB_AnalyzeD;

namespace Project_12_A_B.PL.Login
{
    public partial class ModuleLogin : Modules.FadeControl
    {
        private static ModuleLogin instance_;
        Cls_Login log = new Cls_Login();
        string permission;
        int perm;
        string phl = "Login", php = "Password";
        string id, passowrd;
        string name, Email, Semester, Address;

        //facebook
        //private const string AppId = "239010066477815";
        //private const string ExtendedPermissions = "public_profile,user_friends,email";
        //private string _accessToken;
        FacebookClient fbClient = new FacebookClient();
        Analyze fbAnalyze;

        private const string AppId = "1877745542481124";
        private const string ExtendedPermissions = "email";
        private string _accessToken;


        public static ModuleLogin Instance
        {
            get
            {
                if(instance_ == null)
                {
                    instance_ = new ModuleLogin();
                }
                return instance_;
            }
        }
        public ModuleLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((LogIn)this.TopLevelControl).SetPanelModuleForgot();
        }

        private void ModuleLogin_Load(object sender, EventArgs e)
        {
            textBox1.GotFocus += RemoveTextBox1;
            textBox1.LostFocus += AddTextBox1;
            textBox1.Text = phl;

            textBox2.GotFocus += RemoveTextBox2;
            textBox2.LostFocus += AddTextBox2;
            textBox2.Text = php;

            this.pictureBox4.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
        }

        public void RemoveTextBox1(object sender, EventArgs e)
        {
            if (textBox1.Text == phl)
                textBox1.Text = "";
        }

        public void AddTextBox1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = phl;
            }
        }

        public void RemoveTextBox2(object sender, EventArgs e)
        {
            if (textBox2.Text == php)
                textBox2.Text = "";
        }

        public void AddTextBox2(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = php;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {




            DataTable dt = log.Login(this.textBox1.Text, this.textBox2.Text);

            if (dt.Rows.Count > 0)
            {
                this.id = this.textBox1.Text;
                this.passowrd = this.textBox2.Text;



                permission = dt.Rows[0][3].ToString();
                perm = Int32.Parse(permission);
                //Globals.LoggedUser.setName(name);
                Globals.LoggedUser.setPerm(permission);
                Globals.LoggedUser.setId(id);
                Globals.LoggedUser.setPwd(this.passowrd);
                //Branch B
                String query = "select * from Login where Id = '" + this.id.ToString() + "'and Password = '" + this.passowrd.ToString() + "'";
                StringBuilder sb = new StringBuilder();
                using (SqlCommand q = new SqlCommand(query, Globals.conn))
                {
                    using (SqlDataReader dr = q.ExecuteReader())
                    {
                        if (!dr.HasRows)
                        {
                            //MessageBox.Show("No Such this username or password!", "ERROR", MessageBoxButtons.OK);
                            return;
                        }
                        while (dr.Read())
                        {
                            //getting the information from database.
                            permission = dr[3].ToString(); //getting the field of User : Student/Admin/..
                            id = dr[0].ToString();
                            name = dr[1].ToString();
                            //Student Fields
                            Email = dr[5].ToString();
                            Semester = dr[6].ToString();
                            Address = dr[7].ToString();
                            ///////////////////////////////////
                            //Updating the Instance fields.
                            Globals.LoggedUser.setName(name);
                            Globals.LoggedUser.setPerm(permission);
                            Globals.LoggedUser.setId(id);
                            Globals.LoggedUser.setPwd(this.passowrd);
                        
                            //////////////////////////////////
                        }
                    }
                }




                if (perm == 0)
                {
                    //Globals.LoggedUser = new User();
                    Globals.LoggedUser = new Classes.Student(Globals.LoggedUser);

                    Globals.LoggedUser.setName(name);
                    Globals.LoggedUser.setPerm(permission);
                    Globals.LoggedUser.setId(id);
                    Globals.LoggedUser.setPwd(this.passowrd);
                    //Student fields

                    (Globals.LoggedUser as Classes.Student).setAddress(Address);
                    (Globals.LoggedUser as Classes.Student).setSemester(Semester);
                    (Globals.LoggedUser as Classes.Student).setMail(Email);

                    ////////////////................///////////////////
                    ((Form)this.TopLevelControl).Close();
                    Thread th = new Thread(OpenStudentPortal);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                if (perm == 1)
                {
                    //BranchB
                    Globals.GlobalSecretary.setName(name);
                    Globals.GlobalSecretary.setPerm(permission);
                    Globals.GlobalSecretary.setId(id);
                    Globals.GlobalSecretary.setPwd(this.passowrd);
                    /////

                    ((Form)this.TopLevelControl).Close();
                    Thread th = new Thread(OpenSecretaryPortal);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                if (perm == 2)
                {
                    //BranchB
                    Globals.GlobalAdmin.setName(name);
                    Globals.GlobalAdmin.setPerm(permission);
                    Globals.GlobalAdmin.setId(id);
                    Globals.GlobalAdmin.setPwd(this.passowrd);
                    //
                    ((Form)this.TopLevelControl).Close();
                    Thread th = new Thread(OpenPageAdmin);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                if (perm == 3)
                {
                    //BranchB Tech
                    Globals.GlobalTechnican.setName(name);
                    Globals.GlobalTechnican.setPerm(permission);
                    Globals.GlobalTechnican.setId(id);
                    Globals.GlobalTechnican.setPwd(this.passowrd);
                    //
                    ((Form)this.TopLevelControl).Close();
                    Thread th = new Thread(GoTechnical);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                //if (perm == 4)
                //{
                //    ((Form)this.TopLevelControl).Close();
                //    Thread th = new Thread(OpenSecretary);
                //    th.SetApartmentState(ApartmentState.STA);
                //    th.Start();
                //}
                if (perm == 5)
                {
                    ((Form)this.TopLevelControl).Close();
                    Thread th = new Thread(OpenLect);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();

                }
                if (perm == 6)
                {
                    ((Form)this.TopLevelControl).Close();
                    Thread th = new Thread(OpenDirect);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }

            }
            else { MessageBox.Show("Login Failed", "login page", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void GoTechnical()
        {
            Application.Run(new Technical());
        }

        private void OpenSecretaryPortal()
        {
            Application.Run(new SecretaryFrm());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
            Thread th = new Thread(goFaceBook);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void DisplayAppropriateMessage(FacebookOAuthResult facebookOAuthResult)
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
        }
        
        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {

            this.pictureBox4.Image = Project_12_A_B.Properties.Resources.facebook_sign_in_button_hover;
            this.pictureBox4.Cursor = Cursors.Hand;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {

            this.pictureBox4.Image = Project_12_A_B.Properties.Resources.facebook_sign_in_button1;
            this.pictureBox4.Cursor = Cursors.Default;

        }

        private void OpenStudentPortal()
        {
            Application.Run(new StudentPortalForm());

        }
        private void goFaceBook()
        { 
            Application.Run(new FB_Analyze());

        }
        private void OpenDirect()
        {
            Application.Run(new Project_Sce.PL.DirectOfStud());
        }
        private void OpenLect()
        {
            Application.Run(new Project_Sce.PL.FrmLecturer(this.id, this.passowrd));
        }
        private void OpenSecretary()
        {
            Application.Run(new Project_Sce.PL.FrmSecretary());
        }

        private void OpenPageAdmin()
        {
            Application.Run(new Project_12_A_B.Admin());
        }
    }
}
