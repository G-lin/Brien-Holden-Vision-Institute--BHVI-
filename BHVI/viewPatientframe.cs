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
    public partial class viewPatientframe : Form
    {
        dbConnection db = new dbConnection();
        DataTable dt = new DataTable();
        MySqlCommand cmd;
        MySqlDataAdapter adapter;

        public viewPatientframe()
        {
            InitializeComponent();
        }

        private void btnpframe_Click(object sender, EventArgs e)
        {
            viewPatientframe v = new viewPatientframe();
            v.Show(this);
            this.Hide();
        }

        private void btnpdetails_Click(object sender, EventArgs e)
        {
            viewPatient v = new viewPatient();
            v.Show(this);
            this.Hide();
        }

        private void btnspv_Click(object sender, EventArgs e)
        {
            viewPatientspv v = new viewPatientspv();
            v.Show(this);
            this.Hide();
        }

        private void btnplense_Click(object sender, EventArgs e)
        {
            viewPatientlense v = new viewPatientlense();
            v.Show(this);
            this.Hide();
        }

        private void btnpfiances_Click(object sender, EventArgs e)
        {
            viewPatientfinance v = new viewPatientfinance();
            v.Show(this);
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PatientHomePage h = new PatientHomePage();
            h.Show(this);
            this.Hide();
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dgvpdetails_MouseClick(object sender, MouseEventArgs e)
        {
            lpatientID.Text = dgvpdetails.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
