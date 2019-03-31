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
    public partial class updeval : Form
    {
        public updeval()
        {
            InitializeComponent();
            FillCombobox();
            FillCombobox1();

        }
        string constr = "Data Source=DESKTOP-16KVTNK;Initial Catalog=ProjectA;User ID=sa;Password=123";
        public int row;
        public List<string> l;

        public updeval(int i, List<string> t)
        {
            row = i;
            l = t;
            InitializeComponent();
           comboBoxeval.Text = t[1];
           comboBoxgrp.Text = t[0];
            textBox1.Text = t[2];
            dateTimePicker1.Text = t[3];



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
                SqlCommand cmd = new SqlCommand("select Id from [Evaluation]", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                foreach (DataRow t in ds.Rows)
                {
                    comboBoxeval.Items.Add(t["Id"].ToString());
                }
            }




        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            {
                SqlConnection c = new SqlConnection(constr);
                c.Open();


                string qeury1 = "Update [GroupEvaluation] set GroupId= '" + comboBoxgrp.Text.ToString() + "', EvaluationId= '" + Convert.ToInt32(comboBoxeval.Text) + "',ObtainedMarks='" + Convert.ToInt32(textBox1.Text) + "',EvaluationDate='" + Convert.ToDateTime(dateTimePicker1.Text)+ "' where( GroupEvaluation.GroupId='" + row + "')";
                SqlCommand w = new SqlCommand(qeury1, c);
                w.ExecuteNonQuery();

                MessageBox.Show("Updated Succesfully");
            }
        }
    }
}
