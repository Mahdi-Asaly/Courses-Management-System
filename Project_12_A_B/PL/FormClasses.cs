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
    public partial class FormClasses : Form
    {
        private Dictionary<string, string[]> filterKeywords;
        private List<Lesson> lessons;
        private int permission;

        public int Permission
        {
            get { return this.permission; }
            set { this.permission = value; }
        }

        public FormClasses()
        {
            InitializeComponent();
        }

        public FormClasses(int permission_)
        {
            InitializeComponent();
            this.permission = permission_;
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
            IList<KeyValuePair<Type, string>> properties = GetPropertiesNameOfClass(new Classroom());

            this.filterKeywords = new Dictionary<string, string[]>();

            foreach (KeyValuePair<Type, string> property in properties)
            {
                if (property.Key == typeof(string) || property.Key == typeof(DateTime))
                {
                    this.filterKeywords.Add(property.Value, new string[] { property.Value + " LIKE '%{0}%'", property.Value + " IS NOT NULL" });
                }
                else if (property.Key == typeof(int) || property.Key == typeof(float))
                {
                    this.filterKeywords.Add(property.Value, new string[] { "Convert(" + property.Value + ", 'System.String') >= {0}", property.Value + " IS NOT NULL" });
                }
                else if (property.Key == typeof(Boolean))
                {
                    this.filterKeywords.Add(property.Value, new string[] { property.Value + " = '{0}'", property.Value + " IS NOT NULL" });
                }
            }
        }

        private void BuildFilterQuery()
        {

            string query = String.Format(this.filterKeywords["Name"][String.IsNullOrEmpty(textBoxFilterName.Text) ? 1 : 0], textBoxFilterName.Text);
            query += String.Format(" AND " + this.filterKeywords["SeatsNum"][String.IsNullOrEmpty(textBoxFilterSeatsNum.Text) ? 1 : 0], textBoxFilterSeatsNum.Text);
            query += String.Format(" AND " + this.filterKeywords["Projector"][String.IsNullOrEmpty(comboBoxFilterProjector.Text) || comboBoxFilterProjector.SelectedIndex == 0 ? 1 : 0], comboBoxFilterProjector.SelectedIndex == 0 ? "none" : (comboBoxFilterProjector.SelectedIndex == 1 ? "true" : "false"));
            query += String.Format(" AND " + this.filterKeywords["Computer"][String.IsNullOrEmpty(comboBoxFilterComputer.Text) || comboBoxFilterComputer.SelectedIndex == 0 ? 1 : 0], comboBoxFilterComputer.SelectedIndex == 0 ? "none" : (comboBoxFilterComputer.SelectedIndex == 1 ? "true" : "false"));
            foreach(Lesson lesson in this.lessons)
            {
                if (this.comboBoxDay.SelectedItem != null && this.comboBoxFromHour != null && this.comboBoxToHour != null)
                {
                    if (lesson.Day.ToString() == this.comboBoxDay.SelectedItem.ToString() && System.Convert.ToInt32(this.comboBoxFromHour.SelectedItem) < lesson.EndTime && System.Convert.ToInt32(this.comboBoxToHour.SelectedItem) > lesson.StrtTime)
                    {
                        query += String.Format(" AND Name <> '" + lesson.ClassroomName + "'");
                    }
                }
            }
            try
            {
                (dataGridViewClasses.DataSource as DataTable).DefaultView.RowFilter = query;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

        }

        public void RefreshDataSource()
        {
            Handler h = new Handler();
            DataTable dt = h.GetDataTable<Classroom>(new Classroom());
            dataGridViewClasses.DataSource = dt;
        }

        private void FormClasses_Load(object sender, EventArgs e)
        {
            this.panelEdit.Hide();
            if (this.permission == 4)
            {
                this.panelEdit.Show();
            }
            Handler h = new Handler();
            this.lessons = h.GetList<Lesson>(new Lesson());
            this.SetFiltersKeywords();
            this.RefreshDataSource();
            DateTime CurDate = DateTime.Now;;
            this.comboBoxDay.SelectedItem = CurDate.DayOfWeek.ToString();
            this.comboBoxFromHour.SelectedItem = CurDate.Hour.ToString();
            this.comboBoxToHour.SelectedItem = CurDate.Hour < 24 ? (CurDate.Hour + 1).ToString() : CurDate.Hour.ToString();
            this.comboBoxFilterComputer.SelectedIndex = 0;
            this.comboBoxFilterProjector.SelectedIndex = 0;
        }

        private void comboBoxFilterPractition_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void buttonAddClass_Click_1(object sender, EventArgs e)
        {
            FrmAddClassroom form = new FrmAddClassroom();
            form.Show();
            form.FormClosed += new FormClosedEventHandler(This_Refresh);
        }

        private void buttonDeleteClass_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewClasses.SelectedRows)
            {
                string name = row.Cells[0].Value.ToString();
                FrmDelClassroom form = new FrmDelClassroom(name);
                form.Show();
                form.FormClosed += new FormClosedEventHandler(This_Refresh);
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

        private void buttonEditClass_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewClasses.SelectedRows)
            {
                string name = row.Cells[0].Value.ToString();
                int seats = (int)row.Cells[1].Value;
                bool projector = (bool)row.Cells[2].Value;
                bool computer = (bool)row.Cells[3].Value;
                FormEditClassroom form = new FormEditClassroom(name, seats, projector, computer);
                form.Show();
                form.FormClosed += new FormClosedEventHandler(This_Refresh);
            }
        }
        void This_Refresh(object sender, FormClosedEventArgs e)
        {
            this.RefreshDataSource();
        }

        private void buttonRefresh_Click_1(object sender, EventArgs e)
        {
            this.RefreshDataSource();
        }

        private void textBoxFilterSeatsNum_TextChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void comboBoxFilterProjector_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void comboBoxFilterComputer_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void comboBoxDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void comboBoxFromHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void comboBoxToHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BuildFilterQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewClasses.SelectedRows)
            {
                FormClassroomDetails form = new FormClassroomDetails(row.Cells[0].Value.ToString());
                form.Text = "Classroom - " + row.Cells[0].Value.ToString();
                form.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.comboBoxDay.SelectedIndex = -1;
            this.comboBoxFromHour.SelectedIndex = -1;
            this.comboBoxToHour.SelectedIndex = -1;
            this.comboBoxFilterComputer.SelectedIndex = 0;
            this.comboBoxFilterProjector.SelectedIndex = 0;
            this.textBoxFilterName.Text = "";
            this.textBoxFilterSeatsNum.Text = "";
            this.comboBoxFilterProjector.SelectedIndex = -1;
            this.comboBoxFilterComputer.SelectedIndex = -1;
        }
    }
}