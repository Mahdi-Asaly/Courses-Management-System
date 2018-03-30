using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using Project_12_A_B.PL;
namespace Project_Sce.PL
{
    public partial class AssignStudent_To_Course : Form
    {
        private SqlConnection con;
        private string connectionS = "Data Source=mahdias.database.windows.net;Initial Catalog=ProjectSCE;User ID=Mahdias;Password=Aa123123";
        private int year = 0;
        private int semest = 0;
        private static int count = 1;

        public AssignStudent_To_Course()
        {
            InitializeComponent();
        }

        public AssignStudent_To_Course(string studentId)
        {
            InitializeComponent();
            this.Id_TextBox.Text = studentId;
        }

        private void AssignStudent_To_Course_Load(object sender, EventArgs e)
        {

        }


        private void Return_Button_Click(object sender, EventArgs e)
        {
            //con.Close();

            this.Close();
            Thread th = new Thread(GoBack);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();


        }

        public void GoBack()
        {
            Application.Run(new FormStudents());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            count = 1;
            Course_LV.Items.Clear();
            Clear_All();
        }

        private void ID_LABEL_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        { //When Inserting Student's ID, It pulls all his data from Database//


            int flag = 0;
            con = new SqlConnection(connectionS);

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Student", con);

                SqlDataReader read = cmd.ExecuteReader();



                while (read.Read())
                {

                    if (Id_TextBox.Text.Trim() == read["StudID"].ToString().Trim() && count == 1)
                    {
                        Student_LV.Items[0].Text += Id_TextBox.Text;
                        Student_LV.Items[1].Text += read["Name"].ToString().Trim();
                        Student_LV.Items[2].Text += read["Year"].ToString().Trim();
                        year = int.Parse(read["Year"].ToString().Trim());
                        Student_LV.Items[3].Text += read["Average"].ToString().Trim();
                        Student_LV.Items[4].Text += read["Address"].ToString().Trim();
                        Student_LV.Items[5].Text += read["Email"].ToString().Trim();
                        Student_LV.Items[6].Text += read["Semester"].ToString().Trim();
                        semest = int.Parse(read["Semester"].ToString().Trim());
                        flag++;
                        count++;
                    }


                }
                read.Close();
                if (flag == 1)
                {
                    Course_Pull();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        

        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Course_LV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Course_Pull()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Courses", con);
            SqlDataReader read = cmd.ExecuteReader();
            //When Student found, it pulls from database all Relevant courses according to his academic year and semester//
            try
            {

                while (read.Read())
                {
                    if (year >= Int32.Parse(read["Year"].ToString().Trim()) && semest == Int32.Parse(read["Semester"].ToString().Trim()))
                    {
                        ListViewItem items = new ListViewItem(read["CourseID"].ToString());
                        items.SubItems.Add(read["Name"].ToString());
                        items.SubItems.Add(read["HoursPerWeek"].ToString());
                        items.SubItems.Add(read["Points"].ToString());
                        items.SubItems.Add(read["Category"].ToString());
                        items.SubItems.Add(read["Lab"].ToString());
                        items.SubItems.Add(read["Practition"].ToString());
                        items.SubItems.Add(read["Semester"].ToString());
                        items.SubItems.Add(read["RegisterOption"].ToString());
                        items.SubItems.Add(read["Year"].ToString());

                        Course_LV.Items.Add(items);

                    }

                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            read.Close();

        }

        private void Clear_All()
        {//Clearing all for re-enter new ID//

            Student_LV.Items[0].Text = "Id : ";
            Student_LV.Items[1].Text = "Name : ";
            Student_LV.Items[2].Text = "Academic Year : ";
            Student_LV.Items[3].Text = "Average : ";
            Student_LV.Items[4].Text = "Address : ";
            Student_LV.Items[5].Text = "Email : ";
            Student_LV.Items[6].Text = "Semester : ";

        }

        private bool RegisterToCourse()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM CourseStudentTable", con);
            SqlDataReader read = cmd.ExecuteReader();
            try
            {

                while (read.Read())
                {
                    if (read["StudID"].ToString().Trim() == Id_TextBox.Text.ToString().Trim() && read["CourseID"].ToString().Trim() == Course_LV.SelectedItems[0].Text)
                    {
                        read.Dispose();
                        read.Close();
                        MessageBox.Show("Student already exist in this Course!");
                        return false; // ALREADY REGISTERED. CANNOT REGISTER AGAIN//
                    }
                    
                }

            }catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            read.Dispose();
            read.Close();

            return true;

            
        }

        private bool AssignToLesson()
        {
            bool ans;
            int seats = 0;
            string class_name;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Lesson", con);
            SqlDataReader read = cmd.ExecuteReader();

            try
            {
                while (read.Read())

                {
                    if (Course_LV.SelectedItems[0].Text == read["CourseID"].ToString().Trim())
                    {
                        seats = Int32.Parse(read["Numofstud"].ToString().Trim());
                        class_name = read["ClassRoom"].ToString().Trim();
                        read.Close();
                        ans = CheckRoomSpace(seats, class_name);
                        if (ans == true)
                        {
                            seats += 1;
                            UpdateAmountClass(seats);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show(this, "No more seats available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }


                    }
                }
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
            MessageBox.Show(this, "Course id not found ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return false;
        }
        private bool CheckRoomSpace(int seats,string class_name)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Class", con);
            SqlDataReader read = cmd.ExecuteReader();
            int flag = 0;
            try {
                while(read.Read())
                {
                    if(class_name == read["name"].ToString().Trim())
                    {
                        int SeatsOFClass = Int32.Parse(read["seats_num"].ToString().Trim());
                        if (seats < SeatsOFClass)
                        {
                            read.Close();
                            return true; // available to register class
                        }
                        else
                        {
                            flag = 1;
                            MessageBox.Show("No more class seats available!");
                        }

                    }
              
                }
            }catch(SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
            if (flag == 0)
            {
                MessageBox.Show("Class "+ class_name+" not found!");
            }
            read.Close();
            return false;
        }


        private void UpdateAmountClass(int seats)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Lesson SET Numofstud=@num WHERE CourseID="+Course_LV.SelectedItems[0].Text, con);

            try
            {
                cmd.Parameters.AddWithValue("@num", seats);
                cmd.ExecuteNonQuery();

            }catch(SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }



        }

        private void RegisterBUTTON_Click(object sender, EventArgs e)
        {
            bool answer, answer2;

            if (Course_LV.SelectedItems.Count == 1)
            {
                answer = RegisterToCourse();
                answer2 = AssignToLesson();

                if (answer == true && answer2 == true)
                {
                    try
                    {
                        SqlCommand com = new SqlCommand("INSERT INTO CourseStudentTable(StudID,CourseID) VALUES(@studid,@courseid)", con);

                        com.Parameters.AddWithValue("@studid", Int32.Parse(Id_TextBox.Text.ToString().Trim()));
                        com.Parameters.AddWithValue("@courseid", Int32.Parse(Course_LV.SelectedItems[0].Text.ToString().Trim()));
                        com.ExecuteNonQuery();


                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                    MessageBox.Show("success");




                }
                


            }
            else
                MessageBox.Show(this, "Must select a row", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
