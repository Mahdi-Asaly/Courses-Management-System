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
using MetroFramework.Forms;
namespace Project_12_A_B
{
    public partial class RequestTechSup_Secretary : MetroForm
    {
        public RequestTechSup_Secretary()
        {
            InitializeComponent();
            ReqLabel.BackColor = Color.Transparent;
        }
        public Boolean isNotMessage(string msg)
        {
            if (msg == "" || msg == null)
            {
                return true;
            }
            else
                return false;
        }


        /*Send Request Button - Support Req*/
        private void button1_Click(object sender, EventArgs e)
        {
           /* if (RequestTextBox_Secretary.Text == "")
            {
                MessageBox.Show("ERROR: Can't Send Empty Message, please Write something.");
            }*/
            if (isNotMessage(RequestTextBox_Secretary.Text.ToString()))
            {
                MessageBox.Show("ERROR: Can't Send Empty Message, please Write something.");
            }

            else
            {
                if (Globals.conn.State == ConnectionState.Open)
                {
                    Globals.GlobalSecretary.RequestTechnicalSupport(RequestTextBox_Secretary.Text.ToString());
                }

                MessageBox.Show("Successsfully Sent the Request!", "Message Sending..", MessageBoxButtons.OK);
                this.Close();
            }
        }


        private void RequestTechSup_Secretary_Load(object sender, EventArgs e)
        {

        }
        /*Cancel Request Button - Support Req*/

        private void CancelSupReqButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to Cancel this Request?", "Cancelling..", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Update();
            }
        }

        private void RequestTextBox_Secretary_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
