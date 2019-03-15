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
    public partial class UpdateEvaluation : Form
    {
        public UpdateEvaluation()
        {
            InitializeComponent();
        }
        public int row;
        public List<string> l;
        public string constr = "Data Source=DESKTOP-16KVTNK;Initial Catalog=ProjectA;User ID=sa;Password=123";
        public UpdateEvaluation(int i, List<string> t)
        {
            row = i;
            l = t;
            InitializeComponent();
            txtnamep.Text = l[0];
           txttmarks.Text = l[1];
            txttotalwei.Text = l[2];





        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(constr);
            c.Open();


            string qeury1 = "Update [Evaluation] set Name= '" + txtnamep.Text.ToString() + "', TotalMarks= '" + Convert.ToInt32(txttmarks.Text) + "',TotalWeightage= '" + Convert.ToInt32(txttotalwei.Text) + "' where( Evaluation.Id='" + row + "')";
            SqlCommand w = new SqlCommand(qeury1, c);
            w.ExecuteNonQuery();

            MessageBox.Show("Updated Succesfully");
        }
    }
}
