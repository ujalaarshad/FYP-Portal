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
    public partial class UpdateAdvisor : Form
    {
        public UpdateAdvisor()
        {
            InitializeComponent();
        }
        public int row;
        public List<string> l;
        public string constr = "Data Source=DESKTOP-16KVTNK;Initial Catalog=ProjectA;User ID=sa;Password=123";
        public UpdateAdvisor(int i, List<string> t)
        {
            row = i;
            l = t;
            InitializeComponent();
            txtfname.Text = l[0];
            txtlast.Text = l[1];
            txtcon.Text = l[2];
            txtemail.Text = l[3];
            dateTimePickerDOB.Text = l[4];
            txtgender.Text = l[5];
            comboBoxsal.Text = l[6];
            txtsal.Text = l[7];


        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(constr);
            c.Open();
            string desig = comboBoxsal.Text.ToString();
            string query = "Update [Person] Set FirstName='" + txtfname.Text.ToString() + " ',LastName='" + txtlast.Text.ToString() + " ', Contact=  '" + txtcon.Text.ToString() + " ', Email=  '" + txtemail.Text.ToString() + " ' ,DateOfBirth=' " + Convert.ToDateTime(dateTimePickerDOB.Text) + " ', Gender='" + Convert.ToInt32(txtgender.Text) + "' where (Person.Id='" + row + "')  ";
            string qeury1 = "Update [Advisor] set Designation=(Select Lookup.Id From Lookup where (Lookup.Value='" + desig + "')), Salary= '" + Convert.ToDecimal(txtsal.Text) + "' where( Advisor.Id='" + row + "')";
            SqlCommand w = new SqlCommand(query, c);
            SqlCommand ee = new SqlCommand(qeury1, c);
            w.ExecuteNonQuery();
            ee.ExecuteNonQuery();
            MessageBox.Show("Updated Succesfully");
            this.Hide();
        }

        private void UpdateAdvisor_Load(object sender, EventArgs e)
        {

        }
    }
}
