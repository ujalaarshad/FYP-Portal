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
    public partial class Addproject : Form
    {
        public Addproject()
        {
            InitializeComponent();
        }

        public string constr = "Data Source=DESKTOP-16KVTNK;Initial Catalog=ProjectA;User ID=sa;Password=123";

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(constr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string query = "Insert into [Project] Values('" + txtdesc.Text.ToString() + " ','" + txttitle.Text.ToString() + " ' )";

                SqlCommand s = new SqlCommand(query, c);
                s.ExecuteNonQuery();
                //  c.Close();
                // MessageBox.Show("sucess");
                string q = "Select *from Project";
                SqlDataAdapter tbl = new SqlDataAdapter(q, constr);
                DataTable tbls = new DataTable();
                tbl.Fill(tbls);

                
                dataGridView1.DataSource = tbls;
            ;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(btn);
                btn.HeaderText = "Delete";
                btn.Text = "Delete";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;

                DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(btn1);
                btn1.HeaderText = "Update";
                btn1.Text = "Update";
                btn1.Name = "btn1";
                btn1.UseColumnTextForButtonValue = true;

                MessageBox.Show("sucess");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            SqlConnection c = new SqlConnection(constr);
            if (e.ColumnIndex == 3)


            {
                string qq = "DELETE FROM Project WHERE Project.Id='" + selectedRow.Cells[0].Value.ToString() + "'";
               // string k = "DELETE FROM Student WHERE Student.Id='" + selectedRow.Cells[7].Value.ToString() + "'";
                c.Open();
                

                SqlCommand r = new SqlCommand(qq, c);
                r.ExecuteNonQuery();
                MessageBox.Show("deleted sucessfully");

            }
            if (e.ColumnIndex == 4)
            {
                int i = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[i];

              
                string des= row.Cells[1].Value.ToString();
                string title= row.Cells[2].Value.ToString();
                MessageBox.Show(title);

                List<string> l = new List<string>();
                l.Add(des);
                l.Add(title);
                
               UpdateProject frm = new UpdateProject(Convert.ToInt32(row.Cells[0].Value), l);
                frm.Show();
            }
        }

        private void txtdesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcontact_Click(object sender, EventArgs e)
        {

        }

        private void lblfname_Click(object sender, EventArgs e)
        {

        }

        private void Addproject_Load(object sender, EventArgs e)
        {
            
        }
    }
}
