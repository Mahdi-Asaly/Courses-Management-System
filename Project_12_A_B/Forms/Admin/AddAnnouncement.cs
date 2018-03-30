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
using System.Threading;
using MetroFramework.Forms;
namespace Project_12_A_B
{
    public partial class AddAnnouncement : MetroForm
    {
        //Classes.SecretaryClass c = new Classes.SecretaryClass();
        
        public AddAnnouncement()
        {
           
            InitializeComponent();
        }

        private void CancelAnnadmin_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to Quit?", "Cancelling..", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //if the user is secretary
                if (Int32.Parse(Globals.LoggedUser.getPerm()) == 1)
                {
                    //View login Panel
                    this.Close();
                    Thread th = new Thread(GoSecretary);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                //if the user is Admin
                else if (Int32.Parse(Globals.LoggedUser.getPerm()) == 2)
                {
                    //View login Panel
                    this.Close();
                    Thread th = new Thread(GoAdmin);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Update();
            }
        }

        private void AddAnnouncement_Load(object sender, EventArgs e)
        {

        }
        /*this method to apply post announcements to all*/
        private void PostAnnButtonAdmin_Click(object sender, EventArgs e)
        {
   
            if (AnnouncementTextBox.Text == "")
            {
                MessageBox.Show("ERROR: Unable to Send an Empty Message.");
            }
            else
            {

                if (Globals.conn.State == ConnectionState.Open)
                {
                    Globals.GlobalSecretary.PostAnnouncement(AnnouncementTextBox.Text.ToString());
                }

                MessageBox.Show("Successsfully Posted the Message!", "Message Sending..", MessageBoxButtons.OK);
                //this.Close();

                //if the user is secretary
                if(Int32.Parse(Globals.LoggedUser.getPerm())== 1)
                {
                    //View login Panel
                    this.Close();
                    Thread th = new Thread(GoSecretary);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                //if the user is Admin
                else if(Int32.Parse(Globals.LoggedUser.getPerm())==2)
                {
                    //View login Panel
                    this.Close();
                    Thread th = new Thread(GoAdmin);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }

            }
        }
        private void GoAdmin()
        {
            Application.Run(new Admin());
        }
        private void GoSecretary()
        {
            Application.Run(new SecretaryFrm());
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
