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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        public string constr = "Data Source=DESKTOP-16KVTNK;Initial Catalog=ProjectA;User ID=sa;Password=123";
        private void btninsert_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(constr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string query = "Insert into [Person] Values('" + txtfname.Text.ToString() + " ','" + txtlast.Text.ToString() + " ' , '" + txtcon.Text.ToString() + " ' , '" + txtemail.Text.ToString() + " ' ,' " + Convert.ToDateTime(dateTimePickerDOB.Text) + " ','" + Convert.ToInt32(txtgender.Text) + " ' )";

                SqlCommand s = new SqlCommand(query, c);
                s.ExecuteNonQuery();
                //  c.Close();
                // MessageBox.Show("sucess");


                MessageBox.Show(txtregno.Text.ToString());
                string qeury = "Insert into [Student] Values ((Select Max(Id) from [Person]) ," + txtregno.Text.ToString() + ")";
                SqlCommand ss = new SqlCommand(qeury, c);
                ss.ExecuteNonQuery();
              
                MessageBox.Show("sucess");
                string q = "Select Person.FirstName,Person.LastName,Person.Contact,Person.Email,Person.DateOfBirth,Person.Gender,Student.RegistrationNo,Student.Id FROM Person INNER JOIN Student ON Student.Id=Person.Id";
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9) {
                int i = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[i];
                
                string fname = row.Cells[0].Value.ToString();
                string lname = row.Cells[1].Value.ToString();
                string con = row.Cells[2].Value.ToString();
                string mail = row.Cells[3].Value.ToString();
                string dob = row.Cells[4].Value.ToString();
                string gender = row.Cells[5].Value.ToString();
                string reg = row.Cells[6].Value.ToString();
                List<string> l = new List<string>();
                l.Add(fname);
                l.Add(lname);
                l.Add(con);
                l.Add(mail);
                l.Add(dob);
                l.Add(gender);
                l.Add(reg);
                frmstudentupdate frm = new frmstudentupdate(Convert.ToInt32(row.Cells[7].Value), l);
                frm.Show();
            }
           int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            SqlConnection c = new SqlConnection(constr);
            if (e.ColumnIndex == 8)


            {
                string qq= "DELETE FROM Person WHERE Person.Id='" + selectedRow.Cells[7].Value.ToString() + "'";
                string k= "DELETE FROM Student WHERE Student.Id='" + selectedRow.Cells[7].Value.ToString() + "'";
                c.Open();
                SqlCommand rr = new SqlCommand(k, c);
                rr.ExecuteNonQuery();

                SqlCommand r = new SqlCommand(qq,c);
                r.ExecuteNonQuery();
                MessageBox.Show("deleted sucessfully");

            }
        }

        private void Student_Load(object sender, EventArgs e)
        {
            string q = "Select Person.FirstName,Person.LastName,Person.Contact,Person.Email,Person.DateOfBirth,Person.Gender,Student.RegistrationNo,Student.Id FROM Person INNER JOIN Student ON Student.Id=Person.Id";
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

        private void lblRegNo_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtregno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgender_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlast_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblgender_Click(object sender, EventArgs e)
        {

        }

        private void lblDOB_Click(object sender, EventArgs e)
        {

        }

        private void lblemail_Click(object sender, EventArgs e)
        {

        }

        private void lblcontact_Click(object sender, EventArgs e)
        {

        }

        private void lbllname_Click(object sender, EventArgs e)
        {

        }

        private void lblfname_Click(object sender, EventArgs e)
        {

        }
    }
}
