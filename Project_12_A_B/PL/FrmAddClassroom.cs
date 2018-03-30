using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Project_12_A_B.PL;

namespace Project_Sce.PL
{
    public partial class FrmAddClassroom : Form
    {
        CodeLayer.Classroom c = new CodeLayer.Classroom();
        public FrmAddClassroom()
        {
            InitializeComponent();
        }

        private void btnAddClassroom_Click(object sender, EventArgs e)
        {
            c.Add_Classroom(name.Text, Convert.ToInt32(numOfSeats.Text), Convert.ToBoolean(proj.Checked), Convert.ToBoolean(comp.Checked));
            MessageBox.Show("The Classroom was successfully added to the database!", "Adding Classroom", MessageBoxButtons.OK, MessageBoxIcon.Information);
            name.Text = "";
            numOfSeats.Text = "";
            proj.Text = "";
            comp.Text = "";
            this.Close();
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            /*Thread th = new Thread(GoBack);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();*///commented by Sergei
        }

        private void GoBack()
        {
            Application.Run(new FormClasses());
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(Login);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Login()
        {
            Application.Run(new LogIn());
        }

        private void FrmAddClassroom_Load(object sender, EventArgs e)
        {

        }
    }
    }

