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
    public partial class groupformation : Form
    {
        public groupformation()
        {
            InitializeComponent();
        }
        public string constr = "Data Source=DESKTOP-16KVTNK;Initial Catalog=ProjectA;User ID=sa;Password=123";
        private void button1_Click(object sender, EventArgs e)
        {


            SqlConnection c = new SqlConnection(constr);
            c.Open();



            if (c.State == ConnectionState.Open)
            {
                string query1 = "Insert into [Group] Values('" + DateTime.Now+ "' )";

                SqlCommand cmd3 = new SqlCommand(query1, c);
                cmd3.ExecuteNonQuery();
                //  c.Close();
                MessageBox.Show("sucess");

            }
        }
    }
}
