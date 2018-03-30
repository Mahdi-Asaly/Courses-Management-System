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
namespace Project_12_A_B
{
    public partial class RemoveStudentCourses : MetroForm
    {
        private string StudID = null;
        private EditStudentSchedule StudSchedule;

        public RemoveStudentCourses(string coursename,string studid, EditStudentSchedule _StudSchedule)
        {
            InitializeComponent();
            this.StudSchedule = _StudSchedule;
            this.StudID = studid;
            this.CenterToScreen();
            using (SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Courses WHERE Name='" + coursename + "'", Globals.conn))
            {
                // fill a data table
                var t = new DataTable();
                a.Fill(t);
                CourseIdText.Text = t.Rows[0][0].ToString();
                CourseNameText.Text = t.Rows[0][1].ToString();
                CourseHoursText.Text = t.Rows[0][2].ToString();
                CoursePointsText.Text = t.Rows[0][3].ToString();
                CourseCatagoryText.Text = t.Rows[0][4].ToString();
                CourseLabText.Text = t.Rows[0][5].ToString();
                CoursePractitionText.Text = t.Rows[0][6].ToString();
            }
            try
            {
                using (SqlDataAdapter b = new SqlDataAdapter("SELECT * FROM Lesson WHERE CourseID='" + CourseIdText.Text.ToString() + "'", Globals.conn))
                {

                    // fill a data table
                    var Table = new DataTable();
                    b.Fill(Table);
                    AvailableSlotsText.Text = Table.Rows[0][7].ToString();
                }
            }
            catch
            {
                return;
            }
        }

        private void RemoveStudentCourses_Load(object sender, EventArgs e)
        {

        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            Boolean res = false;
            res = Globals.GlobalSecretary.removeCourse(CourseIdText.Text.ToString(),StudID);
            if (res)
                MessageBox.Show("Successfully removed course:" + CourseIdText.Text.ToString() + ",from student id:" + StudID,"SUCCESS",MessageBoxButtons.OK);
            StudSchedule.FindBtn_Click(sender,e);

            this.Close();
        }
    }
}
