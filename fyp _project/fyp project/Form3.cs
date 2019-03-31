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
    public partial class Form3 : Form
    {
        int flag;
        public string constr = "Data Source=DESKTOP-16KVTNK;Initial Catalog=ProjectA;User ID=sa;Password=123";
        public Form3()
        {
            InitializeComponent();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "ADD";
            btn.Text = "Add";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            string q = "Select *from Student";
            SqlDataAdapter tbl = new SqlDataAdapter(q, constr);
            DataTable tbls = new DataTable();
            tbl.Fill(tbls);


            dataGridView1.DataSource = tbls;

        }
        public Form3(int i)
        {
            InitializeComponent();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "ADD";
            btn.Text = "Add";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            string q = "Select *from Student";
            SqlDataAdapter tbl = new SqlDataAdapter(q, constr);
            DataTable tbls = new DataTable();
            tbl.Fill(tbls);


            dataGridView1.DataSource = tbls;
            flag = i;
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==0)
            {
                MessageBox.Show("cell clicked");

                int i = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[i];


               // string id = row.Cells[0].Value.ToString();
                string reg = row.Cells[2].Value.ToString();
               

                List<string> l = new List<string>();
              //  l.Add(id);
                l.Add(reg);
                if (flag == 1)
                {


                    Groupstudent frm = new Groupstudent(Convert.ToInt32(row.Cells[1].Value), l);

                    frm.Show();
                }
                else if (flag == 2)
                {
                    updategrp f = new updategrp(Convert.ToInt32(row.Cells[1].Value), l);

                    f.Show();
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
