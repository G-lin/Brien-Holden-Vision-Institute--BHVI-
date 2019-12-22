using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHVI
{
    public partial class Login : Form
    {
        private const String connectionString = @"Data Source=THISHAN-TJ\SQLEXPRESS;Initial Catalog=BHVI;Integrated Security=True";

        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);

            SqlDataAdapter cmd = new SqlDataAdapter("select * from users where username ='"+txtusername.Text+"' AND password = '"+txtpassword.Text+"'", con);

            DataTable table = new DataTable();

            cmd.Fill(table);

            if(table.Rows.Count > 0)
            {
                Homepage h = new Homepage();
                h.Show(this);
                this.SetVisibleCore(false);
            }
            else
            {
                MessageBox.Show("Invalid username or password", "invalid login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           /* if(txtusername.Text.Equals("admin") && txtpassword.Text.Equals("admin"))
            {
                Homepage h = new Homepage();
                h.Show(this);
                this.SetVisibleCore(false);
            }*/

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to exit?","Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
