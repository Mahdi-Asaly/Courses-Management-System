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
using MetroFramework.Forms;
namespace Project_12_A_B
{
    public partial class Permissions : MetroForm
    {
        public Permissions()
        {
            InitializeComponent();
        }

        private void Permissions_Load(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void FindBtn_Click(object sender, EventArgs e)
        {
            //Gettings details of student such name id sem etc..
            string currentperm; //current permission of the searched USER.
            DataTable dt = new DataTable();
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Login where id='" + IDText.Text.ToString() + "'", Globals.conn))
                {
                    sda.Fill(dt);
                    if (dt.Rows.Count <= 0)
                    {
                        MessageBox.Show("Invalid Input or there are no id such this!");
                        return;
                    }
                    //////////////////////////////////////////////////
                    IDText.Text = dt.Rows[0][0].ToString();
                    NameTextBox.Text = dt.Rows[0][1].ToString();
                    PasswordTextBox.Text = dt.Rows[0][2].ToString();
                    AddressTextBox.Text = dt.Rows[0][7].ToString();
                    EmailTextBox.Text = dt.Rows[0][5].ToString();
                    currentperm = dt.Rows[0][3].ToString();
                    ///////////////////////////////////////////////////

                    ///////////////////////////////////////////////////
                }
            }
            catch
            {
                MessageBox.Show("unExpected ERROR Occured!", "ERROR", MessageBoxButtons.OK);
                return;
            }

            if(currentperm!=null && currentperm!="")
            {
                if(Int32.Parse(currentperm)==0)
                {
                    //Student.
                    PermTextBox.Text = "Student";
                }
                else if (Int32.Parse(currentperm) == 1)
                {
                    //Secretary.
                    PermTextBox.Text = "Secretary";

                }
                else if(Int32.Parse(currentperm) == 2)
                {
                    //Admin.
                    PermTextBox.Text = "Admin";

                }
                else if(Int32.Parse(currentperm) == 3)
                {
                    //Technican.
                    PermTextBox.Text = "Technican";

                }
                else
                {
                    PermTextBox.Text = "Unknown";
                }

                //adding the available list.
                AvailablePerm.Items.Add("Admin");
                AvailablePerm.Items.Add("Student");
                AvailablePerm.Items.Add("Secretary");
                AvailablePerm.Items.Add("Technician");



            }

        }


        //saving button
        private void metroTile1_Click(object sender, EventArgs e)
        {

            string Item = null; //item to save next permission or choosed perm.
            if (AvailablePerm.SelectedItem == null)
            {
                DialogResult result;
                result = MessageBox.Show("No specified Permission choosed , are you sure that you want to close?", "WARNING", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Close(); //closing 
                    return;
                }
                else
                {
                    return; //donothing.
                }
            }

            else
            {
                Item = AvailablePerm.GetItemText(AvailablePerm.SelectedItem);
                //Admin may choose same Permission that User have it :| .
                if (PermTextBox.Text.ToString() == Item.ToString())
                {
                    MessageBox.Show("No changes , User already " + Item + ".");
                    this.Close();
                }
                //if not choosed.. we have to save the data.
                else
                {
                    //user maybe student thus we'v to delete his/her information (courses,etc..).
                    if (PermTextBox.Text.ToString() == "Student" && Item != "Student")
                    {
                        //let's delete his/her data if there are  :D 
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand("DELETE FROM StudentCourses WHERE StudID= @StudID", Globals.conn))
                            {
                                cmd.CommandText = "DELETE FROM StudentCourses WHERE StudID= @StudID";
                                cmd.Parameters.AddWithValue("@StudID", IDText.Text.ToString());
                                cmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Successfully removed student with id:" + IDText.Text.ToString(), "DONE!", MessageBoxButtons.OK);
                        }
                        catch
                        {
                            MessageBox.Show("unExpected ERROR Occured!", "ERROR", MessageBoxButtons.OK);
                        }
                    }
                    //let's change the permission.
                    if (Item == "Admin")
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Login SET Permission=@Permission" + " WHERE Id=@Id", Globals.conn);
                            cmd.Parameters.AddWithValue("@Id", IDText.Text.ToString());
                            cmd.Parameters.AddWithValue("@Permission", 2);
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("ERROR: An error occured while saving data\n" + a.ToString());
                        }
                    }
                    else if (Item == "Student")
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Login SET Permission=@Permission, Semester=@Semester" + " WHERE Id=@Id", Globals.conn);
                            cmd.Parameters.AddWithValue("@Id", IDText.Text.ToString());
                            cmd.Parameters.AddWithValue("@Semester", 1); //because everystudent have semester and this "NEW" User so he /she get sem 1.                        
                            cmd.Parameters.AddWithValue("@Permission", 0);
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("ERROR: An error occured while saving data\n" + a.ToString());
                        }
                    }
                    else if (Item == "Secretary")
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Login SET Permission=@Permission" + " WHERE Id=@Id", Globals.conn);
                            cmd.Parameters.AddWithValue("@Id", IDText.Text.ToString());
                            cmd.Parameters.AddWithValue("@Permission", 1);
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("ERROR: An error occured while saving data\n" + a.ToString());
                        }
                    }
                    else if (Item == "Technician")
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE Login SET Permission=@Permission" + " WHERE Id=@Id", Globals.conn);
                            cmd.Parameters.AddWithValue("@Id", IDText.Text.ToString());
                            cmd.Parameters.AddWithValue("@Permission", 3);
                            cmd.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("ERROR: An error occured while saving data\n" + a.ToString());
                        }
                    }
                }
            }
            MessageBox.Show("Successfully updated id:" + IDText.Text.ToString() + " details to be:" + Item);
            this.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
