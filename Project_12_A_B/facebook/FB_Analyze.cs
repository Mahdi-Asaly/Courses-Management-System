namespace FB_AnalyzeD // Remove .Controller
{
    using System;
    using System.Data;
    using System.Windows.Forms;
    using Facebook;
    using Facebook.MiniJSON;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Threading;
    //using PRPJECT4NEW;
    //using PRPJECT4NEW.Forms;

    public partial class FB_Analyze : Form
    {
        private const string AppId = "1877745542481124";
        private const string ExtendedPermissions = "email";
        private string _accessToken;
        FacebookClient fbClient = new FacebookClient();
        string permission;
        int perm;
        string phl = "Login", php = "Password";
        string id, pwd;
        string name, Email, Semester, Address;

        public FB_Analyze()
        {
            InitializeComponent();
        }

        private void btnFacebookLogin_Click(object sender, EventArgs e)
        {
            var fbLoginDialog = new FB_LoginDialog(AppId, ExtendedPermissions);
            fbLoginDialog.ShowDialog();
            DisplayAppropriateMessage(fbLoginDialog.FacebookOAuthResult);
        }

        private void DisplayAppropriateMessage(FacebookOAuthResult facebookOAuthResult)
        {

            if (facebookOAuthResult != null)
            {
                if (facebookOAuthResult.IsSuccess)
                {
                    _accessToken = facebookOAuthResult.AccessToken;
                    var fb = new FacebookClient(facebookOAuthResult.AccessToken);

                    //var result = fb.Get("me", new { fields = new[] { "first_name", "last_name", "name", "gender", "id", "age_range" } });
                    var cl = fb;
                    dynamic result1 = fb.Get("me?fields=id,name,email");


                    SqlCommand cmd = new SqlCommand("select * from Login where id='" + result1.id + "'", Project_12_A_B.Globals.conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read() == true)
                    {

                        //getting the information from database.
                        permission = dr[3].ToString(); //getting the field of User : Student/Admin/..
                        id = dr[0].ToString();
                        name = dr[1].ToString();
                        //Student Fields
                        pwd = dr[2].ToString();
                        Email = dr[5].ToString();
                        Semester = dr[6].ToString();
                        Address = dr[7].ToString();
                        dr.Close();

                        ///////////////////////////////////
                        //Updating the Instance fields.
                        Project_12_A_B.Globals.LoggedUser = new Project_12_A_B.Classes.Student(Project_12_A_B.Globals.LoggedUser);

                        Project_12_A_B.Globals.LoggedUser.setName(name);
                        Project_12_A_B.Globals.LoggedUser.setPerm(permission);
                        Project_12_A_B.Globals.LoggedUser.setId(id);
                        Project_12_A_B.Globals.LoggedUser.setPwd(pwd);
                        Project_12_A_B.Globals.LoggedUser.setAddress(Address);
                        Project_12_A_B.Globals.LoggedUser.setMail(Email);
                        Project_12_A_B.Globals.LoggedUser.setSemester(Semester);

                        /////////////////////////////////
                        this.Close();
                        Thread th = new Thread(OpenStudentPortal);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                    else
                    {
                        //adding to database the user system as new student:-
                        Project_12_A_B.Globals.LoggedUser = new Project_12_A_B.Classes.Student(Project_12_A_B.Globals.LoggedUser);

                        Project_12_A_B.Globals.LoggedUser.setName(result1.name);
                        Project_12_A_B.Globals.LoggedUser.setPerm("0");
                        Project_12_A_B.Globals.LoggedUser.setId(result1.id);
                        Project_12_A_B.Globals.LoggedUser.setPwd("stampassword");
                        Project_12_A_B.Globals.LoggedUser.setSemester("1");


                        SqlCommand cs = new SqlCommand("INSERT INTO Login (Id, Name, Password, Permission, isLogged, Semester, FaceBookID) VALUES (@Id, @Name, @Password, @Permission, @isLogged, @Semester, @FaceBookID)", Project_12_A_B.Globals.conn);
                        cs.Parameters.AddWithValue("@Id", Convert.ToInt64(result1.id));
                        cs.Parameters.AddWithValue("@Name", result1.name);
                        cs.Parameters.AddWithValue("@Password", "stampassword");
                        cs.Parameters.AddWithValue("@isLogged", "0");
                        cs.Parameters.AddWithValue("@Permission","0");
                        cs.Parameters.AddWithValue("@Semester", "1");
                        String id = result1.id;
                        cs.Parameters.AddWithValue("@FaceBookID", id.Replace(" ",""));

                        //cs.Parameters.AddWithValue("@FaceBookID", result1.id);
                        dr.Close();
                        cs.ExecuteNonQuery();
                        
                        MessageBox.Show("Added user:" + this.name + " to the database with FaceBook id:" + result1.id);
                        //this.Close();
                        Thread th = new Thread(OpenStudentPortal);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }          
                    btnLogout.Visible = true;

                }
                else
                {
                    MessageBox.Show(facebookOAuthResult.ErrorDescription);
                }
            }
        }
        private void OpenStudentPortal()
        {
            
            Application.Run(new Project_12_A_B.StudentPortalForm());

        }
        private void ConnectToSql(SqlConnection sqlConnection, object sqlcon)
        {
            throw new NotImplementedException();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var webBrowser = new WebBrowser();
            var fb = new FacebookClient();
            var logouUrl = fb.GetLogoutUrl(new { access_token = _accessToken, next = "https://www.facebook.com/connect/login_success.html" });
            webBrowser.Navigate(logouUrl);
            btnLogout.Visible = false;
        }

        private void FB_Analyze_Load(object sender, EventArgs e)
        {

        }
    }
}
