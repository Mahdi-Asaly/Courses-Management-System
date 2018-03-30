using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework.Forms;
namespace Project_12_A_B
{
    public partial class CourseDetails : MetroForm
    {
        private Schedule studScheudle;
        public Boolean isValidName(string cname)
        {
            if (cname == "" || cname == null)
                return false;
            else
                return true;
        }
        public CourseDetails(string cname, Schedule _st)
        {
            InitializeComponent();
            if (isValidName(cname))
            {
                this.studScheudle = _st;
                this.CenterToScreen();
                using (SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Courses WHERE Name='" + cname + "'", Globals.conn))
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
        }

        private void CourseDetails_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void CourseNameText_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            (Globals.LoggedUser as Classes.Student).removeCourse(CourseIdText.Text.ToString());
            studScheudle.UpdateBtn_Click(sender, e);
            this.Close();
        }

        private void AvailableSlotsText_Click(object sender, EventArgs e)
        {

        }
    }
}
