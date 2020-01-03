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
    public partial class viewPatientspv : Form
    {
        public viewPatientspv()
        {
            InitializeComponent();
        }

        private void btnspv_Click(object sender, EventArgs e)
        {
            viewPatientspv v = new viewPatientspv();
            v.Show(this);
            this.Hide();
        }

        private void btnpdetails_Click(object sender, EventArgs e)
        {
            viewPatient v = new viewPatient();
            v.Show(this);
            this.Hide();
        }

        private void btnplense_Click(object sender, EventArgs e)
        {
            viewPatientlense v = new viewPatientlense();
            v.Show(this);
            this.Hide();
        }

        private void btnpframe_Click(object sender, EventArgs e)
        {
            viewPatientframe v = new viewPatientframe();
            v.Show(this);
            this.Hide();
        }

        private void btnpfiances_Click(object sender, EventArgs e)
        {
            viewPatientfinance v = new viewPatientfinance();
            v.Show(this);
            this.Hide();
        }
    }
}
