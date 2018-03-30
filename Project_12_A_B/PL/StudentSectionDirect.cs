using Project_Sce.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Project_Sce.DAL;
using Project_Sce.CodeLayer;

namespace Project_12_A_B.PL
{
    public partial class StudentSectionDirect : Form
    {
        Project_Sce.CodeLayer.Student x = new Project_Sce.CodeLayer.Student();
        DataBase dl = new DataBase();
        Project_Sce.CodeLayer.Student std = new Project_Sce.CodeLayer.Student();
        public string Id;
        public StudentSectionDirect()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = std.Get_Courses(Id);
        }
        public StudentSectionDirect(string text)
        {
            InitializeComponent();
            Id = text;
            this.dataGridView1.DataSource = std.Get_Courses(Id);
            DataTable dt = x.Get_Student_Info(Id);
            
            foreach (DataRow row in dt.Rows)
            {
                StudentName.Text = row["Name"].ToString();
                StudentID.Text = row["StudID"].ToString();
                StudentAddress.Text = row["Address"].ToString();
                StudentEmail.Text = row["Email"].ToString();
                StudentName.ReadOnly = true;
                StudentID.ReadOnly = true;
                StudentAddress.ReadOnly = true;
                StudentEmail.ReadOnly = true;
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
