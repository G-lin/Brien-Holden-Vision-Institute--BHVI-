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
    public partial class deletePatientFinance : Form
    {
        public deletePatientFinance()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PatientHomePage h = new PatientHomePage();
            h.Show(this);
            this.Hide();
        }

        private void btnpdetails_Click(object sender, EventArgs e)
        {
            deletePatient d = new deletePatient();
            d.Show(this);
            this.Hide();
        }

        private void btnspv_Click(object sender, EventArgs e)
        {
            deletePatientSPV d = new deletePatientSPV();
            d.Show(this);
            this.Hide();
        }

        private void btnplense_Click(object sender, EventArgs e)
        {
            deletePatientLense d = new deletePatientLense();
            d.Show(this);
            this.Hide();
        }

        private void btnpframe_Click(object sender, EventArgs e)
        {
            deletePatientFrame d = new deletePatientFrame();
            d.Show(this);
            this.Hide();
        }

        private void btnpfiances_Click(object sender, EventArgs e)
        {
            deletePatientFinance d = new deletePatientFinance();
            d.Show(this);
            this.Hide();
        }
    }
}
