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
    public partial class FormStudents : Form
    {
        private Dictionary<string, string[]> filterKeywords;
        private int permission;

        public int Permission
        {
            get { return this.permission; }
            set { this.permission = value; }
        }

        public FormStudents()
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
            IList<KeyValuePair<Type, string>> properties = GetPropertiesNameOfClass(new Project_Sce.CodeLayer.Student());

            this.filterKeywords = new Dictionary<string, string[]>();

            foreach (KeyValuePair<Type, string> property in properties)
            {
                if (property.Key == typeof(string))
                {
                    this.filterKeywords.Add(property.Value, new string[]{ property.Value + " LIKE '%{0}%'", property.Value + " IS NOT NULL" });
                }
                else if(property.Key == typeof(int) || property.Key == typeof(float))
                {
                    this.filterKeywords.Add(property.Value, new string[] { "Convert(" + property.Value + ", 'System.String') LIKE '%{0}%'", property.Value + " IS NOT NULL" });
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
            query += String.Format(" AND " + this.filterKeywords["Year"][String.IsNullOrEmpty(textBoxYear.Text) ? 1 : 0], textBoxYear.Text);
            query += String.Format(" AND " + this.filterKeywords["Average"][String.IsNullOrEmpty(textBoxAverage.Text) ? 1 : 0], textBoxAverage.Text);
            query += String.Format(" AND " + this.filterKeywords["Email"][String.IsNullOrEmpty(textBoxEmail.Text) ? 1 : 0], textBoxEmail.Text);
            query += String.Format(" AND " + this.filterKeywords["Semester"][String.IsNullOrEmpty(textBoxSemester.Text) ? 1 : 0], textBoxSemester.Text);
            query += String.Format(" AND " + this.filterKeywords["Cyber"][String.IsNullOrEmpty(comboBoxCyber.Text) || comboBoxCyber.SelectedIndex == 0 ? 1 : 0], comboBoxCyber.SelectedIndex == 0 ? "none" : (comboBoxCyber.SelectedIndex == 1 ? "true" : "false"));

            try
            {
                (dataGridViewStudents.DataSource as DataTable).DefaultView.RowFilter = query;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

        }

        public void RefreshDataSource()
        {
            Handler h = new Handler();
            DataTable dt = h.GetDataTable<Project_Sce.CodeLayer.Student>(new Project_Sce.CodeLayer.Student());
            dataGridViewStudents.DataSource = dt;
        }

        private void FormStudents_Load(object sender, EventArgs e)
        {
            this.panelEdit.Hide();
            this.panelDirectOfStudents.Hide();

            this.studentTableAdapter.Fill(this.projectSCEDataSet.Student);
            if (this.permission == 4)
            {
                this.panelEdit.Show();
            }
            else if(this.permission == 6)
            {
                this.panelDirectOfStudents.Location = new Point(
                    this.panelEdit.Location.X,
                    this.panelEdit.Location.Y
                );
                this.panelDirectOfStudents.Show();
            }

            Handler h = new Handler();
            //List<Project_Sce.CodeLayer.Student> Students = h.GetList<Project_Sce.CodeLayer.Student>(new Project_Sce.CodeLayer.Student());
            //Students.Add(new Project_Sce.CodeLayer.Student("111", "name", 3, 4, "cat", true, true, "1", 4, false));
            //List<Project_Sce.CodeLayer.Student> Students = new List<Project_Sce.CodeLayer.Student>(h.GetList<Project_Sce.CodeLayer.Student>(new Project_Sce.CodeLayer.Student()));
            //DataTable dt = h.GetDataTable<Project_Sce.CodeLayer.Student>(new Project_Sce.CodeLayer.Student());
            //dataGridViewStudents.DataSource = dt;
            this.RefreshDataSource();
            //StudentBindingSource.Add(Project_Sce.CodeLayer.Students[0]);
            /*
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridViewStudents.Columns.Add(btn);
            btn.HeaderText = "Click Data";
            btn.Text = "Click Here";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            */

            this.SetFiltersKeywords();

            this.comboBoxCyber.SelectedIndex = 0;

            /*
            try
            {
                (dataGridViewStudents.DataSource as DataTable).DefaultView.RowFilter = "Lab = 'true'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            */
            dataGridViewStudents.SelectionChanged += new EventHandler(dataGridViewStudents_SelectionChanged);
            this.ChangeCyberButtons();
        }

        private void textBoxFilterID_TextChanged(object sender, EventArgs e)
        {
            //string rowFilter = string.Format("[{0}] = '{1}'", "ID", textBoxFilterID.Text);
            //(dataGridViewStudents.DataSource as DataTable).DefaultView.RowFilter = rowFilter;

            this.BuildFilterQuery();
            /*
            try
            {
                (dataGridViewStudents.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(textBoxFilterID.Text) ?
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

        private void buttonAddStudent_Click_1(object sender, EventArgs e)
        {
            Form form = new AddStudentform(this);
            form.Show();
        }

        private void buttonDeleteStudent_Click_1(object sender, EventArgs e)
        { 
            foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure that you would like to delete this student?", "Delete student", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Handler h = new Handler();
                    bool result = h.Delete<Project_Sce.CodeLayer.Student>(new Project_Sce.CodeLayer.Student(Convert.ToInt32(row.Cells[0].Value.ToString()), null, 0, 0, null, null, null, false));
                    if (result)
                    {
                        this.RefreshDataSource();
                        //MessageBox.Show("Student deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error, please try again!");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
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

        private void textBoxFilterYear__TextChanged(object sender, EventArgs e)
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

        private void buttonEditStudent_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
            {
                AddStudentform form = new AddStudentform(this, true, row.Cells[0].Value.ToString());
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
            foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
            {
                StudentSectionDirect st = new StudentSectionDirect(row.Cells[0].Value.ToString());
                st.ShowDialog();
            }
            
        }

        private void labelFilterYear__Click(object sender, EventArgs e)
        {

        }

        private void labelFilterSemester_Click(object sender, EventArgs e)
        {

        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void textBoxAverage_TextChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void textBoxSemester_TextChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void comboBoxCyber_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void buttonCyber_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
            {
                DialogResult dialogResult = MessageBox.Show("Add student " + row.Cells[1].Value.ToString() + " to cyber program?", "Cyber", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Handler h = new Handler();
                    
                    bool result = h.Update<Project_Sce.CodeLayer.Student>(new Project_Sce.CodeLayer.Student(Convert.ToInt32(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), Convert.ToInt32(row.Cells[2].Value.ToString()), (float)Convert.ToDouble(row.Cells[3].Value.ToString()), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), true));
                    if (result)
                    {
                        this.RefreshDataSource();
                        //MessageBox.Show("Student deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error, please try again!");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void buttonRemoveCyber_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
            {
                DialogResult dialogResult = MessageBox.Show("Remove student " + row.Cells[1].Value.ToString() + " from cyber program?", "Cyber", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Handler h = new Handler();

                    bool result = h.Update<Project_Sce.CodeLayer.Student>(new Project_Sce.CodeLayer.Student(Convert.ToInt32(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), Convert.ToInt32(row.Cells[2].Value.ToString()), (float)Convert.ToDouble(row.Cells[3].Value.ToString()), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), false));
                    if (result)
                    {
                        this.RefreshDataSource();
                    }
                    else
                    {
                        MessageBox.Show("Error, please try again!");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ChangeCyberButtons()
        {
            foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
            {
                if (Convert.ToBoolean(row.Cells[7].Value) == true)
                {
                    this.buttonAddCyber.Enabled = false;
                    this.buttonRemoveCyber.Enabled = true;
                }
                else
                {
                    this.buttonAddCyber.Enabled = true;
                    this.buttonRemoveCyber.Enabled = false;
                }
            }
        }

        private void dataGridViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            this.ChangeCyberButtons();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new AddStudentform(this);
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.RefreshDataSource();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure that you would like to delete this student?", "Delete student", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Handler h = new Handler();
                    bool result = h.Delete<Project_Sce.CodeLayer.Student>(new Project_Sce.CodeLayer.Student(Convert.ToInt32(row.Cells[0].Value.ToString()), null, 0, 0, null, null, null, false));
                    if (result)
                    {
                        this.RefreshDataSource();
                        //MessageBox.Show("Student deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error, please try again!");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
            {
                AddStudentform form = new AddStudentform(this, true, row.Cells[0].Value.ToString());
                form.Show();
            }
        }

        private void buttonAssignToCourse_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
            {
                AssignStudent_To_Course form = new AssignStudent_To_Course(row.Cells[0].Value.ToString());
                form.Show();
            }
        }

        private void buttonAssignToCourse_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
            {
                AssignStudent_To_Course form = new AssignStudent_To_Course(row.Cells[0].Value.ToString());
                form.Show();
            }
        }
    }
}
