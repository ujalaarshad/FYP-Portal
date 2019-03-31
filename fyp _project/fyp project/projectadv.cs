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
    public partial class projectadv : Form
    {
        public projectadv()
        {
            InitializeComponent();
            FillCombobox1();
            FillCombobox();



        }
        string constr = "Data Source=DESKTOP-16KVTNK;Initial Catalog=ProjectA;User ID=sa;Password=123";
        protected void FillCombobox1()
        {


            SqlConnection conn = new SqlConnection(constr);
            DataTable ds = new DataTable();

            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("select Id from [Project]", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                foreach (DataRow t in ds.Rows)
                {
                    comboBoxprj.Items.Add(t["Id"].ToString());
                }
            }




        }
        protected void FillCombobox()
        {


            SqlConnection conn = new SqlConnection(constr);
            DataTable ds = new DataTable();

            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("select Id from [Advisor]", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                foreach (DataRow t in ds.Rows)
                {
                    comboBoxad.Items.Add(t["Id"].ToString());
                }
            }




        }
        private void projectadv_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(constr);
            c.Open();
            string s = comboBox1.Text;
            if (c.State == ConnectionState.Open)
            {
                string query1 = "Insert into [ProjectAdvisor] Values('" + Convert.ToInt32(comboBoxad.Text) + "','"+Convert.ToInt32(comboBoxprj.Text)+"',(Select Lookup.Id from Lookup where (Lookup.Value = '" + s + "')),'" + DateTime.Now + "' )";

                SqlCommand cmd3 = new SqlCommand(query1, c);
                cmd3.ExecuteNonQuery();
                //  c.Close();
                string selecteval = "Select *from ProjectAdvisor";
                SqlDataAdapter tbl = new SqlDataAdapter(selecteval, constr);
                DataTable tbls = new DataTable();
                tbl.Fill(tbls);

                dataGridView1.DataSource = tbls;

                dataGridView1.DataSource = tbls;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            SqlConnection c = new SqlConnection(constr);
            if (e.ColumnIndex == 4)


            {
                string qq = "DELETE FROM ProjectAdvisor WHERE ProjectAdvisor.ProjectId='" + selectedRow.Cells[1].Value.ToString() + "'";

                c.Open();


                SqlCommand r = new SqlCommand(qq, c);
                r.ExecuteNonQuery();
                MessageBox.Show("deleted sucessfully");

            }
        }
    }
}
