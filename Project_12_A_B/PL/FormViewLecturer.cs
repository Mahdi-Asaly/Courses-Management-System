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
using Project_Sce.CodeLayer;
using Project_12_A_B.CodeLayer;
using System.Threading;
using Project_12_A_B.PL;

namespace Project_Sce.PL
{

    public partial class FormViewLecturer : Form
    {

        //DAL.DataBase dal = new DAL.DataBase();

        public FormViewLecturer()
        {
            InitializeComponent();
            //dal.open();
        }

        public FormViewLecturer(string id_)
        {
            InitializeComponent();
            this.labelID_.Text = id_;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void first_name_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void groupBoxPersonalData_Enter(object sender, EventArgs e)
        {

        }

        private void FormViewLecturer_Load(object sender, EventArgs e)
        {
            Handler h = new Handler();
            Lecturer lecturer = h.Get<Lecturer>(new Lecturer(labelID_.Text, null, null, null, null, null, default(DateTime), null, null, null, null, -1));
            if(lecturer != null)
            {
                this.labelFirstName_.Text = lecturer.FirstName;
                this.labelLastName_.Text = lecturer.LastName;
                this.labelDegree_.Text = lecturer.Degree;
                this.labelBirthDay_.Text = lecturer.BirthDay.ToString();
                this.labelHoursPerWeek_.Text = lecturer.HoursPerWeek.ToString();
                this.labelDepartment_.Text = lecturer.Department;
                this.labelPhoneNumber_.Text = lecturer.Tel;
                this.labelEmail_.Text = lecturer.Email;
                this.labelAddress_.Text = lecturer.Address;
            }
            else
            {
                MessageBox.Show("Lecturer not found!");
                this.Close();
            }
        }
        
        private void Return(object sender, FormClosedEventArgs e)
        {
        }
        
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPassportId_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxContactInformation_Enter(object sender, EventArgs e)
        {

        }
    }
}
