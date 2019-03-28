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

namespace fyp_project
{
    public partial class ManageEvaluation : Form
    {
        public ManageEvaluation()
        {
            InitializeComponent();
        }

        private void lblcontact_Click(object sender, EventArgs e)
        {

        }
        public string constr = "Data Source=DESKTOP-16KVTNK;Initial Catalog=ProjectA;User ID=sa;Password=123";
        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(constr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string query = "Insert into [Evaluation] Values('" + txtnamep.Text.ToString() + " ','" + Convert.ToInt32(txttmarks.Text) + " ','"+ Convert.ToInt32(txttotalwei.Text)+" ' )";

                SqlCommand s = new SqlCommand(query, c);
                s.ExecuteNonQuery();
                //  c.Close();
                // MessageBox.Show("sucess");
                
                     string selecteval = "Select *from Evaluation";
                SqlDataAdapter tbl = new SqlDataAdapter(selecteval, constr);
                DataTable tbls = new DataTable();
                tbl.Fill(tbls);


                dataGridViewEVal.DataSource = tbls;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                this.dataGridViewEVal.Columns[0].Visible = false;
                dataGridViewEVal.Columns.Add(btn);
                btn.HeaderText = "Delete";
                btn.Text = "Delete";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;

                DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
                dataGridViewEVal.Columns.Add(btn1);
                btn1.HeaderText = "Update";
                btn1.Text = "Update";
                btn1.Name = "btn1";
                btn1.UseColumnTextForButtonValue = true;
                

                MessageBox.Show("sucess");

            }
        }

        private void dataGridViewEVal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dataGridViewEVal.Rows[index];
            SqlConnection c = new SqlConnection(constr);
            if (e.ColumnIndex == 4)


            {
                string qq = "DELETE FROM Evaluation WHERE Evaluation.Id='" + selectedRow.Cells[0].Value.ToString() + "'";
               
                c.Open();


                SqlCommand r = new SqlCommand(qq, c);
                r.ExecuteNonQuery();
                MessageBox.Show("deleted sucessfully");

            }
            if (e.ColumnIndex == 5)
            {
                int i = e.RowIndex;
                DataGridViewRow row = dataGridViewEVal.Rows[i];

              
        string Nam = row.Cells[1].Value.ToString();
                string TotMarks = row.Cells[2].Value.ToString();
        string tltweight = row.Cells[3].Value.ToString();
        

                List<string> l = new List<string>();
                l.Add(Nam);
                l.Add(TotMarks);
                l.Add(tltweight);


                UpdateEvaluation frm = new UpdateEvaluation(Convert.ToInt32(row.Cells[0].Value), l);
                frm.Show();
            }
        }

        private void txtnamep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttotalwei_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttmarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbllname_Click(object sender, EventArgs e)
        {

        }

        private void lblfname_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewEVal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
