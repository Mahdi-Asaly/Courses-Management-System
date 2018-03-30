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
    public partial class FormLecturerConstraint : Form
    {
        private string user;

        public FormLecturerConstraint()
        {
            InitializeComponent();
        }

        public FormLecturerConstraint(string user_)
        {
            InitializeComponent();
            this.user = user_;
        }

        private void FormLecturerConstraint_Load(object sender, EventArgs e)
        {
            this.lIDTextBox.Text = this.user;
            this.lIDTextBox.Enabled = false;
            this.dayComboBox.SelectedIndex = 0;
            this.comboBoxFromHour.SelectedIndex = 0;
            this.comboBoxToHour.SelectedIndex = 0;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            CodeLayer.Handler h = new CodeLayer.Handler();
            string a = lIDTextBox.Text;
            var b = this.dayComboBox.SelectedItem;
            int cc = System.Convert.ToInt32(this.comboBoxFromHour.SelectedItem);
            int d = System.Convert.ToInt32(this.comboBoxFromHour.SelectedItem);
            int f = System.Convert.ToInt32(this.comboBoxToHour.SelectedItem);

            Project_Sce.CodeLayer.Constraint c = new Project_Sce.CodeLayer.Constraint(lIDTextBox.Text,dayComboBox.SelectedItem.ToString(),System.Convert.ToInt32(comboBoxFromHour.SelectedItem),System.Convert.ToInt32(comboBoxToHour.SelectedItem));
            if(h.Add<Project_Sce.CodeLayer.Constraint>(c))
            {
                //ok
                this.Close();
                System.Threading.Thread th = new System.Threading.Thread(GoBack);
                th.SetApartmentState(System.Threading.ApartmentState.STA);
                th.Start();
            }
            else
            {
                //not ok
            }

        }

        private void GoBack()
        {
            Application.Run(new Project_Sce.PL.FrmLecturer());
        }

        private void lIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fromHourTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
