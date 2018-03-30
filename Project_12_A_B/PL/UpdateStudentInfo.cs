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
using System.Threading;


namespace Project_Sce.PL
{
    public partial class UpdateStudentInfo : Form
    {
        private SqlConnection con;
        private string connectionS = "Data Source=mahdias.database.windows.net;Initial Catalog=ProjectSCE;User ID=Mahdias;Password=Aa123123";

        public UpdateStudentInfo()
        {
            InitializeComponent();
        }

        private void UpdateStudentInfo_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionS);
            con.Open();
            Populate();
        }

        private void Populate()
        {
            listView1.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM  Student ORDER BY StudID", con);
            try
            {
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    ListViewItem items = new ListViewItem(read["StudID"].ToString());

                    items.SubItems.Add(read["Name"].ToString());
                    items.SubItems.Add(read["Year"].ToString());
                    items.SubItems.Add(read["Average"].ToString());
                    items.SubItems.Add(read["Address"].ToString());
                    items.SubItems.Add(read["Email"].ToString());

                    listView1.Items.Add(items);

                }
                read.Close();
                read.Dispose();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                UpdateB.Enabled = true;
                
            }
            else
                UpdateB.Enabled = false;
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoBack);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void GoBack()
        {
            Application.Run(new Project_12_A_B.PL.FormStudents());
        }

        private void UpdateB_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(EditStud);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void EditStud()
        {
            Application.Run(new AddStudentform(true, listView1.SelectedItems[0].SubItems[0].Text.ToString()));

        }
    }
}
