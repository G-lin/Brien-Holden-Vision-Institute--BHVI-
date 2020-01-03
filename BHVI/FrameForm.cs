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
    public partial class FrameForm : Form
    {
        dbConnection db = new dbConnection(); 

        public FrameForm(String patientNumber, String lprice)
        {
            InitializeComponent();
            lpno.Text = patientNumber;
            llprice.Text = lprice;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtasellprice.Text = "";
            txtcolour.Text = "";
            txtfsellp.Text = "";
            cmbfcode.Text = null;
            cmbfname.Text = null;
            cmbfmodel.Text = null;
            cmbsize.Text = null;
            cmbacode.Text = null;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PatientHomePage p = new PatientHomePage();
            p.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {/*
            if (cmbfcode.SelectedItem == null || cmbfname.SelectedItem == null || cmbfmodel.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {*/
                float tot;

                if (txtasellprice.Text == "")
                {
                    tot = float.Parse(txtfsellp.Text) + float.Parse(llprice.Text);
                }
                else
                {
                    tot = float.Parse(txtfsellp.Text) + float.Parse(txtasellprice.Text) + float.Parse(llprice.Text);
                }/*

                MySqlCommand cmd = new MySqlCommand("INSERT INTO patientframe(patientNumber, orderdate, fname, fcode, fmodel, colour, size, fprice, acode, aprice) values(@pno, @odate, @fname, @fcode, @fmodel, @colour, @fsize, @fprice, @acode, @aprice)", db.getConnection);

                cmd.Parameters.Add("@pno", MySqlDbType.VarChar).Value = lpno.Text;
                cmd.Parameters.Add("@odate", MySqlDbType.Date).Value = odate.Value;

                cmd.Parameters.Add("@fname", MySqlDbType.VarChar).Value = cmbfname.SelectedItem;
                cmd.Parameters.Add("@fcode", MySqlDbType.VarChar).Value = cmbfcode.SelectedItem;
                cmd.Parameters.Add("@fmodel", MySqlDbType.VarChar).Value = cmbfmodel.SelectedItem;
                cmd.Parameters.Add("@colour", MySqlDbType.VarChar).Value = txtcolour.Text;
                cmd.Parameters.Add("@fsize", MySqlDbType.VarChar).Value = cmbsize.SelectedItem;
                cmd.Parameters.Add("@fprice", MySqlDbType.Float).Value = txtfsellp.Text;

                cmd.Parameters.Add("@acode", MySqlDbType.VarChar).Value = cmbacode.SelectedItem;
                cmd.Parameters.Add("@aprice", MySqlDbType.Float).Value = txtasellprice.Text;

                db.openConnection();

                if(cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Patient's frame details saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    */
                    Finances f = new Finances(lpno.Text, tot);
                    f.Show(this);
                    this.Hide();/*
                }
            }*/
        }
    }
}
