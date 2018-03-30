using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Project_12_A_B;

namespace Project_Sce.CodeLayer
{
    public class Lesson
    {
        private string type;
        private string cls;
        private string courseID;
        private string lecturerID;
        private string day;
        private int strtTime;
        private int endTime;
        private static int numOfStud =0;
        //private Student[] stud;

        public string ClassroomName
        {
            get { return this.cls; }
            set { this.cls = value; }
        }

        public string Day
        {
            get { return this.day; }
            set { this.day = value; }
        }

        public int StrtTime
        {
            get { return this.strtTime; }
            set { this.strtTime = value; }
        }

        public int EndTime
        {
            get { return this.endTime; }
            set { this.endTime = value; }
        }

        public Lesson() { }
        public Lesson(string t, string cls, string courseId, string lecId, string d, int strt, int end)
        {
            this.type = t;
            this.cls = cls;
            this.courseID = courseId;
            this.lecturerID = lecId;
            this.day = d;
            this.strtTime = strt;
            this.endTime = end;
           // stud = new Student[numOfStud];
        }

        public DataTable get_classID()
        {
            Project_Sce.DAL.DataBase DAl = new Project_Sce.DAL.DataBase();
            DAl.open();
            DataTable dt = new DataTable();
            dt = DAl.SelectData("get_classID", null);
            DAl.close();
            return dt;
        }

        public DataTable get_courseID()
        {
            Project_Sce.DAL.DataBase DAl = new Project_Sce.DAL.DataBase();
            DAl.open();
            DataTable dt = new DataTable();
            dt = DAl.SelectData("get_courseID", null);
            DAl.close();
            return dt;
        }

        public DataTable get_lecID(string day, int StrtTime, int EndTime)
        {
            Project_Sce.DAL.DataBase DAl = new Project_Sce.DAL.DataBase();
            DAl.open();
            DataTable dt = new DataTable();

            SqlParameter[] p = new SqlParameter[3];

            p[0] = new SqlParameter("@day", SqlDbType.NVarChar, 10);
            p[0].Value = day;

            p[1] = new SqlParameter("@StrtTime", SqlDbType.Int);
            p[1].Value = StrtTime;

            p[2] = new SqlParameter("@EndTime", SqlDbType.Int);
            p[2].Value = EndTime;



            dt = DAl.SelectData("get_lecID", p);
            DAl.close();
            return dt;
        }


        public bool Add_Lesson(string category_cat, string class_cat, string course_cat, string lecturer_cat, string day_cat, int strt_cat, int end_cat, int numOfStud)
        {
            Project_Sce.DAL.DataBase DAl = new Project_Sce.DAL.DataBase();
            DAl.open();
            SqlParameter[] p = new SqlParameter[8];
            p[0] = new SqlParameter("@Type", SqlDbType.NVarChar, 50);
            p[0].Value = category_cat;

            p[1] = new SqlParameter("@ClassRoom", SqlDbType.NVarChar, 20);
            p[1].Value = class_cat;

            p[2] = new SqlParameter("@CourseID", SqlDbType.NVarChar, 10);
            p[2].Value = course_cat;

            p[3] = new SqlParameter("@LecturerID", SqlDbType.NVarChar, 20);
            p[3].Value = lecturer_cat;

            p[4] = new SqlParameter("@Day", SqlDbType.NVarChar, 10);
            p[4].Value = day_cat;

            p[5] = new SqlParameter("@StrtTime", SqlDbType.Int);
            p[5].Value = strt_cat;

            p[6] = new SqlParameter("@EndTime", SqlDbType.Int);
            p[6].Value = end_cat;

            p[7] = new SqlParameter("@Numofstud", SqlDbType.Int);
            p[7].Value = numOfStud;

            bool result = DAl.Execute("Add_Lesson", p) > 0 ? true :  false;
            DAl.close();
            return result;
        }


        public DataTable get_lecClassID(string d, int strt, int end)
        {
            Project_Sce.DAL.DataBase DAl = new Project_Sce.DAL.DataBase();
            DAl.open();
            DataTable dt = new DataTable();

            SqlParameter[] p = new SqlParameter[3];

            p[0] = new SqlParameter("@day", SqlDbType.NVarChar, 10);
            p[0].Value = d;

            p[1] = new SqlParameter("@StrtTime", SqlDbType.Int);
            p[1].Value = strt;

            p[2] = new SqlParameter("@EndTime", SqlDbType.Int);
            p[2].Value = end;



            dt = DAl.SelectData("get_lecClassID",p);
            DAl.close();
            return dt;
        }

        public DataTable get_practClassID(string d, int strt, int end)
        {
            Project_Sce.DAL.DataBase DAl = new Project_Sce.DAL.DataBase();
            DAl.open();
            DataTable dt = new DataTable();

            SqlParameter[] p = new SqlParameter[3];

            p[0] = new SqlParameter("@day", SqlDbType.NVarChar, 10);
            p[0].Value = d;

            p[1] = new SqlParameter("@StrtTime", SqlDbType.Int);
            p[1].Value = strt;

            p[2] = new SqlParameter("@EndTime", SqlDbType.Int);
            p[2].Value = end;

            dt = DAl.SelectData("get_practClassID",p);
            DAl.close();
            return dt;
        }

        public DataTable get_labClassID(string d, int strt, int end)
        {
            Project_Sce.DAL.DataBase DAl = new Project_Sce.DAL.DataBase();
            DAl.open();
            DataTable dt = new DataTable();

            SqlParameter[] p = new SqlParameter[3];

            p[0] = new SqlParameter("@day", SqlDbType.NVarChar, 10);
            p[0].Value = d;

            p[1] = new SqlParameter("@StrtTime", SqlDbType.Int);
            p[1].Value = strt;

            p[2] = new SqlParameter("@EndTime", SqlDbType.Int);
            p[2].Value = end;

            dt = DAl.SelectData("get_labClassID", p);
            DAl.close();
            return dt;
        }

        public void Update_Lesson(string class_cat, string lecturer_cat, int id)
        {
            Project_Sce.DAL.DataBase DAl = new Project_Sce.DAL.DataBase();
            DAl.open();
            SqlParameter[] p = new SqlParameter[3];

            p[0] = new SqlParameter("@ClassRoom", SqlDbType.NVarChar, 20);
            p[0].Value = class_cat;

            p[1] = new SqlParameter("@LecturerID", SqlDbType.NVarChar, 20);
            p[1].Value = lecturer_cat;

            p[2] = new SqlParameter("@id", SqlDbType.Int);
            p[2].Value = id;


            DAl.Execute("Update_Lesson", p);
            DAl.close();
        }


        public DataTable Verify_lecConstraint(string lecID, string day, int StrtTime, int EndTime )
        {
            Project_Sce.DAL.DataBase DAl = new Project_Sce.DAL.DataBase();
            DataTable dt = new DataTable();
            SqlParameter[] p = new SqlParameter[4];
            p[0] = new SqlParameter("@LecturerID", SqlDbType.NVarChar, 20);
            p[0].Value = lecID;

            p[1] = new SqlParameter("@Day", SqlDbType.NVarChar, 10);
            p[1].Value = day;

            p[2] = new SqlParameter("@StrtTime", SqlDbType.Int);
            p[2].Value = StrtTime;

            p[3] = new SqlParameter("@EndTime", SqlDbType.Int);
            p[3].Value = EndTime;
            dt = DAl.SelectData("Verify_lecConstraint", p);
            DAl.close();
            return dt;
        }
    }
}
