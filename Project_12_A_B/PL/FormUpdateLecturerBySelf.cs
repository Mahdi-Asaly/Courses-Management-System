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

namespace Project_Sce.PL
{

    public partial class FormUpdateLecturerBySelf : Form
    {

        //DAL.DataBase dal = new DAL.DataBase();
        private FrmLecturer parent;
        public FormUpdateLecturerBySelf()
        {
            InitializeComponent();
        }

        public FormUpdateLecturerBySelf(string id)
        {
            InitializeComponent();
            this.textBoxID.Text = id;
        }
        
        public FormUpdateLecturerBySelf(FrmLecturer parent_)
        {
            InitializeComponent();
            this.parent = parent_;
            this.textBoxID.Text = this.parent.user;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void first_name_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDegree__SelectedIndexChanged(object sender, EventArgs e)
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
            OpenFileDialog OpenFd = new OpenFileDialog();
            OpenFd.Filter = "Images only. |*.jpg; *.jpeg; *.png; *.gif";

            DialogResult dr = OpenFd.ShowDialog();

            imgPictureBox.Image = Image.FromFile(OpenFd.FileName);
            //img_pathLabel1.Text = OpenFd.FileName;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool isValidData()
        {
            bool result = true;

            label22.Text = "";
            labelWar2.Text = "";
            labelWar3.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label9.Text = "";

            if (String.IsNullOrEmpty(textBoxID.Text))
            {
                label22.Text = "Empty field!";
                result = false;
            }

            if (String.IsNullOrEmpty(textBoxFirstName_.Text))
            {
                labelWar2.Text = "Empty field!";
                result = false;
            }
            else
            {
                int n;
                bool isNumeric = int.TryParse(textBoxFirstName_.Text, out n);
                if (isNumeric || textBoxFirstName_.Text.Length < 2 || textBoxFirstName_.Text.Length > 49)
                {
                    labelWar2.Text = "Enter correct first name";
                    result = false;
                }
            }

            if (String.IsNullOrEmpty(textBoxLastName_.Text))
            {
                labelWar3.Text = "Empty field!";
                result = false;
            }
            else
            {
                int n;
                bool isNumeric = int.TryParse(textBoxLastName_.Text, out n);
                if (isNumeric || textBoxLastName_.Text.Length < 2 || textBoxLastName_.Text.Length > 49)
                {
                    labelWar3.Text = "Enter correct last name";
                    result = false;
                }
            }

            if (String.IsNullOrEmpty(textBoxTel.Text))
            {
                label13.Text = "Empty field!";
                result = false;
            }
            else
            {
                if (textBoxTel.Text.Length < 9 || textBoxTel.Text.Length > 49)
                {
                    label13.Text = "Enter correct phone number";
                    result = false;
                }
            }

            if (String.IsNullOrEmpty(textBoxEmail.Text))
            {
                label14.Text = "Empty field!";
                result = false;
            }
            else
            {
                if (!this.IsValidEmail(textBoxEmail.Text))
                {
                    label14.Text = "Enter correct email";
                    result = false;
                }
            }

            if (String.IsNullOrEmpty(textBoxAddress.Text))
            {
                label17.Text = "Empty field!";
                result = false;
            }
            else
            {
                if (textBoxAddress.Text.Length < 2 || textBoxAddress.Text.Length > 49)
                {
                    label17.Text = "Enter correct address";
                    result = false;
                }
            }

            if (String.IsNullOrEmpty(textBoxLogin.Text))
            {
                label15.Text = "Empty field!";
                result = false;
            }
            else
            {
                if (textBoxLogin.Text.Length < 2 || textBoxLogin.Text.Length > 49)
                {
                    label15.Text = "Enter correct login";
                    result = false;
                }
            }

            if (String.IsNullOrEmpty(textBoxPassword.Text))
            {
                label16.Text = "Empty field!";
                result = false;
            }
            else
            {
                if (textBoxPassword.Text.Length < 2 || textBoxPassword.Text.Length > 49)
                {
                    label16.Text = "Enter correct password 8-14 diggits";
                    result = false;
                }
            }

            return result;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            if(this.isValidData())
            {
                Handler h = new Handler();

                //Create new Lecturer object
                Lecturer lecturer = new Lecturer(textBoxID.Text, textBoxFirstName_.Text, textBoxLastName_.Text, textBoxAddress.Text, textBoxEmail.Text, textBoxTel.Text, dateTimePicker_.Value, textBoxLogin.Text, textBoxPassword.Text, comboBoxDepartment.Text, comboBoxDegree_.Text, Int32.Parse(textBoxHoursPerWeek.Text != "" ? textBoxHoursPerWeek.Text : "0"));

                if(lecturer != null)
                {
                    //Insert into DataBase Lecturer table
                    if (h.Update<Lecturer>(lecturer))
                    {
                        MessageBox.Show("Lecturer " + lecturer.FirstName + " " + lecturer.LastName + " was successful updated.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("An error accrued when updating this lecturer, please try again.");
                    }
                }
            }
            
        }

        public void HomePage()
        {
            Application.Run(new FrmLecturer(this.parent.user, this.parent.pass));
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void groupBoxPersonalData_Enter(object sender, EventArgs e)
        {

        }

        private void FormUpdateLecturerBySelf_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxID.Text))
            {
                label22.Text = "Empty field!";
            }
            else
            {
                Handler h = new Handler();
                Lecturer toFindLecturer = new Lecturer(textBoxID.Text, null, null, null, null, null, default(DateTime), null, null, null, null, -1);
                Lecturer findedLecturer = h.Get<Lecturer>(toFindLecturer);

                if (findedLecturer != null)
                {
                    textBoxID.Text = findedLecturer.ID;
                    textBoxFirstName_.Text = findedLecturer.FirstName;
                    textBoxLastName_.Text = findedLecturer.LastName;
                    textBoxAddress.Text = findedLecturer.Address;
                    textBoxEmail.Text = findedLecturer.Email;
                    textBoxTel.Text = findedLecturer.Tel;
                    dateTimePicker_.Value = new DateTime(findedLecturer.BirthDay.Year, findedLecturer.BirthDay.Month, findedLecturer.BirthDay.Day, 0, 0, 0);
                    textBoxLogin.Text = findedLecturer.Login;
                    textBoxPassword.Text = findedLecturer.Password;
                    comboBoxDepartment.Text = findedLecturer.Department;
                    comboBoxDegree_.Text = findedLecturer.Degree;
                    textBoxHoursPerWeek.Text = findedLecturer.HoursPerWeek.ToString();
                    label22.Text = "";
                }
                else if (findedLecturer == null)
                {
                    label22.Text = "ID " + textBoxID.Text + " not found!"; ;
                }
            }
        }
        
        private void Return(object sender, FormClosedEventArgs e)
        {

            Thread th = new Thread(HomePage);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxContactInformation_Enter(object sender, EventArgs e)
        {

        }

        private void buttonFindLecturer_Click(object sender, EventArgs e)
        {
            //buttonFindLecturer.Enabled = false;

            if (String.IsNullOrEmpty(textBoxID.Text))
            {
                label22.Text = "Empty field!";
            }
            else
            {
                int n;
                bool isNumeric = int.TryParse(textBoxID.Text, out n);
                if (!isNumeric || textBoxID.Text.Length < 9 || textBoxID.Text.Length > 10)
                {
                    label22.Text = "Enter correct numeric ID with 9-10 digits";
                }
                else
                {
                    Handler h = new Handler();
                    Lecturer toFindLecturer = new Lecturer(textBoxID.Text, null, null, null, null, null, default(DateTime), null, null, null, null, -1);
                    Lecturer findedLecturer = h.Get<Lecturer>(toFindLecturer);

                    if (findedLecturer != null)
                    {
                        textBoxID.Text = findedLecturer.ID;
                        textBoxFirstName_.Text = findedLecturer.FirstName;
                        textBoxLastName_.Text = findedLecturer.LastName;
                        textBoxAddress.Text = findedLecturer.Address;
                        textBoxEmail.Text = findedLecturer.Email;
                        textBoxTel.Text = findedLecturer.Tel;
                        dateTimePicker_.Value = new DateTime(findedLecturer.BirthDay.Year, findedLecturer.BirthDay.Month, findedLecturer.BirthDay.Day, 0, 0, 0);
                        textBoxLogin.Text = findedLecturer.Login;
                        textBoxPassword.Text = findedLecturer.Password;
                        comboBoxDepartment.Text = findedLecturer.Department;
                        comboBoxDegree_.Text = findedLecturer.Degree;
                        textBoxHoursPerWeek.Text = findedLecturer.HoursPerWeek.ToString();
                        label22.Text = "";
                    }
                    else if (findedLecturer == null)
                    {
                        label22.Text = "ID " + textBoxID.Text + " not found!"; ;
                    }
                }
            }

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBoxWorkingInformation_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
