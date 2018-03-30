using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace Project_12_A_B.Forms.Student
{
    public partial class PersonalInfoStudent : MetroForm
    {
        public PersonalInfoStudent()
        {
            InitializeComponent();
            //put the current data of student.
            IdTextBox.Text = Globals.LoggedUser.getId();
            NameTextBox.Text = Globals.LoggedUser.getName();
            EmailTextBox.Text = Globals.LoggedUser.getMail();
            PasswordTextBox.Text = Globals.LoggedUser.getPwd();
            AddressTextBox.Text = Globals.LoggedUser.getAddress();
        }

        private void metroProgressBar1_Click(object sender, EventArgs e)
        {

        }



        private void PersonalInfoStudent_Load(object sender, EventArgs e)
        {

        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }
        public Boolean isValidText(string text)
        {
            if (text == "" || text == null)
                return false;
            else
                return true;
        }
        private void savebtn_Click_1(object sender, EventArgs e)
        {
            //if (NameTextBox.Text.ToString() == "" || PasswordTextBox.Text.ToString() == "")
            //{
            //    MessageBox.Show("Missing one or more field empty!", "ERROR", MessageBoxButtons.OK);
            //    return;
            //}
            if (!isValidText(NameTextBox.Text.ToString()) || !isValidText(PasswordTextBox.Text.ToString()))
            {
                MessageBox.Show("Missing one or more field empty!", "ERROR", MessageBoxButtons.OK);
                return;
            }
            //updating the details .

            Globals.LoggedUser.setName(NameTextBox.Text.ToString());
            Globals.LoggedUser.setPwd(PasswordTextBox.Text.ToString());
            //Globals.LoggedUser.setSemester(SemBox.Text.ToString());
            Globals.LoggedUser.setMail(EmailTextBox.Text.ToString());
            Globals.LoggedUser.setAddress(AddressTextBox.Text.ToString());

            //saving to database.
            Globals.LoggedUser.saveData(Globals.LoggedUser.getId());

            
            //inform the user.
            MessageBox.Show("Details has been successfully changed!", "Modify Profile", MessageBoxButtons.OK);
            Close();
        }

        private void AddressTextBox_Click(object sender, EventArgs e)
        {

        }

        private void SemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You are not authorized to change Semester Yet!");
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void AddressLbl_Click(object sender, EventArgs e)
        {

        }

        private void NameLbl_Click(object sender, EventArgs e)
        {

        }

        private void SemesterLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {

        }

        private void NameTextBox_Click(object sender, EventArgs e)
        {

        }

        private void IdTextBox_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
