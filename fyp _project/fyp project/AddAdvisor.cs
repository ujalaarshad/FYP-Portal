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
    public partial class AddAdvisor : Form
    {
        public AddAdvisor()
        {
            InitializeComponent();
        }

        private void AddAdvisor_Load(object sender, EventArgs e)
        {
            



        }
        public string constr = "Data Source=DESKTOP-16KVTNK;Initial Catalog=ProjectA;User ID=sa;Password=123";
        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(constr);
            c.Open();
            string s = comboBoxsal.Text;
            string query = "Insert into [Person] Values('" + txtfname.Text.ToString() + " ','" + txtlast.Text.ToString() + " ' , '" + txtcon.Text.ToString() + " ' , '" + txtemail.Text.ToString() + " ' ,' " + Convert.ToDateTime(dateTimePickerDOB.Text) + " ','" + Convert.ToInt32(txtgender.Text) + " ' )";
            SqlCommand cmd4 = new SqlCommand(query, c);
            cmd4.ExecuteNonQuery();//exute query






            if (c.State == ConnectionState.Open)
            {
                string query1 = "Insert into [Advisor] Values((Select Max(Id) from [Person]),(Select Lookup.Id from Lookup where (Lookup.Value = '" + s+"'))," + Convert.ToDecimal(txtsal.Text) + " )";

                SqlCommand cmd3 = new SqlCommand(query1, c);
                cmd3.ExecuteNonQuery();
                //  c.Close();
                 MessageBox.Show("sucess");

            }
            string q = "Select Person.Id,Person.FirstName,Person.LastName,Person.Contact,Person.Email,Person.DateOfBirth,Person.Gender,Advisor.Designation, Advisor.Salary  FROM Person INNER JOIN Advisor ON Advisor.Id=Person.Id";
            SqlDataAdapter tbl = new SqlDataAdapter(q, constr);
            DataTable tbls = new DataTable();
            tbl.Fill(tbls);


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


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            SqlConnection c = new SqlConnection(constr);
            if (e.ColumnIndex == 9)


            {
                string qq = "DELETE FROM Person WHERE Person.Id='" + selectedRow.Cells[0].Value.ToString() + "'";
                string k = "DELETE FROM Advisor WHERE Advisor.Id='" + selectedRow.Cells[0].Value.ToString() + "'";
                c.Open();
                SqlCommand rr = new SqlCommand(k, c);
                rr.ExecuteNonQuery();

                SqlCommand r = new SqlCommand(qq, c);
                r.ExecuteNonQuery();
                MessageBox.Show("deleted sucessfully");

            }
            if (e.ColumnIndex == 10)
            {
                int i = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[i];

                string fname = row.Cells[1].Value.ToString();
                string lname = row.Cells[2].Value.ToString();
                string con = row.Cells[3].Value.ToString();
                string mail = row.Cells[4].Value.ToString();
                string dob = row.Cells[5].Value.ToString();
                string gender = row.Cells[6].Value.ToString();
                string des = row.Cells[7].Value.ToString();
                string sal=row.Cells[8].Value.ToString();
                List<string> l = new List<string>();
                l.Add(fname);
                l.Add(lname);
                l.Add(con);
                l.Add(mail);
                l.Add(dob);
                l.Add(gender);
                l.Add(sal);
                frmstudentupdate frm = new frmstudentupdate(Convert.ToInt32(row.Cells[0].Value), l);
                frm.Show();
            }
        }
    }
}
