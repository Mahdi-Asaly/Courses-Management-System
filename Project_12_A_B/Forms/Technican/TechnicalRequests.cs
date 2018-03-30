using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Threading;
using System.Data.SqlClient;
namespace Project_12_A_B.Forms.Technican
{
    public partial class TechnicalRequests : MetroForm
    {
        public TechnicalRequests()
        {
            InitializeComponent();
            markV.BackColor = Color.Transparent;
            deletemark.BackColor = Color.Transparent;
            backmark.BackColor = Color.Transparent;
            loadReqs();
        }
        private void loadReqs() {
            ReqsList.View = View.Details;
            SqlDataAdapter ada = new SqlDataAdapter("select * from TechnicalReqs", Globals.conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["Id"].ToString());
                listitem.SubItems.Add(dr["Message"].ToString());
                ReqsList.Items.Add(listitem);
            }
        }
        private void TechnicalRequests_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FixedBtn_Click(object sender, EventArgs e)
        {
            
            if (ReqsList.SelectedItems.Count > 0)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM TechnicalReqs WHERE Id= @ID AND Message=@Message", Globals.conn))
                    {                    
                        cmd.CommandText = "DELETE FROM TechnicalReqs WHERE Id= @ID AND Message= @Message";
                        cmd.Parameters.AddWithValue("@ID", ReqsList.SelectedItems[0].Text);
                        cmd.Parameters.AddWithValue("@Message", ReqsList.SelectedItems[0].SubItems[1].Text);
                        cmd.ExecuteNonQuery();
                        ReqsList.Items.Remove(ReqsList.SelectedItems[0]);
                    }
                }
                catch(Exception ex) { MessageBox.Show("failed to connect to database more information:" + ex.ToString()); }
            }
            else
            {
                MessageBox.Show("Select an item to complete this process.");
            }
        }

    private void DeleteBtn_Click(object sender, EventArgs e)
    {
        //deleting a request , same functionality of "FIXED".
        if (ReqsList.SelectedItems.Count > 0){
        DialogResult result;
        result = MessageBox.Show("Are you sure you want to ignore this request?","DELETE",MessageBoxButtons.YesNo);
        if (result == DialogResult.No){return;}
        try{
            using (SqlCommand cmd = new SqlCommand("DELETE FROM TechnicalReqs WHERE Id= @ID AND Message=@Message", Globals.conn))
            {
                   cmd.CommandText = "DELETE FROM TechnicalReqs WHERE Id= @ID AND Message= @Message";
                   cmd.Parameters.AddWithValue("@ID", ReqsList.SelectedItems[0].Text);
                   cmd.Parameters.AddWithValue("@Message", ReqsList.SelectedItems[0].SubItems[1].Text);
                   cmd.ExecuteNonQuery();
                   ReqsList.Items.Remove(ReqsList.SelectedItems[0]);
                   MessageBox.Show("Successfully removed the request!");
            }
        }
        catch (Exception ex) { MessageBox.Show("failed to connect to database more information:" + ex.ToString()); }
        }
        else{MessageBox.Show("Select an item to complete this process!");}
    }
}
}
