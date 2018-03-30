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
    public class Cls_Login
    {
        public string ID
        {
            get; set;
        }

        public string Email
        {
            get; set;
        }

        public string Password
        {
            get; set;
        }

        public Cls_Login() { }

        public Cls_Login(string id, string email, string password)
        {
            this.ID = id;
            this.Email = email;
            this.Password = password;
        }
        public DataTable Login(string Id, string Password)
        {
            DAL.DataBase dl = new DAL.DataBase();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Id", SqlDbType.NChar, 10);
            param[0].Value = Id;

            param[1] = new SqlParameter("@Password", SqlDbType.NChar, 10);
            param[1].Value = Password;

            dl.open();
            DataTable dt = new DataTable();
            dt = dl.SelectData("SP_LOGIN", param);
            return dt;
        }
    }
}
