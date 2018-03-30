using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MetroFramework.Forms;

namespace Project_12_A_B.Forms.Student
{
    public partial class Requests : MetroForm
    {
        public Requests()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            //backtomenu
            //View Student Panel
            this.Close();
        }
        public Boolean isEmpty(string check)
        {
            if (check == "" || check == " ")
                return true;
            else
                return false;
        }
        private void SubBtn_Click(object sender, EventArgs e)
        {
            //checking if speciefed a reason
            /* if(ChoiceBox.Text.ToString() == "")
             {
                 MessageBox.Show("Can not submit if you didn't choosed an option.");
                 return;
             }*/
            if (isEmpty(ChoiceBox.Text.ToString()))
            {
                MessageBox.Show("Can not submit if you didn't choosed an option.");
                return;
            }
            else if (isEmpty(ReasonBox.ToString()))
            {
                ReasonBox.Text = "No specific Reason";
            }
            //now updating db.
           Boolean res= (Globals.LoggedUser as Classes.Student).SendRequest(ChoiceBox.Text.ToString(), ReasonBox.Text.ToString());
            if (res)
            {
                MessageBox.Show("Successfully sended the request!");
                //backtomenu
                //View Student Panel
                this.Close();

            }
            else
            {
                MessageBox.Show("Failed to Submit the request , Reasons may be:\n- NO Internet Connection\n- Error in DataBase\nFast Solution:\n-Restart the Program\n-ReConnect to INTERNET", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void Requests_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
