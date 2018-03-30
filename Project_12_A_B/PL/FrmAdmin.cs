using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Project_12_A_B.PL;

namespace Project_Sce.PL
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmHeadDepartment_Load(object sender, EventArgs e)
        {

        }
        private void RequestsB_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmStudentRequest sr = new FrmStudentRequest();
            sr.ShowDialog();
        }

        private void ReturnBT_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn log = new LogIn();
            log.ShowDialog();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            SystemUsers su = new SystemUsers();
            su.ShowDialog();
        }
    }
}
