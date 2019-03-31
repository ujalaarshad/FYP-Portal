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
    public partial class Groupstudent : Form
    {
        string constr = "Data Source=DESKTOP-16KVTNK;Initial Catalog=ProjectA;User ID=sa;Password=123";
        public Groupstudent()
        {
            InitializeComponent();
            FillCombobox();
        }

        private void Groupstudent_Load(object sender, EventArgs e)
        {

        }

        public int row;
        public List<string> l;

        public Groupstudent(int i, List<string> t)
        {
            row = i;
            l = t;
            InitializeComponent();
            txtstdid.Text = i.ToString();
            FillCombobox();







        }


        protected void FillCombobox()
        {


            SqlConnection conn = new SqlConnection(constr);
            DataTable ds = new DataTable();

            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("select Id from [Group]", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                foreach (DataRow t in ds.Rows)
                {
                    comboBox1.Items.Add(t["Id"].ToString());
                }
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(constr);
            c.Open();

            int i = 3;


            if (c.State == ConnectionState.Open)
            {
                string query1 = "Insert into [GroupStudent] Values('" + Convert.ToInt32(comboBox1.Text)+"','"+Convert.ToInt32(txtstdid.Text) +"','"+i+"','" + DateTime.Now + "' )";

                SqlCommand cmd3 = new SqlCommand(query1, c);
                cmd3.ExecuteNonQuery();
                //  c.Close();
                string selecteval = "Select *from GroupStudent";
                SqlDataAdapter tbl = new SqlDataAdapter(selecteval, constr);
                DataTable tbls = new DataTable();
                tbl.Fill(tbls);

                dataGridView1.DataSource = tbls;
       

                DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(btn1);
                btn1.HeaderText = "Update";
                btn1.Text = "Update";
                btn1.Name = "btn1";
                btn1.UseColumnTextForButtonValue = true;


                MessageBox.Show("sucess");





            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 n = new Form3(1);
            this.Hide();
            n.Show();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) { 
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            SqlConnection c = new SqlConnection(constr);
            int i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];


            string grpid = row.Cells[0].Value.ToString();
            string stdid = row.Cells[1].Value.ToString();
            string ststus = row.Cells[2].Value.ToString();
            string assdate = row.Cells[3].Value.ToString();


            List<string> l = new List<string>();
            l.Add(grpid);
            l.Add(stdid);
            l.Add(ststus);
            l.Add(assdate);

           updategrp frm = new updategrp(Convert.ToInt32(row.Cells[0].Value), l);
            frm.Show();
        }
        }

        private void txtstdid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


