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

namespace BranchA.PL.Login
{
    public partial class ModuleLogin : UserControl
    {
        private static ModuleLogin instance_;
        Cls_Login log = new Cls_Login();
        string permission;
        int perm;
        string phl = "Login", php = "Password";
        string id, passowrd;


        public static ModuleLogin Instance
        {
            get
            {
                if(instance_ == null)
                {
                    instance_ = new ModuleLogin();
                }
                return instance_;
            }
        }
        public ModuleLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((LogIn)this.TopLevelControl).SetPanelModuleForgot();
        }

        private void ModuleLogin_Load(object sender, EventArgs e)
        {
            textBox1.GotFocus += RemoveTextBox1;
            textBox1.LostFocus += AddTextBox1;
            textBox1.Text = phl;

            textBox2.GotFocus += RemoveTextBox2;
            textBox2.LostFocus += AddTextBox2;
            textBox2.Text = php;
        }

        public void RemoveTextBox1(object sender, EventArgs e)
        {
            if (textBox1.Text == phl)
                textBox1.Text = "";
        }

        public void AddTextBox1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = phl;
            }
        }

        public void RemoveTextBox2(object sender, EventArgs e)
        {
            if (textBox2.Text == php)
                textBox2.Text = "";
        }

        public void AddTextBox2(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = php;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = log.Login(this.textBox1.Text, this.textBox2.Text);

            if (dt.Rows.Count > 0)
            {
                this.id = this.textBox1.Text;
                this.passowrd = this.textBox2.Text;

                permission = dt.Rows[0][3].ToString();
                perm = Int32.Parse(permission);

                if (perm == 0)
                {
                    ((Form)this.TopLevelControl).Close();
                    Thread th = new Thread(OpenPageAdmin);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                if (perm == 4)
                {
                    ((Form)this.TopLevelControl).Close();
                    Thread th = new Thread(OpenSecretary);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                if (perm == 5)
                {
                    ((Form)this.TopLevelControl).Close();
                    Thread th = new Thread(OpenLect);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();

                }
                if (perm == 6)
                {
                    ((Form)this.TopLevelControl).Close();
                    Thread th = new Thread(OpenDirect);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }

            }
            else { MessageBox.Show("Login Failed"); }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void OpenDirect()
        {
            Application.Run(new Project_Sce.PL.DirectOfStud());
        }
        private void OpenLect()
        {
            Application.Run(new Project_Sce.PL.FrmLecturer(this.id, this.passowrd));
        }
        private void OpenSecretary()
        {
            Application.Run(new Project_Sce.PL.FrmSecretary());
        }

        private void OpenPageAdmin()
        {
            Application.Run(new Project_Sce.PL.FrmAdmin());
        }
    }
}
