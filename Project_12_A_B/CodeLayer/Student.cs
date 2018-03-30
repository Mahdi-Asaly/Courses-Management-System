using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Project_12_A_B;

namespace Project_Sce.CodeLayer
{
    public class Student
    {
        private int id;
        private string name;
        private int year;
        private float average;
        private string address;
        private string email;
        private string semester;
        private bool cyber;

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public float Average
        {
            get { return this.average; }
            set { this.average = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Semester
        {
            get { return this.semester; }
            set { this.semester = value; }
        }

        public bool Cyber
        {
            get { return this.cyber; }
            set { this.cyber = value; }
        }

        public Student()
        {

        }

        public Student(int id_, string name_, int year_, float average_, string address_, string email_, string semester_, bool cyber_)
        {
            this.id = id_;
            this.name = name_;
            this.year = year_;
            this.average = average_;
            this.address = address_;
            this.email = email_;
            this.semester = semester_;
            this.cyber = cyber_;
        }

        public DataTable get_All_Students()
        {
            Project_Sce.DAL.DataBase DAl = new Project_Sce.DAL.DataBase();
            DAl.open();
            DataTable dt = new DataTable();
            dt = DAl.SelectData("get_All_Students", null);
            DAl.close();
            return dt;
        }

        
        public DataTable Search_Student(string ID)
        {
            DAL.DataBase DAl = new DAL.DataBase();
            DAl.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;
            dt = DAl.SelectData("Search_Student", param);
            DAl.close();
            return dt;
        }

        public DataTable Get_Courses(string Id)
        {
            DAL.DataBase dl = new DAL.DataBase();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.NVarChar, 50);
            param[0].Value = Id;
            dl.open();
            DataTable dt = new DataTable();
            dt = dl.SelectData("Get_Corses", param);
            return dt;
        }
        public DataTable Get_Student_Info(string Id)
        {
            DAL.DataBase dl = new DAL.DataBase();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.NVarChar, 50);
            param[0].Value = Id;
            dl.open();
            DataTable dt = new DataTable();
            dt = dl.SelectData("Get_Student_Info", param);
            return dt;
        }
        public DataTable delete_cyber(string Id,bool cyber)
        {
            DAL.DataBase DAl = new DAL.DataBase();
            DAl.open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Id", SqlDbType.NVarChar, 50);
            param[0].Value = Id;

            param[1] = new SqlParameter("@cyber", SqlDbType.Bit);
            param[0].Value = cyber;
            dt = DAl.SelectData("delete_cyber", param);
            DAl.close();
            return dt;
        }


    }

}

