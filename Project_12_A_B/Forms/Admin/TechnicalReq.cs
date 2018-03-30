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
using System.Data.SqlClient;
namespace Project_12_A_B.Forms.Admin
{
    public partial class TechnicalReq : MetroForm
    {
        public TechnicalReq()
        {
            InitializeComponent();
        }

        private void TechnicalReq_Load(object sender, EventArgs e)
        {

        }

        private void SendReqSupportButton_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            bool res = false;
            if (RequestTextBox_Admin.Text == "")
            {
                MessageBox.Show("ERROR: Can't Send Empty Message, please Write something.");
            }
            else
            {
                if (Globals.conn.State == ConnectionState.Open)
                {
                     res=Globals.GlobalAdmin.SendRequest(RequestTextBox_Admin.Text.ToString());
                }
                if (res)
                {
                    MessageBox.Show("Successsfully Sent the Request!", "Message Sending..", MessageBoxButtons.OK);
                }
                this.Close();
            }
        }
    }
}
