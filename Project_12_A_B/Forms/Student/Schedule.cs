using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Threading;
namespace Project_12_A_B
{
    public partial class Schedule : MetroForm
    {
        private Random rnd = new Random();
        private int b;
        double remCred, cumCred;
        public Schedule()
        {
            InitializeComponent();
            //AddCurriculum();
            GetCoursesOfStudent();
            GetCompulsoryCourses();
            userNameLable.Text = "Welcome, " + (Globals.LoggedUser as Classes.Student).getName();
            SemesterLbl.Text = "Current Semester:" + (Globals.LoggedUser as Classes.Student).getSemester();
            GoFullscreen(true);

            //getting optional courses
            optional_Courses();

            //Gettings Credits INFO
            double result = InBound(remCred);
            double result2 = InBound(cumCred);
            if (result == 1 && result2 == 1)
            {
                remCred = getremaindCredits();
                cumCred = getcumCredits();

                CumCreditsLBl.Text = "Cummulative Credits: " + cumCred.ToString();
                RemainedCredits.Text = "Remaind Credits: " + remCred.ToString();
            }
            ///////////////////////////////////////////    
            createSchedule();


        }
        public double InBound(double integer)
        {
            if (remCred < 0)
                return -1;
            else
                return 1;
        }
        //creating schedule function
        private void createSchedule()
        {
            //getting all the courses 
            //Getting the courses that student registered for.
            SqlDataAdapter a,b;
            var t1 = new DataTable();
            var t2 = new DataTable();
            string day;
            string cname;
            string cid;
            string classnum;
            int startTime;
            int endTime;
            string Type;
            int dayInNum = 2;
            using (a = new SqlDataAdapter("SELECT * FROM StudentCourses WHERE StudID='" + Globals.LoggedUser.getId() + "'", Globals.conn))
            {
                a.Fill(t1);
            }
            using (b = new SqlDataAdapter("SELECT * FROM Lesson", Globals.conn))
            {
                b.Fill(t2);
            }
            for (int i = 0; i < t1.Rows.Count; i++)
            {
                for (int j = 0; j < t2.Rows.Count; j++)
                {
                    //checking if the course id that in the student table equals to lesson course id .
                    //also.. we check if the lecturer id is equal
                    if (t2.Rows[j][2].ToString() == t1.Rows[i][1].ToString() && Int32.Parse(t2.Rows[j][3].ToString())==Int32.Parse(t1.Rows[i][3].ToString()))
                    {
                        //displaying to student suitable data.
                        day = t2.Rows[j][4].ToString();
                        startTime = Int32.Parse(t2.Rows[j][5].ToString());
                        endTime = Int32.Parse(t2.Rows[j][6].ToString());
                        cid = t2.Rows[j][2].ToString();
                        cname = getcourseName(cid);
                        Type = t2.Rows[j][0].ToString();
                        classnum = t2.Rows[j][1].ToString();
                        switch (day)
                        {
                            case "Sunday":
                                dayInNum = 1;
                                break;
                            case "Monday":
                                dayInNum = 2;
                                break;
                            case "Tuesday":
                                dayInNum = 3;
                                break;
                            case "Wednesday":
                                dayInNum = 4;
                                break;
                            case "Thursday":
                                dayInNum = 5;
                                break;
                            default:
                                break;
                        }
                        this.addPanelToTable(dayInNum, startTime, endTime, cid, cname, classnum,Type);
                        break;
                    }
                }
            }
        }

        //function to get the course name
        private String getcourseName(string courseId)
        {
            //Getting the courses that student registered for.
            SqlDataAdapter con;
            String cname="";
            var table = new DataTable();
            using (con = new SqlDataAdapter("SELECT Name FROM Courses Where CourseID='"+courseId+"'", Globals.conn))
            {
                // fill a data table
                con.Fill(table);
                //numofStudents = Int32.Parse(t2.Rows[0][7].ToString()) - 1; //has been registered so count --
                if(table.Rows.Count>0)
                {
                    cname = table.Rows[0][0].ToString();
                }
                else { cname = "NoName"; }
            }
            return cname;
        }

        //private void createSchedule()
        //{
        //    //getting all the courses 
        //    //Getting the courses that student registered for.
        //    string Select = @"SELECT s.StudID, s.CourseID, c.Name, c.Semester, l1.ClassRoom, l1.Day, l1.StrtTime, l1.EndTime
        //    FROM dbo.Login l 
        //    INNER JOIN dbo.StudentCourses s ON ( l.Id = s.StudID  )  
        //    INNER JOIN dbo.Courses c ON ( s.CourseID = c.CourseID  )  
        //    INNER JOIN dbo.Lesson l1 ON ( c.CourseID = l1.CourseID  )  ";
        //    string day;
        //    string cname;
        //    string cid;
        //    string classnum;
        //    int startTime;
        //    int endTime;
        //    string lid;
        //    int dayInNum = 2;
        //    using (SqlDataAdapter a = new SqlDataAdapter(Select, Globals.conn))
        //    {
        //        // fill a data table
        //        var t = new DataTable();
        //        a.Fill(t);
        //        foreach (DataRow row in t.Rows)
        //        {
        //            //displaying to student suitable data.
        //            if (row[3].ToString() == (Globals.LoggedUser as Classes.Student).getSemester() && row[0].ToString() == (Globals.LoggedUser as Classes.Student).getId())
        //            {
        //                day = row[5].ToString();
        //                startTime = Int32.Parse(row[6].ToString());
        //                endTime = Int32.Parse(row[7].ToString());
        //                cid = row[1].ToString();
        //                cname = row[2].ToString();
        //                classnum = row[4].ToString();
        //                switch (day)
        //                {
        //                    case "Sunday":
        //                        dayInNum = 1;
        //                        break;
        //                    case "Monday":
        //                        dayInNum = 2;
        //                        break;
        //                    case "Tuesday":
        //                        dayInNum = 3;
        //                        break;
        //                    case "Wednesday":
        //                        dayInNum = 4;
        //                        break;
        //                    case "Thursday":
        //                        dayInNum = 5;
        //                        break;
        //                    default:
        //                        break;
        //                }
        //                this.addPanelToTable(dayInNum, startTime, endTime, cid, cname, classnum);
        //            }
        //        }
        //    }
        //}
        private void clearSchedule()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j <= 14; j++)
                {
                    Control a = table.GetControlFromPosition(i, j);
                    table.Controls.Remove(a);
                }
            }
        }
        private double getremaindCredits()
        {
            //do calc
            return 0.0;
        }
        private double getcumCredits()
        {
            double result = 0;
            //do calc
            if ((Globals.LoggedUser as Classes.Student).getSemester() == null)
                result = 0.0;
            
            else if (Int32.Parse((Globals.LoggedUser as Classes.Student).getSemester())==1)
            {
                result = 0.0;
            }
            else
            {
                 String query = "SELECT SUM(Points) FROM Courses WHERE Semester='" + (Globals.LoggedUser as Classes.Student).getSemester() + "'";
                 SqlCommand cmd = new SqlCommand(query, Globals.conn);
                 result = Convert.ToDouble(cmd.ExecuteScalar());
            }
            return result;
        }
        private void addPanelToTable(int day, int startTime, int endTime, string courseid, string coursename,string classnum,string Type)
        {
            //doing random colors          
            Thread.Sleep(20); //delaying.
            Random r = new Random();
            b = r.Next(1, 5);
            MetroFramework.Controls.MetroTile pan = new MetroFramework.Controls.MetroTile();

            switch (b)
            {
                case 1:
                    {
                        pan.Style = MetroFramework.MetroColorStyle.Lime;
                    }
                    break;
                case 2:
                    {
                        pan.Style = MetroFramework.MetroColorStyle.Green;
                    }
                    break;
                case 3:
                    {
                        pan.Style = MetroFramework.MetroColorStyle.Red;
                    }
                    break;

                case 4:
                    {
                        pan.Style = MetroFramework.MetroColorStyle.Brown;
                    }

                    break;
            }
            pan.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            pan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            pan.Dock = DockStyle.Fill;
            pan.Location = new Point(100, 100);
            this.table.Controls.Add(pan);
            this.table.Controls.Add(pan, (day - 1), (startTime - 7));
            this.table.SetRowSpan(pan, endTime - startTime + 1);


            pan.Text = "" + coursename+"-"+Type + "\n" + courseid + "\n" + classnum + "\n" + startTime + "-" + endTime;
            pan.Width = 100;
            pan.Height = 100;
            pan.Click += (sender, e) => panelButton(sender, e, coursename);

        }
        protected void panelButton(object sender, EventArgs e,string coursename)
        {
            CourseDetails cd = new CourseDetails(coursename,this);
            cd.ShowDialog();
        }
        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

        private void GetCompulsoryCourses()
        {
            // use a SqlAdapter to execute the query
            using (SqlDataAdapter b = new SqlDataAdapter("SELECT * FROM Courses where Semester='"+(Globals.LoggedUser as Classes.Student).getSemester()+ "'and Category='"+"Required"+"'", Globals.conn))
            {
                
                // fill a data table
                var t = new DataTable();
                b.Fill(t);
                if (t.Rows.Count == 0)
                {
                    compCoursesText.Items.Add("NO Registered Courses");
                    return;
                }
                foreach (DataRow row in t.Rows)
                {
                    if (!MyCourses.Items.Contains(row[1].ToString()))
                    {
                        compCoursesText.Items.Add(row[1]);
                    }
               }
            }
        }
        private void optional_Courses()
        {
            //getting the optional courses.
            using (SqlDataAdapter b = new SqlDataAdapter("SELECT * FROM Courses where Semester='" + (Globals.LoggedUser as Classes.Student).getSemester() + "'and Category='" + "Not Required" + "'", Globals.conn))//
            {

                // fill a data table//
                var t = new DataTable();
                b.Fill(t);
                if (t.Rows.Count == 0)
                {
                    OptionCourses.Items.Add("No Available Courses");
                    return;
                }
                foreach (DataRow row in t.Rows)
                {
                    if (!MyCourses.Items.Contains(row[1].ToString()))
                    {
                        OptionCourses.Items.Add(row[1]);
                    }
                }
            }
        }
        private void GetCoursesOfStudent()//
        {//
            //Getting the Relevant Courses of specific student//
            string Select = @"SELECT s.StudID, s.CourseID, c.Name, c.Semester
            FROM dbo.Login l 
	        INNER JOIN dbo.StudentCourses s ON ( l.Id = s.StudID  )  
		    INNER JOIN dbo.Courses c ON ( s.CourseID = c.CourseID  )  ";//
            using (SqlDataAdapter a = new SqlDataAdapter(Select, Globals.conn))//
            {//
                // fill a data table
                var t = new DataTable();//
                a.Fill(t); //
                //getting courses per semester and student id        
                foreach (DataRow row in t.Rows)//
                {//
                    //displaying to student suitable data.
                    if (row[3].ToString().Replace(" ","") == (Globals.LoggedUser as Classes.Student).getSemester().Replace(" ", "") && row[0].ToString().Replace(" ", "") == (Globals.LoggedUser as Classes.Student).getId().Replace(" ", ""))//
                    {//
                        MyCourses.Items.Add(row[2]);//
                    }//
                }//
            }//
        }    //
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }



        private void ControlPanelForm_Load(object sender, EventArgs e)
        {
            if ((Globals.LoggedUser as Classes.Student) != null)
                this.userNameLable.Text = "Welcome, " + (Globals.LoggedUser as Classes.Student).getName();
            else
            {
                Globals.LoggedUser = new Classes.Student();
                this.userNameLable.Text = "Welcome, Test User";
            }
            SemesterLbl.Text = "Current Semester:" + (Globals.LoggedUser as Classes.Student).getSemester();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {

        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void schdeulerWeeklyGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void OpenCourseDetails(string index)
        {
            Application.Run(new CourseDetails(index,this));
        }
        private void courselbl_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(BackToStudentPortal);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void BackToStudentPortal()
        {
            Application.Run(new Student());
        }
        private void MyCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MyCourses.SelectedItem == null)
                return;
            // use a SqlAdapter to execute the query
            string Item = MyCourses.GetItemText(MyCourses.SelectedItem);
            if (Item == "NO Registered Courses")
                return;
            CourseDetails ShowCourseDetails = new CourseDetails(Item,this);
            ShowCourseDetails.ShowDialog();
        }


        /*private void BuildCourse()
        {
            if (MyCourses.Items.Count != 0)
            {
                for (int i = 0; i < MyCourses.Items.Count; i++)
                {
                    Classes.Lesson ev = new Classes.Lesson();
                    
                }
            }
        }*/
        private void compCoursesText_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (compCoursesText.SelectedItem == null)
                return;
            //checking if student already registered to the specific course.
            foreach (string item in MyCourses.Items)
            {
                if (item == compCoursesText.GetItemText(compCoursesText.SelectedItem))
                {
                    MessageBox.Show("You are already registered to this course!", "Warning", MessageBoxButtons.OK);
                    return;
                }
            }
            //if not..
            //demo version of registering to course..//

            //Do Draw of the course so student can see hours. ==> #1



            //Do available hours of same course. ==> #2



            //Do registering.. and save to DB. ==> #3
                Project_12_A_B.Forms.Student.RegisterToCourse a = new Project_12_A_B.Forms.Student.RegisterToCourse(compCoursesText.GetItemText(compCoursesText.SelectedItem),this);
                a.ShowDialog();
               // MyCourses.Items.Add(compCoursesText.SelectedItem);

        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project_12_A_B.Forms.Student.SearchCourse a=new Project_12_A_B.Forms.Student.SearchCourse();
            a.ShowDialog();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void OptionCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OptionCourses.SelectedItem == null)
                return;
            Forms.Student.RegisterToCourse Reg = new Forms.Student.RegisterToCourse(OptionCourses.GetItemText(OptionCourses.SelectedItem).ToString(),this);
            Reg.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void UpdateBtn_Click(object sender, EventArgs e)
        {
            clearSchedule();
            createSchedule();
            compCoursesText.Items.Clear();
            OptionCourses.Items.Clear();
            MyCourses.Items.Clear();

            GetCoursesOfStudent();
            GetCompulsoryCourses();
            optional_Courses();
            //getting optional courses

            //Gettings Credits INFO
            remCred = getremaindCredits();
            cumCred = getcumCredits();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void table_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void table_Click(object sender, EventArgs e)
        {
          
        }

        private void table_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void table_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
