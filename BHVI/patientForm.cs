using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHVI
{
    public partial class patientForm : Form
    {

        dbConnection db = new dbConnection();

        public patientForm()
        {
            InitializeComponent();
        }

        public void patientForm_Load(object sender, EventArgs e)
        {
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Homepage h = new Homepage();
            h.Show(this);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Homepage h = new Homepage();
            h.Show(this);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Homepage h = new Homepage();
            h.Show(this);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Homepage h = new Homepage();
            h.Show(this);
            this.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtpno.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
            txtage.Text = "";
            txtphone.Text = "";
            txtmob.Text = "";
            txtdisability.Text = "";
        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtage_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtmob_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmob_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientHomePage p = new PatientHomePage();
            p.Show(this);
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //txtpno.Text.Equals("") || txtname.Text.Equals("") || txtaddress.Text.Equals("") || txtpno.Text.Equals("") || txtage.Text.Equals("") || txtphone.Text.Equals("") || txtmob.Text.Equals("") || txtdisability.Text.Equals("")
            /*if (txtpno.Text == "" || txtname.Text == "" || txtaddress.Text == "" || txtage.Text == "" )
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            { 
                MySqlCommand cmd = new MySqlCommand("INSERT INTO patientdetails(patientNumber, patientName, address, gender, age, adultChild, phone, mobile, disability, date) values(@pno, @pname, @addr, @gend, @age, @adultchild, @phone, @mobile, @disability, @date)", db.getConnection);

                cmd.Parameters.Add("@pno", MySqlDbType.VarChar).Value = txtpno.Text;
                cmd.Parameters.Add("@pname", MySqlDbType.VarChar).Value = txtname.Text;
                cmd.Parameters.Add("@addr", MySqlDbType.VarChar).Value = txtaddress.Text;

                String gend = "Male";

                if (rbtnfemale.Checked)
                {
                    gend = "Female";
                }

                cmd.Parameters.Add("@gend", MySqlDbType.VarChar).Value = gend;
                cmd.Parameters.Add("@age", MySqlDbType.VarChar).Value = txtage.Text;

                String adch = "Adult";

                if (rbtnchild.Checked)
                {
                    adch = "Child";
                }

                cmd.Parameters.Add("@adultchild", MySqlDbType.VarChar).Value = adch;
                cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = txtphone.Text;
                cmd.Parameters.Add("@mobile", MySqlDbType.VarChar).Value = txtmob.Text;
                cmd.Parameters.Add("@disability", MySqlDbType.VarChar).Value = txtdisability.Text;
                cmd.Parameters.Add("@date", MySqlDbType.Date).Value = date.Value;

                db.openConnection();

                if(cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Patient details saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    */
                    PatientForm2 p = new PatientForm2(txtpno.Text);
                    p.Show();
                    this.Hide();/*
                }

                
            }*/
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
