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
    public partial class updateprojectgrp : Form
    {
        string constr = "Data Source=DESKTOP-16KVTNK;Initial Catalog=ProjectA;User ID=sa;Password=123";
        public updateprojectgrp()
        {
            InitializeComponent();
            FillCombobox();
            FillCombobox1();
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
                    comboBoxgrp.Items.Add(t["Id"].ToString());
                }
            }




        }

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

        public int row;
        public List<string> l;

        public updateprojectgrp(int i, List<string> t)
        {
            row = i;
            l = t;
            InitializeComponent();
            comboBoxprj.Text = t[1];
          comboBoxgrp.Text = t[0];
            dateTimePicker1.Text = t[2];


            FillCombobox();
            FillCombobox1();







        }

        private void updateprojectgrp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                SqlConnection c = new SqlConnection(constr);
                c.Open();
            if (c.State == ConnectionState.Open)
            {


                string qeury1 = "Update [GroupProject] set ProjectId= '" +Convert.ToInt32(comboBoxprj.Text) + "', GroupId= '" + Convert.ToInt32(comboBoxgrp.Text) + "',AssignmentDate='" + Convert.ToDateTime(dateTimePicker1.Text) + "' where( GroupProject.GroupId='" + row + "')";
                SqlCommand w = new SqlCommand(qeury1, c);
                w.ExecuteNonQuery();

                MessageBox.Show("Updated Succesfully");
            }
            
        }
    }
}
