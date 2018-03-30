using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Project_12_A_B;

namespace Project_Sce.CodeLayer
{
    public class Classroom
    {
        private string name;
        private int seats_num;
        private Boolean projector, computer;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int SeatsNum
        {
            get { return this.seats_num; }
            set { this.seats_num = value; }
        }

        public Boolean Projector
        {
            get { return this.projector; }
            set { this.projector = value; }
        }

        public Boolean Computer 
        {
            get { return this.computer; }
            set { this.computer = value; }
        }

        public Classroom() { }

        public Classroom(string name_, int seats_num_, Boolean projector_, Boolean computer_)
        {
            this.name = name_;
            this.seats_num = seats_num_;
            this.projector = projector_;
            this.computer = computer_;
        }

        public void Add_Classroom(string name, int seats_num, Boolean proj, Boolean comp)
        {
            Project_Sce.DAL.DataBase DAl = new Project_Sce.DAL.DataBase();
            DAl.open();
            SqlParameter[] p = new SqlParameter[4];
            p[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            p[0].Value = name;

            p[1] = new SqlParameter("@seats_num", SqlDbType.Int);
            p[1].Value = seats_num;

            p[2] = new SqlParameter("@projector", SqlDbType.Bit);
            p[2].Value = proj;

            p[3] = new SqlParameter("@computer", SqlDbType.Bit);
            p[3].Value = comp;

            DAl.Execute("Adding_Classroom", p);
            DAl.close();
        }

        public void Delete_Classroom(string name)
        {
            Project_Sce.DAL.DataBase DAl = new Project_Sce.DAL.DataBase();
            DAl.open();
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            p[0].Value = name;

            DAl.Execute("Deleting_Classroom", p);
            DAl.close();
        }

        public void Update_Classroom(string name, int seats_num, Boolean proj, Boolean comp)
        {
            Project_Sce.DAL.DataBase DAl = new Project_Sce.DAL.DataBase();
            try
            {
                DAl.open();
                SqlCommand cmd = new SqlCommand("UPDATE Class SET seats_num=@seats_num, projector=@projector, computer=@computer WHERE name = @name", DAl.Return_Connection());
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@seats_num", seats_num);
                cmd.Parameters.AddWithValue("@projector", proj);
                cmd.Parameters.AddWithValue("@computer", comp);
                cmd.ExecuteNonQuery();
                
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            DAl.close();
        }

    }
}
