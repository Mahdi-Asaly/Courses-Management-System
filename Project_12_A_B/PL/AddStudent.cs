using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using Project_12_A_B.PL;

namespace Project_Sce.PL
{
    public partial class AddStudentform : Form
    {
        private SqlConnection con;
        private string connectionS = "Data Source=mahdias.database.windows.net;Initial Catalog=ProjectSCE;User ID=Mahdias;Password=Aa123123";
        private bool countID = false, countAVG = false, countName = false, countYear = false, countEmail = false, coutADS = false;
        private bool EditStud = false;
        private string StudentID;
        private FormStudents parent;

        public AddStudentform()
        {//Constructor for Adding new student//
            InitializeComponent();
        }

        public AddStudentform(FormStudents parent_)
        {//Constructor for Adding new student//
            InitializeComponent();
            this.parent = parent_;
        }

        public AddStudentform(bool EditStudent, string StuId)
        {// Contructor for Editing//
            InitializeComponent();
            if (EditStudent == true)
            {
                EditStud = true;
                StudentID = StuId;
                Populate();
            }
        }

        public AddStudentform(FormStudents parent_, bool EditStudent, string StuId)
        {// Contructor for Editing//
            InitializeComponent();
            this.parent = parent_;
            if (EditStudent == true)
            {
                EditStud = true;
                StudentID = StuId;
                Populate();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddStudentform_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Type_Email_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            bool flag = false;
            con = new SqlConnection(connectionS);

            if (EditStud == false) // Adding a new student to database
            {
                if (countAVG == true && countName == true && Academic_comboBox1.Text != ""&& Semester_CB.Text!="" && countEmail == true && coutADS == true && countAVG == true)
                {
                    try
                    {
                        con.Open();
                        SqlCommand com = new SqlCommand("INSERT INTO Student(StudID,Name,Year,Average,Address,Email,Semester) VALUES(@id,@name,@year,@ave,@address,@email,@semester)", con);

                        com.Parameters.AddWithValue("@id", ID_TB.Text);
                        com.Parameters.AddWithValue("@name", NAME_TB.Text);
                        com.Parameters.AddWithValue("@year", Int32.Parse(Academic_comboBox1.Text.Trim()));
                        com.Parameters.AddWithValue("@semester", Int32.Parse(Semester_CB.Text.Trim()));
                        com.Parameters.AddWithValue("@ave", AVG_TB.Text);
                        com.Parameters.AddWithValue("@address", ADS_TB.Text);
                        com.Parameters.AddWithValue("@email", EMAIL_TB.Text + "@" + Type_Email_comboBox1.Text);




                        com.ExecuteNonQuery();

                    }
                    catch (Exception exp)
                    {

                        MessageBox.Show(exp.Message);
                        flag = true;
                    }
                    con.Close();
                    if (flag == false)
                    {

                        MessageBox.Show("success!"); //Success @add a new student
                        parent.RefreshDataSource();
                        Return_to_Table();
                    }
                }
                else
                    MessageBox.Show("All The fields must be completed");
            }
            else // Editing an existing student's info 
            {
                if (countAVG == true && countName == true && Academic_comboBox1.Text != ""&& Semester_CB.Text!="" && countEmail == true && coutADS == true && countAVG == true)
                {
                    try { 
                    con.Open();
                    SqlCommand com = new SqlCommand("UPDATE Student SET StudID=@id,Name=@name,Year=@year,Average=@ave,Address=@address,Email=@email,Semester=@semester WHERE StudID="+StudentID.ToString().Trim(),con);
                    com.Parameters.AddWithValue("@id", ID_TB.Text);
                    com.Parameters.AddWithValue("@name", NAME_TB.Text);
                    com.Parameters.AddWithValue("@year", Int32.Parse(Academic_comboBox1.Text.Trim()));
                    com.Parameters.AddWithValue("@semester", Int32.Parse(Semester_CB.Text.Trim()));
                    com.Parameters.AddWithValue("@ave", AVG_TB.Text);
                    com.Parameters.AddWithValue("@address", ADS_TB.Text);
                    com.Parameters.AddWithValue("@email", EMAIL_TB.Text + "@" + Type_Email_comboBox1.Text);
                    com.ExecuteNonQuery();
                    }
                    catch (Exception exp)
                      {

                    MessageBox.Show(exp.Message);
                        flag = true;
                    }

                    if (flag == false) //Success editing//
                    {
                        MessageBox.Show("success!");
                        parent.RefreshDataSource();
                        Return_to_Table();

                    }
                    con.Close();
                }
                else
                    MessageBox.Show("All fields must be completed");
        }

            }


        private void ID_TB_TextChanged(object sender, EventArgs e)
        {
            //Checking correct ID input//
            try
            {
                int flag = 0;
                if (ID_TB.Text == "")
                {
                    ID_TB.Text = "";
                    pictureBoxID.BackgroundImage = null;
                }

                else
                {
                    for (int i = 0; i < ID_TB.Text.Length; i++)
                    {
                        if ((ID_TB.Text[i] <= '/' || ID_TB.Text[i] >= ':')) //Numbers only//
                        {
                            flag = 1;
                            MessageBox.Show("Insert numbers only", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    if (flag == 1)
                        pictureBoxID.BackgroundImage = X_or_V_pic.Images[1]; //error
                    else
                    {
                        pictureBoxID.BackgroundImage = X_or_V_pic.Images[0]; // good
                        countID = true;
                    }
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }



        }

        private void pictureBoxID_Click(object sender, EventArgs e)
        {

        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            Return_to_Table();
        }

        private void Return_to_Table()
        {
            //Return to Add/Delete/Edit Menu//

            this.Close();
            Thread th = new Thread(GoBack);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }



        private void AVG_TB_TextChanged(object sender, EventArgs e)
        {
            //Checking Correct average input//
            try
            {
                
                int flag = 0;
                if (AVG_TB.Text == "")
                {
                    AVG_TB.Text = "";
                    pictureBoxAvg.BackgroundImage = null;
                }

                else
                {
                    for (int i = 0; i < AVG_TB.Text.Length; i++)
                    {
                        if ((AVG_TB.Text[i]) >= 'A' && (AVG_TB.Text[i]) <= 'Z' || (AVG_TB.Text[i]) >= 'a' && (AVG_TB.Text[i]) <= 'z')
                        {
                            flag = 1;
                            MessageBox.Show("Insert numbers only", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                    if (flag == 0)
                        if (float.Parse(AVG_TB.Text.ToString().Trim()) < 0 || float.Parse(AVG_TB.Text.ToString().Trim()) > 100)
                            flag = 1;

                    if (flag == 1)
                        pictureBoxAvg.BackgroundImage = X_or_V_pic.Images[1]; //error
                    else
                    {
                        pictureBoxAvg.BackgroundImage = X_or_V_pic.Images[0]; //v
                        countAVG = true;
                    }
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }



        }

        private void Clear_All_Button_Click(object sender, EventArgs e)
        {
            //Clear all input//
            ID_TB.Text = "";
            NAME_TB.Text = "";
            AVG_TB.Text = "";
            ADS_TB.Text = "";
            EMAIL_TB.Text = "";
            Type_Email_comboBox1.Text = "";
            Academic_comboBox1.Text = null;
            pictureBoxACADEMIC.BackgroundImage = null;

        } 

        private void NAME_TB_TextChanged(object sender, EventArgs e)
        {
            //Checking correct Name input//
            int flag = 0;
            
            if ( NAME_TB.Text=="")
            {
                pictureBoxName.BackgroundImage = null;
            }
            else
            {
                for (int i = 0; i < NAME_TB.Text.Length; i++)
                {
                    if ((NAME_TB.Text[i] >= 'A' && NAME_TB.Text[i] <= 'Z') || (NAME_TB.Text[i] >= 'a' && NAME_TB.Text[i] <= 'z'))
                    {
                        flag = 0; // Only Alphabet

                    }
                    else
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    pictureBoxName.BackgroundImage = X_or_V_pic.Images[0];
                    countName = true;
                }
                else
                    pictureBoxName.BackgroundImage = X_or_V_pic.Images[1];
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Semester_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxSemester.BackgroundImage = X_or_V_pic.Images[0]; //Adding 'V' When choosing semester//

        }

        private void Academic_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            pictureBoxACADEMIC.BackgroundImage = X_or_V_pic.Images[0]; //Adding 'V' When choosing year//
            
        }

        private void EMAIL_TB_TextChanged(object sender, EventArgs e)
        {
            //Checking EMAIL Correct input//
            int flag = 0;
            try {
              
                for (int i = 0; i < EMAIL_TB.Text.Length; i++)
                {
                    if (EMAIL_TB.Text[i] == '_'|| (EMAIL_TB.Text[i] >= '0' && EMAIL_TB.Text[i] <= '9') || (EMAIL_TB.Text[i] >= 'A' && EMAIL_TB.Text[i] <= 'Z') || (EMAIL_TB.Text[i] >= 'a' && EMAIL_TB.Text[i] <= 'z'))
                        flag = 0; //A-Z OR a-z OR _ OR NUMBERS ONLY!!!//
                    else
                    {
                        flag = 1;
                        break;
                    }
                 }
            }catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            if (flag == 0)
            {
                countEmail = true;
                pictureBoxEMAIL.BackgroundImage = X_or_V_pic.Images[0];
            }
            else
                pictureBoxEMAIL.BackgroundImage = X_or_V_pic.Images[1];
        }

        
        private void ADS_TB_TextChanged(object sender, EventArgs e)
        {
            //Checking correct Address input//
            if (ADS_TB.Text != "")
            {
                coutADS = true;
                pictureBox4.BackgroundImage = X_or_V_pic.Images[0];
            }
            else
                pictureBox4.BackgroundImage = null;

        }

        private void GoBack()
        {
            Application.Run(new FormStudents());
        }

        private void Populate()
        {
            //Pulling Data from SQL SERVER//
            con = new SqlConnection(connectionS);
            con.Open();
            string[] splitmail;
            SqlCommand cmd = new SqlCommand("SELECT * FROM  Student ORDER BY StudID", con);
            try
            {
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    if (StudentID.ToString().Trim() == read["StudID"].ToString().Trim())
                    { //For Editing student, choosing student's id and pulling rest of information //
                        ID_TB.Text = StudentID.ToString().Trim();
                        NAME_TB.Text = read["Name"].ToString().Trim();
                        Academic_comboBox1.Text = read["Year"].ToString().Trim();
                        Semester_CB.Text = read["Semester"].ToString().Trim();
                        AVG_TB.Text=read["Average"].ToString().Trim();
                        ADS_TB.Text = read["Address"].ToString().Trim();
                        splitmail = read["Email"].ToString().Split('@');
                        Type_Email_comboBox1.Text = splitmail[1];
                        EMAIL_TB.Text = splitmail[0];
                    }
                }
                read.Close();
                read.Dispose();
                con.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }



    }
}
