using Project_Sce.CodeLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_12_A_B.PL
{
    public partial class SystemUsers : Form
    {
        Project_Sce.CodeLayer.Employee em = new Project_Sce.CodeLayer.Employee();
        public SystemUsers()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = em.get_all_users();
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_User_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure that you would like to delete this User ?", "Delete User", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Employee emp = new Employee();
                    emp.delete_user(row.Cells[0].Value.ToString());
                }
                
                else if (dialogResult == DialogResult.No)
                {
                   //do something
                }
            }
        }

        private void Add_User_Click(object sender, EventArgs e)
        {
            AddUser au = new AddUser();
            au.ShowDialog();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = em.get_all_users();
        }
    }
}
