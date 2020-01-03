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
    public partial class LenseForm : Form
    {
        dbConnection db = new dbConnection();

        public LenseForm(String patientNumber)
        {
            InitializeComponent();
            lpno.Text = patientNumber;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            /*if (cmblcode.Text == null )
            {
                MessageBox.Show("Please fill the lense code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            { 
                MySqlCommand cmd = new MySqlCommand("INSERT INTO patientlense(patientNumber, orderdate, lensetype, status, bfseght, material, lensecode, rmspower, lsellprice) values(@pno, @odate, @ltype, @status, @bfseght, @material, @lcode, @rmspower, @lprice)", db.getConnection);

                cmd.Parameters.Add("@pno", MySqlDbType.VarChar).Value = lpno.Text;
                cmd.Parameters.Add("@odate", MySqlDbType.Date).Value = odate.Value;

                cmd.Parameters.Add("@ltype", MySqlDbType.VarChar).Value = cmbltype.SelectedItem;
                cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = cmbstatus.SelectedItem;
                cmd.Parameters.Add("@bfseght", MySqlDbType.VarChar).Value = txtbfseght.Text;
                cmd.Parameters.Add("@material", MySqlDbType.VarChar).Value = cmblmaterial.SelectedItem;

                cmd.Parameters.Add("@lcode", MySqlDbType.VarChar).Value = cmblcode.SelectedItem;
                cmd.Parameters.Add("@rmspower", MySqlDbType.VarChar).Value = cmbrmspower.SelectedItem;
                cmd.Parameters.Add("@lprice", MySqlDbType.Float).Value = txtlsprice.Text;

                db.openConnection();

                if(cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Patient's lense details saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    */
                    if (rbtnyes.Checked)
                    {
                        FrameForm f = new FrameForm(lpno.Text, txtlsprice.Text);
                        f.Show(this);
                        this.Hide();
                    }
                    else
                    {
                        Finances f = new Finances(lpno.Text, float.Parse(txtlsprice.Text));
                        f.Show(this);
                        this.Hide();
                    }/*

                }

                
            }
            */

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbfseght.Text = "";
            txtlsprice.Text = "";
            cmbltype.Text = null;
            cmbstatus.Text = null;
            cmblmaterial.Text = null;
            cmblcode.Text = null;
            cmbrmspower.Text = null;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PatientHomePage p = new PatientHomePage();
            p.Show(this);
            this.Hide();
        }
    }
}
