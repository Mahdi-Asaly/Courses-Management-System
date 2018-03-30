using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Project_12_A_B;

namespace Project_Sce.CodeLayer
{
    public class Course
    {
        private string id, name, category, semester;
        private int hoursPerWk, year;
        private float point;
        private Boolean practition, lab, registerOption;

        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Category
        {
            get { return this.category; }
            set { this.category = value; }
        }

        public string Semester
        {
            get { return this.semester; }
            set { this.semester = value; }
        }

        public int HoursPerWk
        {
            get { return this.hoursPerWk; }
            set { this.hoursPerWk = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public float Point
        {
            get { return this.point; }
            set { this.point = value; }
        }

        public bool Practition
        {
            get { return this.practition; }
            set { this.practition = value; }
        }

        public bool Lab
        {
            get { return this.lab; }
            set { this.lab = value; }
        }

        public bool RegisterOption
        {
            get { return this.registerOption; }
            set { this.registerOption = value; }
        }

        public Course() { }

        public Course(string id_, string name_, int hoursPerWk_, float point_, string category_, Boolean practition_, Boolean lab_, string semester_, int year_, bool registerOption_)
        {
            this.id = id_;
            this.name = name_;
            this.category = category_;
            this.semester = semester_;
            this.hoursPerWk = hoursPerWk_;
            this.point = point_;
            this.practition = practition_;
            this.lab = lab_;
            this.year = year_;
            this.registerOption = registerOption_;
        }

        public bool Add_Course(string courseId, string name, int hoursPerWk, float point, string category, Boolean pract, Boolean lab, string semester)
        {
            if (hoursPerWk <= 0 || point < 0 || courseId == null || category == null)
                return false;
            Project_Sce.DAL.DataBase DAl = new Project_Sce.DAL.DataBase();
            DAl.open();
            SqlParameter[] p = new SqlParameter[8];

            p[0] = new SqlParameter("@CourseID", SqlDbType.NVarChar, 10);
            p[0].Value = courseId;

            p[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            p[1].Value = name;

            p[2] = new SqlParameter("@HoursPerWk", SqlDbType.Int);
            p[2].Value = hoursPerWk;

            p[3] = new SqlParameter("@Point", SqlDbType.Float);
            p[3].Value = point;

            p[4] = new SqlParameter("@Category", SqlDbType.NVarChar, 20);
            p[4].Value = category;

            p[5] = new SqlParameter("@Lab", SqlDbType.Bit);
            p[5].Value = lab;

            p[6] = new SqlParameter("@Practition", SqlDbType.Bit);
            p[6].Value = pract;

            p[7] = new SqlParameter("@Semester", SqlDbType.NChar, 10);
            p[7].Value = semester;

            DAl.Execute("AddCourse", p);
            DAl.close();
            return true;
        }

        public bool Delete_Course(string CourseID)
        {
            if (Verify_CourseID(CourseID).Rows.Count == 1)
            {
                Project_Sce.DAL.DataBase DAl = new Project_Sce.DAL.DataBase();
                DAl.open();
                SqlParameter[] p = new SqlParameter[1];
                p[0] = new SqlParameter("@CourseID", SqlDbType.NVarChar, 10);
                p[0].Value = CourseID;

                DAl.Execute("Deleting_Course", p);
                DAl.close();
                return true;
            }
            return false;
        }


        public DataTable Verify_CourseID(string CourseID)
        {
            Project_Sce.DAL.DataBase DAl = new Project_Sce.DAL.DataBase();
            DataTable dt = new DataTable();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@CourseID", SqlDbType.NVarChar, 10);
            p[0].Value = CourseID;
            dt = DAl.SelectData("Verify_CourseID", p);
            DAl.close();
            return dt;
        }
    }
}
