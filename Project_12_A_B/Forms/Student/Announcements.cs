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
using System.Threading;
namespace Project_12_A_B
{
    public partial class Announcements : MetroForm
    {
        public Announcements()
        {
            InitializeComponent();
        }

        private void Announcements_Load(object sender, EventArgs e)
        {
            //Updating the Announcement Box.        
            String query = "select * from Announcements";
            SqlCommand cmd = new SqlCommand(query, Globals.conn);
            SqlDataReader dbr;
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                AnnouncementTextBox.Text = dbr[0].ToString();
            }
            AnnouncementTextBox.Font = new Font("Modern No. 20", 15, FontStyle.Bold);
            dbr.Close(); //Do not forget to close the connection everytime you using queries.
            /////////////////////////////////////
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoToStudent);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void GoToStudent()
        {
            Application.Run(new Student());
        }
    }
}
