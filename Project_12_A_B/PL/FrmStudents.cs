using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;
using Project_12_A_B.PL;

namespace Project_Sce.PL
{
    public partial class FrmStudents : Form
    {
        
        Project_Sce.CodeLayer.Student std = new CodeLayer.Student();
        public FrmStudents()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = std.get_All_Students();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void AddStudBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(AddStud);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void DeleteStudBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(DeleteStud);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(EditStud);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void FrmStudents_Load(object sender, EventArgs e){}

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(AddStudentToCourse);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
            StudentSectionDirect std = new StudentSectionDirect();
            
            std.Show();
        }
        private void Sid_TextChanged(object sender, EventArgs e){}
        //work
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = std.Search_Student(textBox1.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void Open_Click(object sender, EventArgs e)
        {
            DataTable dt = std.Get_Courses(StudentID_txt.Text);
            
            try
            {
                if (dt.Rows.Count > 0)
                {
                    StudentSectionDirect st = new StudentSectionDirect(StudentID_txt.Text);
                    st.ShowDialog();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Incorrect ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            StudentID_txt.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
       
        public void DeleteStud()
        {
            Application.Run(new DeleteStudent());
        }
        public void AddStud()
        {
            Application.Run(new AddStudentform());
        }
        public void AddStudentToCourse()
        {
            Application.Run(new AssignStudent_To_Course());

        }
        public void EditStud()
        {
            Application.Run(new UpdateStudentInfo());
        }
    }
}
