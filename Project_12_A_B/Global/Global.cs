using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12_A_B
{
    public static class Globals
    {

        /* VARS */
        public static string db_string = "server=mahdias.database.windows.net;database=ProjectSCE;UID=Mahdias;password=Aa123123;Timeout=15";

        //Sets the SqlConnection connection string object to connect
        //to the SQL Server database in which you created the sample
        //table.
        public static SqlConnection conn;

        /* OBJECTS */
        public static User LoggedUser { get; set; }
        public static Classes.SecretaryClass GlobalSecretary { get; set; }
        public static Classes.Student GlobalStudent { get; set; } 
        public static Classes.Admin GlobalAdmin { get; set; }
        public static Classes.Technican GlobalTechnican { get; set; }

        //added new.
        //public static User LoggedUser;

        public static int MinSem = 1;
        public static int MaxSem = 8;
        public static int minDay = 1;
        public static int MaxDay = 6;
        public static int StartHour = 8;
        public static int EndHour = 22;
        /* MAIN FORM */
        //public static logInForm App;
        public static login App;
        static Globals()
        {
            // reset stats
            //we are going later to add here more classes in same time.
            LoggedUser = new User();
            GlobalSecretary = new Classes.SecretaryClass();
            GlobalStudent = new Classes.Student();
            GlobalTechnican = new Classes.Technican();
            GlobalAdmin = new Classes.Admin();
            LoggedUser.setName("");
            LoggedUser.setPwd("");
            //loggin_user.setPerm("-1");
            LoggedUser.setId("");
            //loggin_user.setIsLogged("0");
            // set db object
            conn = new SqlConnection(Globals.db_string);

            conn.Open();

        }
    }
}
