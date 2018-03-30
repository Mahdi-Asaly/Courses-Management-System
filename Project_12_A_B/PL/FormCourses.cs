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
using Project_12_A_B;

namespace Project_12_A_B.PL
{
    public partial class FormCourses : Form
    {
        //private List<string[]> filterKeywords;

        private Dictionary<string, string[]> filterKeywords;
        private int permission;

        public int Permission
        {
            get { return this.permission; }
            set { this.permission = value; }
        }

        public FormCourses()
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
            IList<KeyValuePair<Type, string>> properties = GetPropertiesNameOfClass(new Course());

            this.filterKeywords = new Dictionary<string, string[]>();

            foreach (KeyValuePair<Type, string> property in properties)
            {
                if (property.Key == typeof(string) || property.Key == typeof(int) || property.Key == typeof(float))
                {
                    this.filterKeywords.Add(property.Value, new string[]{ property.Value + " LIKE '%{0}%'", property.Value + " IS NOT NULL" });
                }
                else if (property.Key == typeof(Boolean))
                {
                    this.filterKeywords.Add(property.Value, new string[] { property.Value + " = '{0}'", property.Value + " IS NOT NULL" });
                }
            }


            //this.filterKeywords[0] = "ss";
            //this.filterKeywords[1] = "ss";
        }

        private void BuildFilterQuery()
        {
            string query;

            query = String.Format(this.filterKeywords["ID"][String.IsNullOrEmpty(textBoxFilterID.Text) ? 1 : 0], textBoxFilterID.Text);
            query += String.Format(" AND " + this.filterKeywords["Name"][String.IsNullOrEmpty(textBoxFilterName.Text) ? 1 : 0], textBoxFilterName.Text);
            query += String.Format(" AND " + this.filterKeywords["Category"][String.IsNullOrEmpty(textBoxFilterCategory.Text) ? 1 : 0], textBoxFilterCategory.Text);
            query += String.Format(" AND " + this.filterKeywords["Semester"][String.IsNullOrEmpty(textBoxFilterSemester.Text) ? 1 : 0], textBoxFilterSemester.Text);
            query += String.Format(" AND " + this.filterKeywords["HoursPerWk"][String.IsNullOrEmpty(textBoxFilterHoursPerWk.Text) ? 1 : 0], textBoxFilterHoursPerWk.Text);
            query += String.Format(" AND " + this.filterKeywords["Year"][String.IsNullOrEmpty(textBoxFilterYear.Text) ? 1 : 0], textBoxFilterYear.Text);
            query += String.Format(" AND " + this.filterKeywords["Point"][String.IsNullOrEmpty(textBoxFilterPoint.Text) ? 1 : 0], textBoxFilterPoint.Text);
            query += String.Format(" AND " + this.filterKeywords["Practition"][String.IsNullOrEmpty(comboBoxFilterPractition.Text) || comboBoxFilterPractition.SelectedIndex == 0 ? 1 : 0], comboBoxFilterPractition.SelectedIndex == 0 ? "none" : (comboBoxFilterPractition.SelectedIndex == 1 ? "true" : "false"));
            query += String.Format(" AND " + this.filterKeywords["Lab"][String.IsNullOrEmpty(comboBoxFilterLab.Text) || comboBoxFilterLab.SelectedIndex == 0 ? 1 : 0], comboBoxFilterLab.SelectedIndex == 0 ? "none" : (comboBoxFilterLab.SelectedIndex == 1 ? "true" : "false"));
            query += String.Format(" AND " + this.filterKeywords["RegisterOption"][String.IsNullOrEmpty(comboBoxFilterOpen.Text) || comboBoxFilterOpen.SelectedIndex == 0 ? 1 : 0], comboBoxFilterOpen.SelectedIndex == 0 ? "none" : (comboBoxFilterOpen.SelectedIndex == 1 ? "true" : "false"));

            try
            {
                (dataGridViewCourses.DataSource as DataTable).DefaultView.RowFilter = query;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

        }

        public void RefreshDataSource()
        {
            Handler h = new Handler();
            DataTable dt = h.GetDataTable<Course>(new Course());
            dataGridViewCourses.DataSource = dt;
        }

        private void FormCourses_Load(object sender, EventArgs e)
        {
            if(Globals.LoggedUser.getPerm().Trim() != "1")
            {
                this.panelEdit.Hide();
            }

            Handler h = new Handler();
            //List<Course> courses = h.GetList<Course>(new Course());
            //courses.Add(new Course("111", "name", 3, 4, "cat", true, true, "1", 4, false));
            //List<Course> courses = new List<Course>(h.GetList<Course>(new Course()));
            //DataTable dt = h.GetDataTable<Course>(new Course());
            //dataGridViewCourses.DataSource = dt;
            this.RefreshDataSource();
            //courseBindingSource.Add(courses[0]);
            /*
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridViewCourses.Columns.Add(btn);
            btn.HeaderText = "Click Data";
            btn.Text = "Click Here";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            */

            this.SetFiltersKeywords();

            this.comboBoxFilterPractition.SelectedIndex = 0;
            this.comboBoxFilterLab.SelectedIndex = 0;
            this.comboBoxFilterOpen.SelectedIndex = 0;
            
            /*
            try
            {
                (dataGridViewCourses.DataSource as DataTable).DefaultView.RowFilter = "Lab = 'true'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            */
        }

        private void textBoxFilterID_TextChanged(object sender, EventArgs e)
        {
            //string rowFilter = string.Format("[{0}] = '{1}'", "ID", textBoxFilterID.Text);
            //(dataGridViewCourses.DataSource as DataTable).DefaultView.RowFilter = rowFilter;

            this.BuildFilterQuery();
            /*
            try
            {
                (dataGridViewCourses.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(textBoxFilterID.Text) ?
                    "ID IS NOT NULL" :
                    String.Format("ID LIKE '%{0}%' OR ID LIKE '%{1}%' OR ID LIKE '%{2}%' OR ID LIKE '%{3}%'", textBoxFilterID.Text, textBoxFilterID.Text, textBoxFilterID.Text, textBoxFilterID.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            */
        }

        private void labelFilterPractition_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxFilterPractition_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void buttonAddCourse_Click_1(object sender, EventArgs e)
        {
            Form form = new FrmAddCourses(this);
            form.Show();

        }

        private void buttonDeleteCourse_Click_1(object sender, EventArgs e)
        { 
            foreach (DataGridViewRow row in dataGridViewCourses.SelectedRows)
            {
                FrmDeleteCourses form = new FrmDeleteCourses(this);
                form.CourseIDBox_.Text = row.Cells[0].Value.ToString();
                form.Show();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void HomePage()
        {
            if (Globals.LoggedUser.getPerm() == "4")
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

        private void buttonEditCourse_Click_1(object sender, EventArgs e)
        {
            //DataRow foundRow = (dataGridViewCourses.DataSource as DataTable).Rows.Find();
            foreach (DataGridViewRow row in dataGridViewCourses.SelectedRows)
            {
                //dataGridViewCourses.Rows.Remove(row);
                //dataGridViewCourses.Rows.Add(row);
                FormUpdateCourseBySecretary form = new FormUpdateCourseBySecretary(this);
                form.IDTextBox.Text = row.Cells[0].Value.ToString();
                form.NameTextBox.Text = row.Cells[1].Value.ToString();
                form.CategoryTextBox.Text = row.Cells[2].Value.ToString();
                form.SemesterTextBox.Text = row.Cells[3].Value.ToString();
                form.HoursPerWkTextBox.Text = row.Cells[4].Value.ToString();
                form.YearTextBox.Text = row.Cells[5].Value.ToString();
                form.PointTextBox.Text = row.Cells[6].Value.ToString();
                form.PractitionCheckBox.Checked = Convert.ToBoolean(row.Cells[7].Value);
                form.LabCheckBox.Checked = Convert.ToBoolean(row.Cells[8].Value);
                form.RegisterOptionCheckBox.Checked = Convert.ToBoolean(row.Cells[9].Value);
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

        }
    }
}
