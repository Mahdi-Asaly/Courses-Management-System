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
using System.Threading;

namespace Project_Sce.PL
{
    public partial class FrmStudentRequest : Form
    {
        DAL.DataBase DB = new DAL.DataBase();

        public FrmStudentRequest()
        {
            DB.open();
            InitializeComponent();
            Check_Detail_To_Aprrove_Or_Deny();
            Check_To_Save();
        }

        private void FrmStudentRequest_Load(object sender, EventArgs e)
        {

        }

        private void SearchBT_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string txt=null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Stud_Requests", DB.Return_Connection());
            try
            {

                SqlDataReader read = cmd.ExecuteReader();


                while (read.Read())
                {

                    if (Id_TB.Text == read["Id"].ToString().Trim())
                    {
                        txt = read["Reason"].ToString().Trim();
                        flag = 1;
                    }

                }
                read.Dispose();
                read.Close();
                if (flag == 1 && txt!=null)
                {
                    DetailsTB.Text = txt;
                    ReadName();
                    Check_Detail_To_Aprrove_Or_Deny();
                }
              
                if(flag==0)
                {
                    MessageBox.Show("Id not found!");
                }





            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
        }


        private void GoBackToHeadDepat()
        {
            Application.Run(new FrmAdmin());

        }
        private void ReturnBT_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(GoBackToHeadDepat);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void AprroveCB_CheckedChanged(object sender, EventArgs e)
        {
            Check_To_Save();
            if (AprroveCB.Checked)
            {
                DenyCB.Enabled = false;
            }
            else
                DenyCB.Enabled = true;
        }

        private void Check_Detail_To_Aprrove_Or_Deny()
        {
            if (DetailsTB.Text.Length == 0)
            {
                AprroveCB.Enabled = false;
                DenyCB.Enabled = false;
            }
            else
            {
                AprroveCB.Enabled = true;
                DenyCB.Enabled = true;

            }

        }
        private void Check_To_Save()
        {
            if(AprroveCB.Checked==true || DenyCB.Checked==true)
            {
                SaveBT.Enabled = true;
            }
            else
                SaveBT.Enabled = false;



        }

        private void ReadName()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Student", DB.Return_Connection());

            try
            {

                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    if (Id_TB.Text == read["StudID"].ToString().Trim())
                    {
                        StudName.Text = "Name : ";
                        StudName.Text += read["Name"].ToString().Trim();
                        StudName.Visible = true;

                    }


                }
                read.Dispose();
                read.Close();


            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            string answer = null;
            int flag = 0;
            if (AprroveCB.Checked==true)
            {
                answer = "Approved";
            }
            else if (DenyCB.Checked == true)
            {
                answer = "Deny";
            }


            SqlCommand cmd = new SqlCommand("INSERT INTO Requests(id,Choice,Reason) VALUES(@id,@ch,@re)", DB.Return_Connection());
            try
            {
                cmd.Parameters.AddWithValue("@id", Id_TB.Text);
                cmd.Parameters.AddWithValue("@ch", answer);
                cmd.Parameters.AddWithValue("@re", ReasonTB.Text);

                cmd.ExecuteNonQuery();

            }catch(SqlException exp)
            {
                flag = 1;
                MessageBox.Show(exp.Message);
            }
            if(flag==0)
            {
                Delete_Request();
                MessageBox.Show("send Sucsses!");
                ClearAll();
            }
            
              


        }

        private void DenyCB_CheckedChanged(object sender, EventArgs e)
        {
            Check_To_Save();
            if (DenyCB.Checked)
            {
                AprroveCB.Enabled = false;
            }
            else
                AprroveCB.Enabled = true;
        }


        private void Delete_Request()
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Stud_Requests WHERE Id=@id", DB.Return_Connection());
            try
            {


                cmd.Parameters.AddWithValue("@id", Id_TB.Text);
                cmd.ExecuteNonQuery();
            }catch(SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }


        }
        private void  ClearAll()
        {

            Id_TB.Text = "";
            DetailsTB.Text = "";
            ReasonTB.Text = "";
            Check_Detail_To_Aprrove_Or_Deny();
            Check_To_Save();
            

        }
    }
}
