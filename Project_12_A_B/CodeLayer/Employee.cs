using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Project_12_A_B;

namespace Project_Sce.CodeLayer
{
    public class Employee : Person
    {
        
        protected string login;
        protected string password;
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public string Login
        {
            get { return this.login; }
            set { this.login = value; }
        }

        public Employee()
        {

        }

        public Employee(string _id, string _firstName, string _lastName, string _address, string _email, string _tel, DateTime _birthDay, string _password, string _login)
        {
            this.id = _id;
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.address = _address;
            this.email = _email;
            this.tel = _tel;
            this.birthDay = _birthDay;
            this.password = _password;
            this.login = _login; 
        }
        public DataTable get_all_users()
        {
            Project_Sce.DAL.DataBase DAl = new Project_Sce.DAL.DataBase();
            DAl.open();
            DataTable dt = new DataTable();
            dt = DAl.SelectData("get_all_users", null);
            DAl.close();
            return dt;
        }
        public bool delete_user(string ID)
        {
            Project_Sce.DAL.DataBase DAl = new Project_Sce.DAL.DataBase();
            if (Verify_User_ID(ID).Rows.Count == 1)
            {
                DAl.open();
                SqlParameter[] p = new SqlParameter[1];
                p[0] = new SqlParameter("@ID", SqlDbType.NChar, 10);
                p[0].Value = ID;

                DAl.Execute("delete_user", p);
                DAl.close();
                return true;
            }
            DAl.close();
            return false;
               
            

        }
        public bool add_user(string ID, string name, string password ,string permission,string address,string email,string isLogged)
        {
            Project_Sce.DAL.DataBase DAl = new Project_Sce.DAL.DataBase();
            if(Verify_User_ID(ID).Rows.Count == 0)
            {
                DAl.open();
                SqlParameter[] p = new SqlParameter[7];
                p[0] = new SqlParameter("@ID", SqlDbType.NChar, 10);
                p[0].Value = ID;

                p[1] = new SqlParameter("@Name", SqlDbType.NVarChar);
                p[1].Value = name;

                p[2] = new SqlParameter("@Password", SqlDbType.NChar, 10);
                p[2].Value = password;

                p[3] = new SqlParameter("@Permission", SqlDbType.NChar, 10);
                p[3].Value = permission;

                p[4] = new SqlParameter("@Address", SqlDbType.NVarChar, 50);
                p[4].Value = address;

                p[5] = new SqlParameter("@Email", SqlDbType.NVarChar);
                p[5].Value = email;

                p[6] = new SqlParameter("@isLogged", SqlDbType.NChar);
                p[6].Value = "false";

                DAl.Execute("add_user", p);
                DAl.close();
                return true;
            }
            DAl.close();
            return false;
            
        }

        public DataTable Verify_User_ID(string ID)
        {
            Project_Sce.DAL.DataBase DAl = new Project_Sce.DAL.DataBase();
            DataTable dt = new DataTable();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@Id", SqlDbType.NChar, 10);
            p[0].Value = ID;
            dt = DAl.SelectData("Verify_UserID", p);
            DAl.close();
            return dt;
        }

    }
}
