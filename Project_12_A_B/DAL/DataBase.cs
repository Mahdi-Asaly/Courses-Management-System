using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using Project_12_A_B;

namespace Project_Sce.DAL
{
    class DataBase
    {
        SqlConnection con;
        private static DataBase instance;
        // This constructor Inisialize the connection object
        public DataBase() 
            {
            con = new SqlConnection(@"Data Source=mahdias.database.windows.net;Initial Catalog=ProjectSCE;User ID=Mahdias;Password=Aa123123;Timeout=15");
            }

        public static DataBase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataBase();
                }
                else
                {
                    //MessageBox.Show("An instance already exist!");
                }
                return instance;
            }
        }

        public SqlConnection Con
        {
            get { return this.con; }
            set { this.con = value; }
        }

        // open the connection
        public void open()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
       // close connection 
       public void close()
        {
            if(con.State!=ConnectionState.Closed)
            {
                con.Close();
            }
        }

        public bool OpenConnection()
        {
            //added new condition to prevent crash
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return true;
        }

        public bool CloseConnection()
        {
            
            con.Close();
            return true;
        }

        // Method to read data from DataBase
        public DataTable SelectData(string stored,SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored;
            cmd.Connection = con;
            if(param!=null)
            {
               
                    cmd.Parameters.AddRange(param);
               
            }
            SqlDataAdapter dbr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dbr.Fill(dt);
            return dt;
        }
        //Method to insert,update,delete data from DB
        public int Execute(string stored,SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored;
            cmd.Connection = con;
            if (param!=null)
            {
                cmd.Parameters.AddRange(param);
            }
            int x = cmd.ExecuteNonQuery();
            return x;
            //try
            //{
            //    int x = cmd.ExecuteNonQuery();
            //}
            //catch (Exception exp)
            //{
            //    MessageBox.Show("This is already exist in the database!");
            //    Application.Exit();
            //}
        }
        public SqlConnection Return_Connection()
        {
            return con;
        }
    }
}
