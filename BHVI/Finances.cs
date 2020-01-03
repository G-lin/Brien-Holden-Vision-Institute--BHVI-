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
    public partial class Finances : Form
    {

        dbConnection db = new dbConnection();

        public Finances(String patientNumber, float price)
        {
            InitializeComponent();
            lpno.Text = patientNumber;
            lsaleprice.Text = price.ToString();
            ltotal.Text = price.ToString();
            ldueamount.Text = price.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdis.Text = "";
            txtreceiptno.Text = "";
            txtamt.Text = "";
            cmbptype.Text = null;
        }

        private void txtamt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtreceiptno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtdis_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PatientHomePage p = new PatientHomePage();
            p.Show(this);
            this.Hide();
        }

        private void txtdis_TextChanged(object sender, EventArgs e)
        {
            float gtot = float.Parse(lsaleprice.Text) - (float.Parse(lsaleprice.Text) * (float.Parse(txtdis.Text) / 100) );
            ltotal.Text = gtot.ToString();
        }

        private void txtamt_TextChanged(object sender, EventArgs e)
        {   
            float due = float.Parse(ltotal.Text) - float.Parse(txtamt.Text);
            ldueamount.Text = due.ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtreceiptno.Text == "" || cmbptype.SelectedItem == null || txtamt.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO patientfinance(patientNumber, saleamnt, discount, total, receiptnum1, type1, pay1, pay1date, duepay, receiptnum2, type2, pay2, pay2date) values(@pno, @saleamnt, @disc, @tot, @rcptnum1, @type1, @pay1, @payday1, @due, @rcptnum2, @type2, @pay2, @payday2)", db.getConnection);

                cmd.Parameters.Add("@pno", MySqlDbType.VarChar).Value = lpno.Text;
                cmd.Parameters.Add("@saleamnt", MySqlDbType.Float).Value = lsaleprice.Text;
                cmd.Parameters.Add("@disc", MySqlDbType.VarChar).Value = txtdis.Text;
                cmd.Parameters.Add("@tot", MySqlDbType.Float).Value = ltotal.Text;

                cmd.Parameters.Add("@rcptnum1", MySqlDbType.VarChar).Value = txtreceiptno.Text;
                cmd.Parameters.Add("@type1", MySqlDbType.VarChar).Value = cmbptype.SelectedItem;
                cmd.Parameters.Add("@pay1", MySqlDbType.Float).Value = txtamt.Text;
                cmd.Parameters.Add("@payday1", MySqlDbType.Date).Value = datep.Value;

                cmd.Parameters.Add("@due", MySqlDbType.Float).Value = ldueamount.Text;

                cmd.Parameters.Add("@rcptnum2", MySqlDbType.VarChar).Value = null;
                cmd.Parameters.Add("@type2", MySqlDbType.VarChar).Value = null;
                cmd.Parameters.Add("@pay2", MySqlDbType.Float).Value = null;
                cmd.Parameters.Add("@payday2", MySqlDbType.Date).Value = null;

                db.openConnection();

                if(cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Patient's finance details saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    PatientHomePage p = new PatientHomePage();
                    p.Show(this);
                    this.Hide();
                }
            }
        }
    }
}
