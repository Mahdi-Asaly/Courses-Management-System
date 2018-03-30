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
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Project_12_A_B
{
    public partial class EditStudentInfoSec : MetroForm
    {
        string currentsems;
        public EditStudentInfoSec()
        {
            InitializeComponent();
            SemesterBox.Items.Add("1");
            SemesterBox.Items.Add("2");
            SemesterBox.Items.Add("3");
            SemesterBox.Items.Add("4");
            SemesterBox.Items.Add("5");
            SemesterBox.Items.Add("6");
            SemesterBox.Items.Add("7");
            SemesterBox.Items.Add("8");
        }

        private void EditStudentInfoSec_Load(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_Click(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void AddressLbl_Click(object sender, EventArgs e)
        {

        }

        private void NameLbl_Click(object sender, EventArgs e)
        {

        }

        private void SemesterLabel_Click(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            //string currentsems;
            if (NameTextBox.Text.ToString() == "" || Password.Text.ToString() == "" || EmailTextBox.Text.ToString() == "" || AddressTextBox.Text.ToString() == "")
            {
                MessageBox.Show("No Changes has been maded !", "Notification", MessageBoxButtons.OK);
                this.Close();
                return;
            }
            string id, name, pass, email, address,sem;
            id = name = pass = email = address=sem = null;
            id = StudIDTextBox.Text.ToString();
            name = NameTextBox.Text.ToString();
            pass = PasswordTextBox.Text.ToString();
            address = AddressTextBox.Text.ToString();
            email = EmailTextBox.Text.ToString();
            sem = SemesterBox.Text.ToString();


            if(sem == "" ||name=="" ||pass== "")
            {
                MessageBox.Show("ERROR: One or more field are empty\n- Check Semester Option\n- Name Field\n- Password Field", "ERROR", MessageBoxButtons.OK);
                return;
            }

            if(Int32.Parse(currentsems)!=Int32.Parse(sem))
            {
                DialogResult result = MessageBox.Show("Are you sure that you want to change the student semester?\nNOTE: Changing Semster will REMOVE current student courses!!!","WARNING",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //delete student current courses
                    //check if grades of courses > 56.
                    //and calculate the points of course.
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM StudentCourses WHERE StudID = @ID", Globals.conn))
                        {

                                    cmd.CommandText = "DELETE FROM StudentCourses WHERE StudID = @ID";
                                    cmd.Parameters.AddWithValue("@ID", id);
                                    cmd.ExecuteNonQuery();
                            
                        }
                    }
                    catch
                    {
                        MessageBox.Show("An exception while removing courses of student.");
                    }
                }
                else if (result == DialogResult.No)
                {
                    //Do nothing.
                    sem = currentsems;
                }
            }
            Boolean Res=Globals.GlobalSecretary.SaveStudentInfo(id, name, pass, address, email, sem);
            if (Res)
            {
                //inform the user.
                MessageBox.Show("SUCCESS: Details has been successfully changed!", "Modify Profile", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("ERORR: Details were not saved", "ERROR", MessageBoxButtons.OK);
            }

            Close();
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {

        }

        private void NameTextBox_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }
        private void FindBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Login where id='" + IdTextBox.Text.ToString() + "'" + "and Permission=0", Globals.conn))
                {
                    sda.Fill(dt);
                    if (dt.Rows.Count <= 0)
                    {
                        MessageBox.Show("Invalid Input or there are no id such this!");
                        return;
                    }
                    //////////////////////////////////////////////////
                    StudIDTextBox.Text = dt.Rows[0][0].ToString();
                    NameTextBox.Text = dt.Rows[0][1].ToString();
                    PasswordTextBox.Text = dt.Rows[0][2].ToString();
                    AddressTextBox.Text = dt.Rows[0][7].ToString();
                    EmailTextBox.Text = dt.Rows[0][5].ToString();
                    SemesterBox.Items.Add(dt.Rows[0][6].ToString());
                    currentsems = SemesterBox.Items[0].ToString();
                    ///////////////////////////////////////////////////
                            metroLabel1.Visible = true;
                            ID.Visible = true;
                            NameLbl.Visible = true;
                            Password.Visible = true;
                            AddressLbl.Visible = true;
                            metroLabel3.Visible = true;
                            SemesterLabel.Visible = true;
                            StudIDTextBox.Visible = true;
                            NameTextBox.Visible = true;
                            PasswordTextBox.Visible = true;
                            AddressTextBox.Visible = true;
                            EmailTextBox.Visible = true;
                            SemesterBox.Visible = true;
                    ////////////////////////////////////////////////////
                }
            }
            catch
            {
                MessageBox.Show("unExpected ERROR Occured!", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void SemesterBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
