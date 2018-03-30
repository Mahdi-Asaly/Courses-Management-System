using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Sce.CodeLayer;
using System.Threading;
using Project_Sce.PL;
using BranchA.CodeLayer;
using System.Net.Mail;

namespace BranchA.PL.Login
{
    public partial class ModuleForgot : UserControl
    {
        private static ModuleForgot instance_;
        string phi = "ID", phe = "Email";


        public static ModuleForgot Instance
        {
            get
            {
                if(instance_ == null)
                {
                    instance_ = new ModuleForgot();
                }
                return instance_;
            }
        }
        public ModuleForgot()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((LogIn)this.TopLevelControl).SetPanelModuleLogin();
        }

        private void ModuleForgot_Load(object sender, EventArgs e)
        {
            textBoxID.GotFocus += RemoveTextBox1;
            textBoxID.LostFocus += AddTextBox1;
            textBoxID.Text = phi;

            textBoxEmail.GotFocus += RemoveTextBox2;
            textBoxEmail.LostFocus += AddTextBox2;
            textBoxEmail.Text = phe;
        }

        public void RemoveTextBox1(object sender, EventArgs e)
        {
            if (textBoxID.Text == phi)
                textBoxID.Text = "";
        }

        public void AddTextBox1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxID.Text))
            {
                textBoxID.Text = phi;
            }
        }

        public void RemoveTextBox2(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == phe)
                textBoxEmail.Text = "";
        }

        public void AddTextBox2(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                textBoxEmail.Text = phe;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBoxID.Text != "" && this.textBoxID.Text  != phi)
            {
                Handler h = new Handler();
                Cls_Login login = h.Get<Cls_Login>(new Cls_Login(this.textBoxID.Text,null,null));
                if(login != null)
                {
                    this.SendEmail(login);
                }
            }
            else if (this.textBoxEmail.Text != "" && this.textBoxEmail.Text != phe)
            {
                Handler h = new Handler();
                Cls_Login login = h.Get<Cls_Login>(new Cls_Login(null, this.textBoxEmail.Text, null));
                if (login != null)
                {
                    this.SendEmail(login);
                }
            }
            else
            {
                MessageBox.Show("Please enter login or email.");
            }
            
        }

        private bool SendEmail(Cls_Login login)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("project.sce.12@gmail.com");
                mail.To.Add(login.Email);
                mail.Subject = "SCE password reminder";
                mail.Body = "You or someone requested password resend for your account\nYour Password is: " + login.Password;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("project.sce.12", "12345678Serg");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Your password has been sent to your email.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            this.textBoxEmail.BackColor = Color.WhiteSmoke;
            this.textBoxID.BackColor = Color.White;
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            this.textBoxEmail.BackColor = Color.White;
            this.textBoxID.BackColor = Color.WhiteSmoke;
        }
    }
}
