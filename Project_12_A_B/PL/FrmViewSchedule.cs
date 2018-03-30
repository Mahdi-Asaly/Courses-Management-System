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

using System.Drawing;
using System.Drawing.Printing;

namespace Project_Sce.PL

{
    public partial class FrmViewSchedule : Form
    {

       
     
        DAL.DataBase DB;

        private string  User, Password;
        private string  LctID;



        public FrmViewSchedule()
        {

            InitializeComponent();


        }

        public FrmViewSchedule(string  user,string  pass)
        {
            InitializeComponent();
            DB = new DAL.DataBase();
            DB.open();


            this.Password = pass;
            this.User = user;
            LctID = getLectID();
            if(LctID==null)
            {
                MessageBox.Show("ID not found in the system!");
            }
            else if(LctID!=null)
                 loadDataToGrid();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmViewSchedule_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        private void loadDataToGrid()

        {
           
            string temp = "SELECT Lesson.Type, Lesson.ClassRoom,Lesson.LecturerID, Lesson.CourseID,Lesson.Day,Lesson.StrtTime,Lesson.EndTime ,Courses.CourseID,Courses.Name FROM Lesson INNER JOIN Courses ON Courses.CourseID=Lesson.CourseID ORDER BY Day";

            SqlCommand cmd = new SqlCommand(temp, DB.Return_Connection());

            try
            {
               SqlDataReader read = cmd.ExecuteReader();
              
                while (read.Read())
                {
                    if (LctID.Trim() == read["LecturerID"].ToString().Trim())
                    {
                        ListViewItem items = new ListViewItem(read["Day"].ToString());
                        items.SubItems.Add(read["ClassRoom"].ToString());
                        items.SubItems.Add(read["Type"].ToString());
                        items.SubItems.Add(read["CourseID"].ToString().Trim());
                        items.SubItems.Add(read["Name"].ToString().Trim());
                        items.SubItems.Add(read["StrtTime"].ToString());
                        items.SubItems.Add(read["EndTime"].ToString());
                        listView1.Items.Add(items);
                    }

                    }
                read.Close();
                read.Dispose();



            }
            catch(DataException exp)
            {
                MessageBox.Show(exp.Message);
            }
        }


        public void GoBack()
        {
            Application.Run(new FrmLecturer(User,Password));
        }


        private string getLectID()
        {
            string name = null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM  Lecturer", DB.Return_Connection());

            try
            {
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    //MessageBox.Show(read["id"].ToString().Trim());
                    if (read["id"].ToString().Trim()==this.User.ToString().Trim())
                    {

                        name = User;
                        read.Close();
                        read.Dispose();
                        return name;
                    }
                }
                read.Close();
                read.Dispose();
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
           
            return null;

        }

        
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoBack);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }



        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }


        Bitmap bmp;

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(listView1.Width, listView1.Height);
            listView1.DrawToBitmap(bmp, new Rectangle(0, 0, listView1.Width, listView1.Height));
            printPreviewDialog1.ShowDialog();
            //Print to printer

        }





    }

    
}
