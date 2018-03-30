using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_12_A_B.PL
{
    public partial class FormClassroomDetails : Form
    {
        public FormClassroomDetails()
        {
            InitializeComponent();
        }

        public FormClassroomDetails(string className)
        {
            InitializeComponent();
            this.labelClassName.Text = className;
        }

        private void FormClassroomDetails_Load(object sender, EventArgs e)
        {
            CodeLayer.Handler h = new CodeLayer.Handler();
            Project_Sce.CodeLayer.Classroom classroom = h.Get<Project_Sce.CodeLayer.Classroom>(new Project_Sce.CodeLayer.Classroom(this.labelClassName.Text, -1, new bool(), new bool()));
            if(classroom != null)
            {
                if (classroom.Projector)
                {
                    this.labelIsProjector.Text = "✔";
                    this.labelIsProjector.ForeColor = Color.FromArgb(0,255,0);
                }
                if (classroom.Computer)
                {
                    this.labelIsComputer.Text = "✔";
                    this.labelIsComputer.ForeColor = Color.FromArgb(0, 255, 0);
                }
                this.label1.Text = classroom.SeatsNum.ToString();
                DataTable dt = h.GetDataTable<Project_Sce.CodeLayer.Lesson>(new Project_Sce.CodeLayer.Lesson(null, this.labelClassName.Text, null, null, null, -1, -1));
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error, can't get this class from database.");
            }
        }

        private void labelSeatsNum_Click(object sender, EventArgs e)
        {

        }
    }
}
