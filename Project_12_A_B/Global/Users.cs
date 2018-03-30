using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_12_A_B
{
    public class User
    {
        private string name;
        private string id;
        private string pwd;
        private string perm;
        private string isLogged;
        private string Email;
        private string Semester;
        private string Address;
        public User() {
            this.Email = "";
            this.Semester = "";
            this.Address = "";
        }
        //Getters
        public string getName() { return name; }
        public string getPwd() { return pwd; }
        public string getPerm() { return perm; }
        public string getId() { return id; }
        public string getisLogged() { return isLogged; }
        public string getSemester() { return Semester; }
        public string getMail() { return Email; }
        public string getAddress() { return Address; }
        //Setters

        public void setName(string name) { this.name = name; }
        public void setPwd(string pwd) { this.pwd = pwd; }
        public void setId(string id) { this.id = id; }
        public void setMail(string _Mail) { this.Email = _Mail; }
        public void setSemester(string sem) { this.Semester = sem; }
        public void setAddress(string _Address) { this.Address = _Address; }
        public void setPerm(string perm) { this.perm = perm; }
        public void setIsLogged(string isLogged) { this.isLogged = isLogged; }


        /// <summary>
        /// Copy Ctor for User -> User
        /// </summary>
        /// <param name="u"></param>
        public User(User u)
        {
            this.id = u.id;
            this.name = u.name;
            this.pwd = u.pwd;
        }
        /*virtual internal void saveData(string curr_id)
        {
            SqlDataAdapter da;
            SqlCommandBuilder cmdBuilder;
            DataSet UserData = new DataSet();

            //Initialize the SqlDataAdapter object by specifying a Select command 
            //that retrieves data from the sample table.
            da = new SqlDataAdapter("select * from Login where Id=" +curr_id, Globals.conn);
            //da = new SqlDataAdapter("select * from Login where id=" + curr_id, Globals.conn);

            //Initialize the SqlCommandBuilder object to automatically generate and initialize
            //the UpdateCommand, InsertCommand, and DeleteCommand properties of the SqlDataAdapter.
            cmdBuilder = new SqlCommandBuilder(da);

            //Populate the DataSet by running the Fill method of the SqlDataAdapter.
            da.Fill(UserData, "Login");

            //Modify the value of the CustName field.
            UserData.Tables["Login"].Rows[0]["Id"] = id;
            UserData.Tables["Login"].Rows[0]["Name"] = name;
            UserData.Tables["Login"].Rows[0]["Password"] = pwd;
            UserData.Tables["Login"].Rows[0]["Permission"] = perm;
            //UserData.Tables["Login"].Rows[0]["isLogged"] = isLogged;
            //let's save the student data in login.
            if (Int32.Parse(perm)== 0)
            {
                UserData.Tables["Login"].Rows[0]["Email"] = Email;
                UserData.Tables["Login"].Rows[0]["Semester"] = Semester;
                UserData.Tables["Login"].Rows[0]["Address"] = Address;

            }
            //Post the data modification to the database.
            da.Update(UserData, "Login");

            //Globals.conn.Close();
        }*/
        virtual internal void saveData(string curr_id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Login SET Name=@Name,Password=@Password,Permission=@Permission,Address=@Address,Email=@Email,Semester=@Semester WHERE Id='" + curr_id + "'", Globals.conn);
                cmd.Parameters.AddWithValue("@Name", this.name);
                cmd.Parameters.AddWithValue("@Password", this.pwd);
                cmd.Parameters.AddWithValue("@Permission", this.perm);
                cmd.Parameters.AddWithValue("@Address", this.Address);
                cmd.Parameters.AddWithValue("@Email", this.Email);
                cmd.Parameters.AddWithValue("@Semester", this.Semester);
                cmd.ExecuteNonQuery();
            }
            catch (Exception a)
            {
                MessageBox.Show("Can not save data:"+a);
            }
        }
    }
}
