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
namespace Project_12_A_B.Forms.Student
{
    public partial class SearchCourse : MetroForm
    {
        public SearchCourse()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            String coursID = textBox1.Text;// varible to save the input 
            textBox1.Clear();// clear the textbox 
            if (Globals.conn.State != ConnectionState.Open)//cheak if the connection is not open
            {
                Globals.conn.Open();// open the connection
            }
            String query = "select Name from Courses where CourseID = '" + coursID + "'";// to get Name of Course ID
            SqlCommand cmd = new SqlCommand(query, Globals.conn);
            SqlDataReader dbr;
            dbr = cmd.ExecuteReader();
            if (dbr.HasRows)
            {// cheak if the Condition have row
                while (dbr.Read())// to read row row to get the correct name of course
                {

                    MessageBox.Show("the course :" + dbr[0].ToString());// show the Messgae of Course Name
                }
                dbr.Close();
            }
            else// if the input is not correct or not exixt
            {
                MessageBox.Show("the ID yor select is not correct or the courset not exiect please Try Again  ");
                dbr.Close();
            }
        }
        public Boolean CheckInput(String courseID)
        {
            if (courseID == "" || courseID == null)
                return false;
            else
                return true;
        }
        private void label6_Click(object sender, EventArgs e)
        {
            if (CheckInput(textBox2.Text))
            {
                String coursID1 = textBox2.Text;// Varible to save the input 
                textBox2.Clear();// clear the textbox
                if (Globals.conn.State != ConnectionState.Open)// if we dont have a connection
                {
                    Globals.conn.Open();// then open th concection
                }
                String query = "select * from Courses where CourseID = '" + coursID1 + "'";// what we want of sql to search in table
                SqlCommand cmd = new SqlCommand(query, Globals.conn);
                SqlDataReader dbr;
                dbr = cmd.ExecuteReader();
                if (dbr.HasRows)// cheak if the Condition have row 
                {
                    // to show the result in tuble
                    dataGridView1.Visible = true;

                    DataTable dt = null;

                    dt = new DataTable();//make Data Table 

                    dt.Load(dbr);

                    dataGridView1.DataSource = dt;
                }
                else// if the id isnot correct or is not exixt
                {
                    MessageBox.Show("the ID yor select is not correct or the courset not exiect please Try Again ");
                    dbr.Close();
                }
            }
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchCourse_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
