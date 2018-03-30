using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


using System.Drawing;

using System.Windows.Forms;


namespace Project_12_A_B.Classes
{
    public class Student:User
    {
        public int SemCount { get; set; }
       
        /// <summary>
        /// 
        /// </summary>
        public Student() : base()
        {
            init();
        }
        /// <summary>
        /// Copy Ctor for User -> Student
        /// </summary>
        /// <param name="u"></param>
        public Student(User u) : base(u)
        {
            init();
        }
        /// <summary>
        /// 
        /// </summary>
        private void init()
        {
            /// create a new Curriculum       
        }
        public Boolean removeCourse(string courseid)
        {
            Boolean res = false;
            int numofStudents;
            string RegisterOption;
            try
            {
                using (SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Courses", Globals.conn))
                {
                    // fill a data table
                    var t = new DataTable();
                    a.Fill(t);
                    RegisterOption = t.Rows[0][8].ToString();
                    //checking if the secretary has already disabled/enabled the registration
                    if (Int32.Parse(RegisterOption) == 0) //
                    {//
                        MessageBox.Show("Secretary has disabled course cancellation.", "ERROR", MessageBoxButtons.OK);//
                        return false;//
                    }//
                }
                using (SqlCommand cmd = new SqlCommand("DELETE FROM StudentCourses WHERE StudID= @StudID AND CourseID = @CourseID", Globals.conn))//
                { //                   
                    cmd.CommandText = "DELETE FROM StudentCourses WHERE StudID= @StudID AND CourseID = @CourseID";//
                    cmd.Parameters.AddWithValue("@StudID", (Globals.LoggedUser as Classes.Student).getId());//
                    cmd.Parameters.AddWithValue("@CourseID", courseid);//

                    cmd.ExecuteNonQuery();//
                }//
                //Getting the current slots in lesson.
                using (SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Lesson WHERE CourseID='" + courseid + "'", Globals.conn))
                {
                    // fill a data table
                    var t = new DataTable();
                    a.Fill(t);
                    numofStudents = Int32.Parse(t.Rows[0][7].ToString()) + 1; //has been registered so count --
                }
                //updating the slots.
                SqlCommand cmd2 = new SqlCommand("UPDATE Lesson SET Numofstud= @Numofstud WHERE CourseID='" + courseid + "'", Globals.conn);
                cmd2.Parameters.AddWithValue("@Numofstud", numofStudents.ToString());
                cmd2.ExecuteNonQuery();
                res = true;
            }
            catch
            {
                MessageBox.Show("Error occured while trying to remove course id: '" + courseid + "' , try again later", "ERROR", MessageBoxButtons.OK);
                return false;
            }
            //inform the user.
            MessageBox.Show("successfully Removed course id:"+courseid ,"Course Registeration", MessageBoxButtons.OK);
            return res;
        }
        public Boolean registertoCourse(string courseid , string lecID )
        {
            Boolean res = false;
            Boolean res2 = true;
            string day="", hour="";
            SqlDataAdapter StudentCourses, a,lessons,newCurrentlesson,course;
            DataTable LessonsTable, studentCoursesTable,newCurrentLessonTable,coursetable;
            int numofStudents;
            //updating the details .
            //Getting all the details
            try
            {
                //Checking if possible to register.
                string RegisterOption;
                using (a = new SqlDataAdapter("SELECT * FROM Courses", Globals.conn))
                {
                    // fill a data table
                    var t = new DataTable();
                    a.Fill(t);
                    RegisterOption = t.Rows[0][8].ToString();
                }
                //let's check if secretary disabled/enabled registration :D
                if (Int32.Parse(RegisterOption) == 0)
                {
                    MessageBox.Show("Secretary has disabled course registation.", "ERROR", MessageBoxButtons.OK);
                    return false;
                }

                //in this step we will check conflicts between courses, course with same hour can not be duplicated.

                //we have to take each course of student if it's hours & day equal's to the course that we adding ,so we can't add it
                using (StudentCourses = new SqlDataAdapter("SELECT * FROM StudentCourses where StudID='"+(Globals.LoggedUser as Classes.Student).getId()+"'", Globals.conn))
                {
                    // fill a data table
                    studentCoursesTable = new DataTable();
                    StudentCourses.Fill(studentCoursesTable);
                }
                //this all lessons
                using (lessons = new SqlDataAdapter("SELECT * FROM Lesson", Globals.conn))
                {
                    // fill a data table
                    LessonsTable = new DataTable();
                    lessons.Fill(LessonsTable);
                    
                }
                //this what i will add now
                using (newCurrentlesson = new SqlDataAdapter("SELECT * FROM Lesson WHERE CourseID='" + courseid + "'" + "AND LecturerID='" + lecID + "'", Globals.conn))
                {
                    // fill a data table
                    newCurrentLessonTable = new DataTable();
                    newCurrentlesson.Fill(newCurrentLessonTable);
                }
                for (int i=0;i<LessonsTable.Rows.Count;i++)
                {
                    for(int j=0;j<studentCoursesTable.Rows.Count;j++)
                    {
                        using (course = new SqlDataAdapter("SELECT * FROM Lesson WHERE CourseID='" + studentCoursesTable.Rows[j][1] + "'" + "AND LecturerID='" + studentCoursesTable.Rows[j][3] + "'", Globals.conn))
                        {
                            // fill a data table
                            coursetable = new DataTable();
                            course.Fill(coursetable);
                        }
                        if (newCurrentLessonTable.Rows[0][4].ToString().Replace(" ", "") == coursetable.Rows[0][4].ToString().Replace(" ", ""))
                        {
                            if (Convert.ToInt32(newCurrentLessonTable.Rows[0][5].ToString()) >= Convert.ToInt32(coursetable.Rows[0][5].ToString()) && Convert.ToInt32(newCurrentLessonTable.Rows[0][6].ToString()) <= Convert.ToInt32(coursetable.Rows[0][6].ToString()))
                            {
                                day = newCurrentLessonTable.Rows[0][4].ToString();
                                hour = newCurrentLessonTable.Rows[0][5].ToString() +"-" +newCurrentLessonTable.Rows[0][6].ToString();
                                res2 = false;
                            }
                        }
                    }
                }

                if (res2 == false)
                {
                    MessageBox.Show("You can not add this course there are conflict with other course!\nInfo:\n"+"Course ID:"+courseid+","+" Day:"+day+", Hour: "+hour);
                    return res2;
                }
                //in this step we will register the student to specific course.

                //Getting the current slots in lesson.
                using (SqlDataAdapter b = new SqlDataAdapter("SELECT * FROM Lesson WHERE CourseID='" + courseid + "'"+"AND LecturerID='"+lecID+"'", Globals.conn))
                {
                    // fill a data table
                    var t = new DataTable();
                    b.Fill(t);
                    numofStudents = Int32.Parse(t.Rows[0][7].ToString()) - 1; //has been registered so count --
                }
                //////////////////////////////////////////////////////////////
                if(numofStudents+1<=0)
                {
                    MessageBox.Show("No available slots in this class!");
                    return false;
                }
                //////////////////////////////////////////////////////////////
                //registering to course.
                //updating course table
                SqlCommand cmd = new SqlCommand("INSERT INTO StudentCourses (StudID, CourseID,LecturerID) VALUES (@StudID, @CourseID,@LecturerID)", Globals.conn);
                cmd.Parameters.AddWithValue("@StudID", (Globals.LoggedUser as Classes.Student).getId());
                cmd.Parameters.AddWithValue("@CourseID", courseid);
                cmd.Parameters.AddWithValue("@LecturerID", lecID);
                cmd.ExecuteNonQuery();
                //////////////////////////////////////////////////////////////
                //updating the slots.
                SqlCommand cmd2 = new SqlCommand("UPDATE Lesson SET Numofstud= @Numofstud WHERE CourseID='"+courseid+"'", Globals.conn);
                cmd2.Parameters.AddWithValue("@Numofstud", numofStudents.ToString()); 
                cmd2.ExecuteNonQuery();
                res = true;
            }
            catch
            {
                MessageBox.Show("Error occured while trying to register to course id: '" + courseid + "' , try again later","ERROR",MessageBoxButtons.OK);
                return false;
            }
            //inform the user.
            MessageBox.Show("Details have been successfully changed!", "Course Registeration", MessageBoxButtons.OK);
            return res;
        }
        public Boolean SendRequest(String Option,String Request)
        {
            Boolean res = false;
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Requests (id, Choice, Reason) VALUES (@id ,@Choice, @Reason)", Globals.conn);
                cmd.Parameters.AddWithValue("@id",Globals.LoggedUser.getId());
                cmd.Parameters.AddWithValue("@Choice", Option);
                cmd.Parameters.AddWithValue("@Reason", Request);
                cmd.ExecuteNonQuery();
                res = true;
            }
            catch (SqlException v)
            {
                MessageBox.Show("Error occured while submitting request reason:"+v, "ERROR", MessageBoxButtons.OK);
                return false;
            }
            return res;
        }
    }
}
