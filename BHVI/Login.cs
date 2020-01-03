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
using MySql.Data.MySqlClient;

namespace BHVI
{
    public partial class Login : Form
    {
        //private const String connectionString = @"Data Source=THISHAN-TJ\SQLEXPRESS;Initial Catalog=BHVI;Integrated Security=True";

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
            dbConnection db = new dbConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable table = new DataTable();

            MySqlCommand cmd = new MySqlCommand("select * from users where username ='" + txtusername.Text + "' AND password = '" + txtpassword.Text + "'", db.getConnection);
            
            adapter.SelectCommand = cmd;
            adapter.Fill(table);

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
