using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sce.PL
{
    public partial class FrmEditLesson : Form
    {
        CodeLayer.Lesson l = new CodeLayer.Lesson();
        public FrmEditLesson()
        {
            InitializeComponent();
            listView1.FullRowSelect=true;
            Populate();
        }

        private void Populate()
        {
            listView1.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM  Lesson", DAL.DataBase.Instance.Con);
            try
            {
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    ListViewItem items = new ListViewItem(read["Type"].ToString());

                    items.SubItems.Add(read["ClassRoom"].ToString());
                    items.SubItems.Add(read["CourseID"].ToString());
                    items.SubItems.Add(read["LecturerID"].ToString());
                    items.SubItems.Add(read["Day"].ToString());
                    items.SubItems.Add(read["StrtTime"].ToString());
                    items.SubItems.Add(read["EndTime"].ToString());
                    items.SubItems.Add(read["Numofstud"].ToString());
                    items.SubItems.Add(read["Id"].ToString());
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

        private void btnEditLec_Click(object sender, EventArgs e)
        {

        }

        private void lecturer_cat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void end_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            (new updateLesson(listView1.SelectedItems[0].SubItems[0].Text.ToString(), listView1.SelectedItems[0].SubItems[1].Text.ToString(), listView1.SelectedItems[0].SubItems[3].Text.ToString(), listView1.SelectedItems[0].SubItems[4].Text.ToString(), listView1.SelectedItems[0].SubItems[5].Text.ToString(), listView1.SelectedItems[0].SubItems[6].Text.ToString(), listView1.SelectedItems[0].SubItems[8].Text.ToString())).Show();
        }



        private void Return_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoBack);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void GoBack()
        {
            Application.Run(new FrmLessons());
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(Login);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Login()
        {
            Application.Run(new LogIn());
        }

        private void FrmEditLesson_Load(object sender, EventArgs e)
        {
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                editBtn.Enabled = true;

            }
            else
                editBtn.Enabled = false;
        }
    }
}
