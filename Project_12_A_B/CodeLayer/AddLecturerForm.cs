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
using BranchA.CodeLayer;
using System.Threading;

namespace Project_Sce.PL
{

    public partial class AddLecturerForm : Form
    {

        //DAL.DataBase dal = new DAL.DataBase();
        
        public AddLecturerForm()
        {
            InitializeComponent();
            //dal.open();
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

            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label9.Text = "";

            if (String.IsNullOrEmpty(textBoxPassportId.Text))
            {
                label10.Text = "Empty field!";
                result = false;
            }
            else
            {
                int n;
                bool isNumeric = int.TryParse(textBoxPassportId.Text, out n);
                if (!isNumeric || textBoxPassportId.Text.Length < 9 || textBoxPassportId.Text.Length > 10)
                {
                    label10.Text = "Enter correct numeric passport ID with 9-10 digits";
                    result = false;
                }
            }

            if (String.IsNullOrEmpty(textBoxFirstName.Text))
            {
                label11.Text = "Empty field!";
                result = false;
            }
            else
            {
                int n;
                bool isNumeric = int.TryParse(textBoxFirstName.Text, out n);
                if (isNumeric || textBoxFirstName.Text.Length < 2 || textBoxFirstName.Text.Length > 49)
                {
                    label11.Text = "Enter correct first name";
                    result = false;
                }
            }

            if (String.IsNullOrEmpty(textBoxLastName.Text))
            {
                label12.Text = "Empty field!";
                result = false;
            }
            else
            {
                int n;
                bool isNumeric = int.TryParse(textBoxLastName.Text, out n);
                if (isNumeric || textBoxLastName.Text.Length < 2 || textBoxLastName.Text.Length > 49)
                {
                    label12.Text = "Enter correct last name";
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
                Lecturer toFindLecturer = new Lecturer(textBoxPassportId.Text, null, null, null, null, null, default(DateTime), textBoxLogin.Text, null, null, null, -1);
                Lecturer lecturer = h.Get<Lecturer>(toFindLecturer);

                if (lecturer == null)
                {
                    //Create new Lecturer object
                    lecturer = new Lecturer(textBoxPassportId.Text, textBoxFirstName.Text, textBoxLastName.Text, textBoxAddress.Text, textBoxEmail.Text, textBoxTel.Text, dateTimePicker1.Value, textBoxLogin.Text, textBoxPassword.Text, comboBoxDepartment.Text, comboBoxDegree.Text, Int32.Parse(textBoxHoursPerWeek.Text != "" ? textBoxHoursPerWeek.Text : "0"));

                    if(lecturer != null)
                    {
                        //Insert into DataBase Lecturer table
                        if (h.Add<Lecturer>(lecturer))
                        {
                            MessageBox.Show("Lecturer " + lecturer.FirstName + " " + lecturer.LastName + " was added");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("An error accrued to add this lecturer, please try again.");
                        }
                        
                    }
                }
                else if (lecturer.ID != null)
                {
                    MessageBox.Show("Lecturer with Passport ID " + textBoxPassportId.Text + " already exist!");
                }
                else if (lecturer.Login != null)
                {
                    MessageBox.Show("Login " + textBoxLogin.Text + " already exist!");
                }
            }
            
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

        private void AddLecturerForm_Load(object sender, EventArgs e)
        {

        }
        
        private void Return(object sender, FormClosedEventArgs e)
        {
            //Application.Run(new FrmProcLecturer());
            this.Hide();
            Form form = new FrmProcLecturer();
            form.ShowDialog();
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
