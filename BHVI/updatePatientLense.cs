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
    public partial class updatePatientLense : Form
    {
        public updatePatientLense()
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
            updatePatient u = new updatePatient();
            u.Show(this);
            this.Hide();
        }

        private void btnaddpayment_Click(object sender, EventArgs e)
        {
            PaymentForm p = new PaymentForm();
            p.Show(this);
            this.Hide();
        }

        private void btnspv_Click(object sender, EventArgs e)
        {
            updatePatientSPV p = new updatePatientSPV();
            p.Show(this);
            this.Hide();
        }

        private void btnplense_Click(object sender, EventArgs e)
        {
            updatePatientLense p = new updatePatientLense();
            p.Show(this);
            this.Hide();
        }

        private void btnpframe_Click(object sender, EventArgs e)
        {
            updatePatientFrame p = new updatePatientFrame();
            p.Show(this);
            this.Hide();
        }

        private void btnpfiances_Click(object sender, EventArgs e)
        {
            updatePatientFinance p = new updatePatientFinance();
            p.Show(this);
            this.Hide();
        }
    }
}
