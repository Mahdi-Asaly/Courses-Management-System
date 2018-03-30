using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Project_12_A_B.Classes
{
    public class Admin:User
    {
        public Admin():base()
        {

        }
        public Boolean SendRequest(String Msg)
        {
            bool res = false;
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT into TechnicalReqs (Id,Name,Message) VALUES (@Id,@Name,@Message)", Globals.conn);
                cmd.Parameters.AddWithValue("@Id", Globals.LoggedUser.getId());
                cmd.Parameters.AddWithValue("@Name", Globals.LoggedUser.getName());
                cmd.Parameters.AddWithValue("@Message", Msg);
                cmd.ExecuteNonQuery();
                res = true;
            }
            catch { }
            return res;
        }
        /* internal override void saveData(string curr_id)
         {
         //
         }*/
         
    }
}
