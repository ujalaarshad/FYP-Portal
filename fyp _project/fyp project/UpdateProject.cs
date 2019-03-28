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
    public partial class UpdateProject : Form
    {
        public UpdateProject()
        {
            InitializeComponent();
        }
        public int row;
        public List<string> l;
        public string constr = "Data Source=DESKTOP-16KVTNK;Initial Catalog=ProjectA;User ID=sa;Password=123";
        public UpdateProject(int i, List<string> t)
        {
            row = i;
            l = t;
            InitializeComponent();
            txtdesc.Text = l[0];
           txttitle.Text = l[1];


          


        }


        private void btnadd_Click(object sender, EventArgs e)
        {

            SqlConnection c = new SqlConnection(constr);
            c.Open();
            
   
            string qeury1 = "Update [Project] set Title= '" + txttitle.Text.ToString() + "',Description= '" + txtdesc.Text.ToString() + "' where( Project.Id='" + row + "')";
            SqlCommand w = new SqlCommand(qeury1, c);

            
            w.ExecuteNonQuery();
            
            MessageBox.Show("Updated Succesfully");
        }

        private void txtdesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcontact_Click(object sender, EventArgs e)
        {

        }

        private void lblfname_Click(object sender, EventArgs e)
        {

        }

        private void UpdateProject_Load(object sender, EventArgs e)
        {

        }
    }
}
