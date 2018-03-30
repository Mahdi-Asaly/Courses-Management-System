                        /**
                         *@Author Mahdi Asali 
                         * */


//Here we display to student course information , including the ability to register to the course
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
namespace Project_12_A_B.Forms.Student
{
    public partial class RegisterToCourse : MetroForm
    {
        private Schedule studScheudle;
        public RegisterToCourse(string index , Schedule _st )
        {

            InitializeComponent();
            this.studScheudle = _st;
            this.CenterToScreen();
            //////////////////////////////////////////////

            using (SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Courses WHERE Name='" + index + "'", Globals.conn))
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
                try
                {
                    using (SqlDataAdapter b = new SqlDataAdapter("SELECT * FROM Lesson WHERE CourseID='" + CourseIdText.Text.ToString() + "'", Globals.conn))
                    {
                        // fill a data table
                        var Table = new DataTable();
                        b.Fill(Table);
                        AvailableSlotsText.Text = Table.Rows[0][7].ToString();
                        for (int i = 0; i < Table.Rows.Count; i++)
                        {
                            DaySECombo.Items.Add(Table.Rows[i][3].ToString());
                        }
                    }
                }
                catch
                {
                    return;
                }
            }
        }

        public void RegisterToCourse_Load(object sender, EventArgs e)
        {

        }

        public void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (DaySECombo.SelectedItem==null)
            {
                MessageBox.Show("You have to select a lecturer!", "ERROR", MessageBoxButtons.OK);
                return;
            }
            (Globals.LoggedUser as Classes.Student).registertoCourse(CourseIdText.Text.ToString(), DaySECombo.GetItemText(DaySECombo.SelectedItem));
            studScheudle.UpdateBtn_Click(new object(), new EventArgs());
            this.Close();

        }

        public void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
