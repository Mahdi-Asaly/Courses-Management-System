using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;
using System.Data;
//This class Actually Descript the secretary , with all the methods and functionality.
namespace Project_12_A_B.Classes
{
    public class SecretaryClass:User
    {
        public SecretaryClass():base()
        {
            
        }
        /* internal override void saveData(string curr_id)
         {

         }*/

        public Boolean removeCourse(string courseid,string studid)
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
                    //let's check if secretary disabled/enabled registration :D
                    if (Int32.Parse(RegisterOption) == 0)
                    {
                        DialogResult Result=MessageBox.Show("ERROR: Registration Disabled , Do you want to Enable registration?", "WARNING", MessageBoxButtons.YesNo);
                        if (Result == DialogResult.Yes)
                        {
                            //do enable
                            try
                            {
                                SqlCommand cmd = new SqlCommand("Update Courses SET RegisterOption='1'", Globals.conn);
                                cmd.ExecuteNonQuery();
                            }
                            catch (SqlException v)
                            {
                                MessageBox.Show("Error Occured while submitting request reason:" + v, "ERROR", MessageBoxButtons.OK);
                            }
                            MessageBox.Show("Course registration enabled!");
                        }
                        else
                        {
                            return false;
                        }
                     }
                }
                using (SqlCommand cmd = new SqlCommand("DELETE FROM StudentCourses WHERE StudID= @StudID AND CourseID = @CourseID", Globals.conn))
                {
                    cmd.CommandText = "DELETE FROM StudentCourses WHERE StudID= @StudID AND CourseID = @CourseID";
                    cmd.Parameters.AddWithValue("@CourseID", courseid);
                    cmd.Parameters.AddWithValue("@StudID", studid);
                    cmd.ExecuteNonQuery();
                }
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
                MessageBox.Show("Error Occured while trying to removing course id: '" + courseid + "' , try again later", "ERROR", MessageBoxButtons.OK);
                return false;
            }
            //inform the user.
            MessageBox.Show("successfully removed course id:" + courseid, "Course Registeration", MessageBoxButtons.OK);
            return res;
        }

        public Boolean addcourseStudent(string courseid, string id, string lecID)
        {
            Boolean res = false;
            Boolean ItsAlreadyInDB = false;
            int numofStudents;
            //updating the details .
            //Getting all the details
            try
            {
                //Checking if possible to register.
                string RegisterOption;
                using (SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Courses", Globals.conn))
                {

                    // fill a data table
                    var t = new DataTable();
                    a.Fill(t);
                    RegisterOption = t.Rows[0][8].ToString();
                }

                //let's check if secretary disabled/enabled registration :D
                /*if (Int32.Parse(RegisterOption) == 0)
                {
                    MessageBox.Show("Secretary has been disabled course registration.", "ERROR", MessageBoxButtons.OK);
                    return false;
                }*/
                if (Int32.Parse(RegisterOption) == 0)
                {
                    DialogResult Result = MessageBox.Show("ERROR: Registration Disabled , Do you want to Enable registration?", "WARNING", MessageBoxButtons.YesNo);
                    if (Result == DialogResult.Yes)
                    {
                        //do enable
                        try
                        {
                            SqlCommand cd = new SqlCommand("Update Courses SET RegisterOption='1'", Globals.conn);
                            cd.ExecuteNonQuery();
                        }
                        catch (SqlException v)
                        {
                            MessageBox.Show("Error Occured while submitting request reason:" + v, "ERROR", MessageBoxButtons.OK);
                        }
                        MessageBox.Show("Course registration enabled!");
                    }
                    else
                    {
                        return false;
                    }
                }


                //Getting the current slots in lesson.
                using (SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Lesson WHERE CourseID='" + courseid + "'" + "AND LecturerID='" + lecID + "'", Globals.conn))
                {

                    // fill a data table
                    var t = new DataTable();
                    a.Fill(t);
                    numofStudents = Int32.Parse(t.Rows[0][7].ToString()) - 1; //has been registered so count --
                }
                //////////////////////////////////////////////////////////////
                if (numofStudents + 1 <= 0)
                {
                    MessageBox.Show("No available slots in this class!");
                    return false;
                }

                //Checking if the student is already registered to the specific course.
                using (SqlDataAdapter a = new SqlDataAdapter("SELECT CourseID FROM StudentCourses WHERE StudID='" + id + "'" + "AND LecturerID='" + lecID + "'", Globals.conn))
                {

                    // fill a data table
                    var t = new DataTable();
                    a.Fill(t);
                    if (t.Rows.Count > 0)
                        ItsAlreadyInDB = true;
                }
                //////////////////////////////////////////////////////////////
                //registering to course.
                //updating course table
                if (ItsAlreadyInDB == false)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO StudentCourses (StudID, CourseID, LecturerID) VALUES (@StudID, @CourseID, @LecturerID)", Globals.conn);
                    cmd.Parameters.AddWithValue("@StudID", id);
                    cmd.Parameters.AddWithValue("@CourseID", courseid);
                    cmd.Parameters.AddWithValue("@LecturerID", lecID);
                    cmd.ExecuteNonQuery();
                    //////////////////////////////////////////////////////////////

                    //updating the slots.
                    SqlCommand cmd2 = new SqlCommand("UPDATE Lesson SET Numofstud= @Numofstud WHERE CourseID='" + courseid + "'", Globals.conn);
                    cmd2.Parameters.AddWithValue("@Numofstud", numofStudents.ToString());
                    cmd2.ExecuteNonQuery();
                }
                res = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error Occured while trying to register to course id: '" + courseid + "' , try again later\nINFO:" + ex.ToString(), "ERROR", MessageBoxButtons.OK);
                return false;
            }
            //inform the user.
            MessageBox.Show("Details have been successfully changed!", "Course Registeration", MessageBoxButtons.OK);
            return res;
        }
        //@Testing Unit getting ann msg
        public String getPost()
        {
            string ann = null;
            using (SqlDataAdapter a = new SqlDataAdapter("SELECT Message FROM Announcements", Globals.conn))
            {
                // fill a data table
                var t = new DataTable();
                a.Fill(t);
                if (t.Rows.Count > 0)
                {
                    ann = t.Rows[0][0].ToString();
                }
            }
            return ann;
        }
        public Boolean SaveStudentInfo(string id,string name,string password,string address,string email,string sem)
        {
            Boolean res = false;
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Login SET Name=@Name,Password=@Password,Address=@Address,Email=@Email,Semester=@Semester WHERE Id='" + id.ToString() + "'", Globals.conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Semester", sem);
                cmd.ExecuteNonQuery();
                res = true;
            }
            catch(Exception a)
            {
                  MessageBox.Show("ERROR: An error occured while saving data\n" + a.ToString());
                  res = false;
            }
            return res;
        }
        public void PostAnnouncement(String Msg)
        {

                SqlCommand cmd = new SqlCommand("UPDATE Announcements SET Message= @Message", Globals.conn);
                cmd.Parameters.AddWithValue("@Message", Msg);
                cmd.ExecuteNonQuery();
            
        }
        public bool RequestTechnicalSupport(String Msg)
        {
            bool res = false;
            SqlCommand cmd = new SqlCommand("INSERT into TechnicalReqs (Id,Name,Message) VALUES (@Id,@Name,@Message)", Globals.conn);
            cmd.Parameters.AddWithValue("@Id", Globals.LoggedUser.getId());
            cmd.Parameters.AddWithValue("@Name", Globals.LoggedUser.getName());
            cmd.Parameters.AddWithValue("@Message", Msg);
            cmd.ExecuteNonQuery();
            res = true;
            return res;
        }
    }
}
