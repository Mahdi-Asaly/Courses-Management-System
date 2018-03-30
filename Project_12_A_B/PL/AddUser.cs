using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Sce.CodeLayer;

namespace Project_12_A_B.PL
{
    public partial class AddUser : Form
    {
        Employee emp = new Employee();
        SystemUsers su = new SystemUsers();
        public AddUser()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            isLogged_txt.Text = "false";
            isLogged_txt.ReadOnly = true;
            isLogged_txt.Enabled = false;
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            //if (emp.Verify_User_ID(User_ID.Text).Rows.Count == 0)
            //{
                try
                {
                    emp.add_user(ID_txt.Text, Name_txt.Text, password_txt.Text, permission_combo.Text, Address_txt.Text, Email_txt.Text, isLogged_txt.Text);
                    MessageBox.Show("The user was successfully added to the database!", "Adding user", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ID_txt.Clear();
                    Name_txt.Clear();
                    password_txt.Clear();
                    Address_txt.Clear();
                    Email_txt.Clear();
                    permission_combo.Text = "";

                }catch(Exception exp) { exp.ToString(); }

            //}
            //else
            //    MessageBox.Show("This user already exist in database!", "Adding user", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

    }
}

