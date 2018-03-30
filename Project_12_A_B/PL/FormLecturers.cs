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
    public partial class FormLecturers : Form
    {
        //private List<string[]> filterKeywords;

        private Dictionary<string, string[]> filterKeywords;
        private int permission;

        public int Permission
        {
            get { return this.permission; }
            set { this.permission = value; }
        }

        public FormLecturers()
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
            IList<KeyValuePair<Type, string>> properties = GetPropertiesNameOfClass(new Lecturer());

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

            query = String.Format(this.filterKeywords["ID"][String.IsNullOrEmpty(textBoxFilterID.Text) ? 1 : 0], textBoxFilterID.Text);
            query += String.Format(" AND " + this.filterKeywords["FirstName"][String.IsNullOrEmpty(textBoxFilterFirstName.Text) ? 1 : 0], textBoxFilterFirstName.Text);
            query += String.Format(" AND " + this.filterKeywords["LastName"][String.IsNullOrEmpty(textBoxFilterLastName.Text) ? 1 : 0], textBoxFilterLastName.Text);
            query += String.Format(" AND " + this.filterKeywords["Department"][String.IsNullOrEmpty(textBoxFilterDepartment.Text) ? 1 : 0], textBoxFilterDepartment.Text);
            query += String.Format(" AND " + this.filterKeywords["Degree"][String.IsNullOrEmpty(textBoxFilterDegree.Text) ? 1 : 0], textBoxFilterDegree.Text);
            query += String.Format(" AND " + this.filterKeywords["HoursPerWeek"][String.IsNullOrEmpty(textBoxFilterHoursPerWk.Text) ? 1 : 0], textBoxFilterHoursPerWk.Text);
            query += String.Format(" AND " + this.filterKeywords["Tel"][String.IsNullOrEmpty(textBoxFilterTel.Text) ? 1 : 0], textBoxFilterTel.Text);
            query += String.Format(" AND " + this.filterKeywords["Address"][String.IsNullOrEmpty(textBoxFilterAddress.Text) ? 1 : 0], textBoxFilterAddress.Text);
                        
            try
            {
                (dataGridViewLecturers.DataSource as DataTable).DefaultView.RowFilter = query;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

        }

        public void RefreshDataSource()
        {
            Handler h = new Handler();
            DataTable dt = h.GetDataTable<Lecturer>(new Lecturer());
            dataGridViewLecturers.DataSource = dt;
        }

        private void FormLecturers_Load(object sender, EventArgs e)
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

        private void buttonAddLecturer_Click_1(object sender, EventArgs e)
        {
            Form form = new AddLecturerForm(this);
            form.Show();

        }

        private void buttonDeleteLecturer_Click_1(object sender, EventArgs e)
        { 
            foreach (DataGridViewRow row in dataGridViewLecturers.SelectedRows)
            {
                //FrmDeleteLecturer form = new FrmDeleteLecturer(this, row.Cells[0].Value.ToString());
                //form.Show();
                Handler h = new Handler();
                Lecturer toFindLecturer = new Lecturer(row.Cells[0].Value.ToString(), null, null, null, null, null, default(DateTime), null, null, null, null, -1);
                Lecturer lecturer = h.Get<Lecturer>(toFindLecturer);
                if (lecturer != null)
                {
                    DialogResult agree = MessageBox.Show("Are you sure that you want to delete lecturer " + lecturer.FirstName + " " + lecturer.LastName, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (agree == DialogResult.Yes)
                    {
                        if (h.Delete<Lecturer>(lecturer))
                        {
                            this.RefreshDataSource();
                            MessageBox.Show("The lecturer was successfully deleted from the database!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("There is a problem to delete this lecturer, please try again.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lecturer with ID " + toFindLecturer.ID + " not found!");
                }
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
                Application.Run(new DirectOfStud());
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

        private void buttonEditLecturer_Click_1(object sender, EventArgs e)
        {
            //DataRow foundRow = (dataGridViewLecturers.DataSource as DataTable).Rows.Find();
            foreach (DataGridViewRow row in dataGridViewLecturers.SelectedRows)
            {
                //dataGridViewLecturers.Rows.Remove(row);
                //dataGridViewLecturers.Rows.Add(row);
                UpdateLecturerForm form = new UpdateLecturerForm(this, row.Cells[0].Value.ToString());
                form.Show();
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
            
            foreach (DataGridViewRow row in dataGridViewLecturers.SelectedRows)
            {
                FormViewLecturer form = new FormViewLecturer(row.Cells[0].Value.ToString());
                form.Show();
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
