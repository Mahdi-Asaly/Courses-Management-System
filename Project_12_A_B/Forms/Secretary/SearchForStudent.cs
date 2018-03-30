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
    public partial class SearchForStudent : MetroForm
    {
        public SearchForStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchStdButton_Click(object sender, EventArgs e)
        {
            String str = "server=mahdias.database.windows.net;database=ProjectSCE;UID=Mahdias;password=Aa123123";
            SqlConnection con = new SqlConnection(str);
        
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Login where ID = '" + SearchTextBox.Text+"'", con);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SearchStdButton_Click(sender, e);
        }

        private void SearchForStudent_Load(object sender, EventArgs e)
        {
           
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}
