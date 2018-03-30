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
    public partial class FrmDeleteLesson : Form
    {
        private DAL.DataBase DB = new DAL.DataBase();

        public FrmDeleteLesson()
        {
            InitializeComponent();
            DB.open();
            Populate();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (DeleteLessonLV.SelectedItems.Count == 1)
            {
                Delete_Btn.Enabled = true;
            }
            else
                Delete_Btn.Enabled = false;
        }

        private void Populate()
        {
           
            DeleteLessonLV.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM  Lesson ORDER BY CourseID", DB.Return_Connection());
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
                    items.SubItems.Add(read["strtTime"].ToString());
                    items.SubItems.Add(read["EndTime"].ToString());
                    items.SubItems.Add(read["Numofstud"].ToString());
                    DeleteLessonLV.Items.Add(items);

                }
                read.Close();
                read.Dispose();
                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        public void GoBack()
        {
            Application.Run(new FrmLessons());
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoBack);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {


            if(DeleteLessonLV.SelectedItems.Count==1)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Lesson WHERE CourseID = @id", DB.Return_Connection());
                cmd.Parameters.AddWithValue("@id", DeleteLessonLV.SelectedItems[0].SubItems[2].Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    Populate();
                    MessageBox.Show(this,"Success, Course has been deleted!","Message",MessageBoxButtons.OK);



                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }


            }
                  
        }

        private void FrmDeleteLesson_Load(object sender, EventArgs e)
        {

        }
    }
}
