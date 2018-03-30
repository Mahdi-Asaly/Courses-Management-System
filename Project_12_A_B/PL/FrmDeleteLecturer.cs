using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Project_12_A_B.CodeLayer;
using Project_Sce.CodeLayer;

namespace Project_Sce.PL
{
    public partial class FrmDeleteLecturer : Form
    {
        private Project_12_A_B.PL.FormLecturers parent;

        public FrmDeleteLecturer()
        {
            InitializeComponent();
        }

        public FrmDeleteLecturer(Project_12_A_B.PL.FormLecturers parent_, string id_)
        {
            InitializeComponent();
            this.parent = parent_;
            this.Pid.Text = id_;
        }

        private void buttonRemoveLecturer_Click(object sender, EventArgs e)
        {
            /*
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=mahdias.database.windows.net;Initial Catalog=ProjectSCE;User ID=Mahdias;Password=Aa123123");
                SqlCommand cmd = new SqlCommand("delete from Lecturer where pid= @ID", con);
                cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = Pid.Text;
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd.ExecuteNonQuery();
                Pid.Clear();
                MessageBox.Show("The lecturer was successfully deleted from the database!", "Deleting Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) { string x = ex.ToString(); }
            */

            if (Pid.Text != "")
            {
                Handler h = new Handler();
                Lecturer toFindLecturer = new Lecturer(Pid.Text, null, null, null, null, null, default(DateTime), null, null, null, null, -1);
                Lecturer lecturer = h.Get<Lecturer>(toFindLecturer);
                if(lecturer != null)
                {
                    DialogResult agree = MessageBox.Show("Are you sure that you want to delete lecturer " + lecturer.FirstName + " " + lecturer.LastName, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (agree == DialogResult.Yes)
                    {
                        if(h.Delete<Lecturer>(lecturer))
                        {
                            if(this.parent != null)
                            {
                                this.parent.RefreshDataSource();
                            }
                            MessageBox.Show("The lecturer was successfully deleted from the database!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("There is a problem to delete this lecturer, please try again.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lecturer with ID " + toFindLecturer.ID + " not found!");
                }
            }
            else
            {
                MessageBox.Show("Please input Lecturer Passport ID");
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(Login);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void Login()
        {
            Application.Run(new LogIn());
        }

        private void Pid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
