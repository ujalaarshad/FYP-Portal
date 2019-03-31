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
    public partial class updategrp : Form
    {
        string constr = "Data Source=DESKTOP-16KVTNK;Initial Catalog=ProjectA;User ID=sa;Password=123";
        public updategrp()
        {
            InitializeComponent();
        }
        public int row;
        public List<string> l;

        public updategrp(int i, List<string> t)
        {
            row = i;
            l = t;
            InitializeComponent();
            txtstdid.Text = t[1];
            comboBox1.Text = t[0];
           
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
        private void updategrp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 n = new Form3(2);
            n.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(constr);
            c.Open();


            string qeury1 = "Update [GroupStudent] set GroupId= '" + comboBox1.Text.ToString() + "', StudentId= '" + Convert.ToInt32(txtstdid.Text) + "' where( GroupStudent.GroupId='" + row + "')";
            SqlCommand w = new SqlCommand(qeury1, c);
            w.ExecuteNonQuery();

            MessageBox.Show("Updated Succesfully");
        }
    }
    }

