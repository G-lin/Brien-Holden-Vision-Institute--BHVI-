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
    public partial class PatientForm2 : Form
    {

        dbConnection db = new dbConnection();

        public PatientForm2(String patientNumber)
        {
            InitializeComponent();
            lpno.Text = patientNumber;
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            /*if (cmbstype.Text == null || cmbreferredto.Text == null || cmbreferredfrom.Text == null)
            {
                MessageBox.Show("Please fill all fields of service", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO patientdetailsspv(patientNumber, servicetype, referredto, referredfrom, rdist, ldist, add, vr, vl, var, val, dpd, npd, spectacles) values(@pno, @stype, @rto, @rfrom, @rdist, @ldist, @add, @vr, @vl, @var, @val, @dpd, @npd, @spect)", db.getConnection);

                cmd.Parameters.Add("@pno", MySqlDbType.VarChar).Value = lpno.Text;
                cmd.Parameters.Add("@stype", MySqlDbType.VarChar).Value = cmbstype.SelectedItem;
                cmd.Parameters.Add("@rto", MySqlDbType.VarChar).Value = cmbreferredto.SelectedItem;
                cmd.Parameters.Add("@rfrom", MySqlDbType.VarChar).Value = cmbreferredfrom.SelectedItem;

                cmd.Parameters.Add("@rdist", MySqlDbType.VarChar).Value = txtrdist1.Text;
                cmd.Parameters.Add("@ldist", MySqlDbType.VarChar).Value = txtldist1.Text;
                cmd.Parameters.Add("@add", MySqlDbType.VarChar).Value = cmbadd1.SelectedItem;

                cmd.Parameters.Add("@vr", MySqlDbType.VarChar).Value = cmbvr.SelectedItem;
                cmd.Parameters.Add("@vl", MySqlDbType.VarChar).Value = cmbvl.SelectedItem;

                cmd.Parameters.Add("@var", MySqlDbType.VarChar).Value = cmbvar.SelectedItem;
                cmd.Parameters.Add("@val", MySqlDbType.VarChar).Value = cmbval.SelectedItem;

                cmd.Parameters.Add("@dpd", MySqlDbType.VarChar).Value = cmbdistpd.SelectedItem;
                cmd.Parameters.Add("@npd", MySqlDbType.VarChar).Value = cmbnearpd.SelectedItem;

                String spect = "yes";

                if (rbtnno.Checked)
                {
                    spect = "No";
                }

                cmd.Parameters.Add("@spect", MySqlDbType.VarChar).Value = spect;
                

                db.openConnection();

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Patient service, prescription and vision details added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    */
                    if (rbtnyes.Checked)
                    {
                        LenseForm l = new LenseForm(lpno.Text);
                        l.Show(this);
                        this.Hide();
                    }
                    else
                    {
                        PatientHomePage p = new PatientHomePage();
                        p.Show(this);
                        this.Hide();
                    }
                    /*
                }
                
                
            }*/




        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtldist1.Text = "";
            txtrdist1.Text = "";
            cmbstype.Text = null;
            cmbreferredfrom.Text = null;
            cmbreferredto.Text = null;
            cmbadd1.Text = null;
            cmbvr.Text = null;
            cmbvl.Text = null;
            cmbvar.Text = null;
            cmbval.Text = null;
            cmbdistpd.Text = null;
            cmbnearpd.Text = null;

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PatientHomePage p = new PatientHomePage();
            p.Show(this);
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnyes_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
