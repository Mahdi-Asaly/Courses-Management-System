using Project_12_A_B.CodeLayer;
using Project_Sce.CodeLayer;
using Project_Sce.PL;
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

namespace Project_12_A_B.PL
{
    public partial class FormConstraints : Form
    {
        //private List<string[]> filterKeywords;

        private Dictionary<string, string[]> filterKeywords;
        private int permission;

        public int Permission
        {
            get { return this.permission; }
            set { this.permission = value; }
        }

        public FormConstraints()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private IList<KeyValuePair<Type, string>> GetPropertiesNameOfClass(object pObject)
        {
            IList<KeyValuePair<Type, string>> propertyList = new List<KeyValuePair<Type, string>>();
            
            if (pObject != null)
            {
                foreach (var prop in pObject.GetType().GetProperties())
                {
                    propertyList.Add(new KeyValuePair<Type, string>(Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType, prop.Name));
                }
            }
            return propertyList;
        }
        
        private void SetFiltersKeywords()
        {
            IList<KeyValuePair<Type, string>> properties = GetPropertiesNameOfClass(new Project_Sce.CodeLayer.Constraint());

            this.filterKeywords = new Dictionary<string, string[]>();

            foreach (KeyValuePair<Type, string> property in properties)
            {
                if (property.Key == typeof(string) || property.Key == typeof(DateTime))
                {
                    this.filterKeywords.Add(property.Value, new string[]{ property.Value + " LIKE '%{0}%'", property.Value + " IS NOT NULL" });
                }
                else if (property.Key == typeof(int) || property.Key == typeof(float))
                {
                    this.filterKeywords.Add(property.Value, new string[] { "Convert(" + property.Value + ", 'System.String') LIKE '%{0}%'", property.Value + " IS NOT NULL" });
                }
                else if (property.Key == typeof(Boolean))
                {
                    this.filterKeywords.Add(property.Value, new string[] { property.Value + " = '{0}'", property.Value + " IS NOT NULL" });
                }
            }
        }

        private void BuildFilterQuery()
        {
            string query;

            query = String.Format(this.filterKeywords["LID"][String.IsNullOrEmpty(textBoxFilterLID.Text) ? 1 : 0], textBoxFilterLID.Text);
            query += String.Format(" AND " + this.filterKeywords["Day"][String.IsNullOrEmpty(textBoxFilterDay.Text) ? 1 : 0], textBoxFilterDay.Text);
            query += String.Format(" AND " + this.filterKeywords["FromHour"][String.IsNullOrEmpty(textBoxFilterFromHour.Text) ? 1 : 0], textBoxFilterFromHour.Text);
            query += String.Format(" AND " + this.filterKeywords["ToHour"][String.IsNullOrEmpty(textBoxFilterToHour.Text) ? 1 : 0], textBoxFilterToHour.Text);
                        
            try
            {
                (dataGridViewConstraints.DataSource as DataTable).DefaultView.RowFilter = query;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

        }

        public void RefreshDataSource()
        {
            Handler h = new Handler();
            DataTable dt = h.GetDataTable<Project_Sce.CodeLayer.Constraint>(new Project_Sce.CodeLayer.Constraint());
            dataGridViewConstraints.DataSource = dt;
        }

        private void FormConstraints_Load(object sender, EventArgs e)
        {
            this.panelEdit.Hide();
            if (this.permission == 4 || this.permission == 6)
            {
                this.panelEdit.Show();
            }

            this.RefreshDataSource();
            this.SetFiltersKeywords();
        }

        private void textBoxFilterID_TextChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void labelFilterPractition_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxFilterPractition_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void buttonAddConstraint_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonDeleteConstraint_Click_1(object sender, EventArgs e)
        { 
            foreach (DataGridViewRow row in dataGridViewConstraints.SelectedRows)
            {
                //FrmDeleteConstraint form = new FrmDeleteConstraint(this, row.Cells[0].Value.ToString());
                //form.Show();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void HomePage()
        {
            if (this.permission == 4)
            {
                Application.Run(new Project_12_A_B.SecretaryFrm());
            }
            else if (this.permission == 5)
            {
                Application.Run(new FrmLecturer());
            }
            else if (this.permission == 6)
            {
                Application.Run(new FrmAdmin());
            }
        }

        public void LogInPage()
        {
            Application.Run(new LogIn());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(LogInPage);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(HomePage);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void textBoxFilterName_TextChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void textBoxFilterCategory_TextChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void textBoxFilterSemester_TextChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void textBoxFilterHoursPerWk_TextChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void textBoxFilterYear_TextChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void textBoxFilterPoint_TextChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void comboBoxFilterLab_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void comboBoxFilterOpen_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void buttonEditConstraint_Click_1(object sender, EventArgs e)
        {
            //DataRow foundRow = (dataGridViewConstraints.DataSource as DataTable).Rows.Find();
            foreach (DataGridViewRow row in dataGridViewConstraints.SelectedRows)
            {
            }
            
        }

        private void buttonRefresh_Click_1(object sender, EventArgs e)
        {
            this.RefreshDataSource();
        }

        private void panelEdit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dataGridViewConstraints.SelectedRows)
            {
                //FormViewConstraint form = new FormViewConstraint(row.Cells[0].Value.ToString());
                //form.Show();
            }
        }

        private void labelFilterDepartment_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFilterAddress_TextChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void textBoxFilterLastName_TextChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void groupBoxFilters_Enter(object sender, EventArgs e)
        {

        }
    }
}
