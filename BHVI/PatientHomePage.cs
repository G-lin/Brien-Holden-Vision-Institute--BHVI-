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
    public partial class PatientHomePage : Form
    {
        public PatientHomePage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updatePatient u = new updatePatient();
            u.Show(this);
            this.Hide();
        }

        private void btnaddp_Click(object sender, EventArgs e)
        {
            patientForm p = new patientForm();
            p.Show(this);
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Homepage h = new Homepage();
            h.Show(this);
            this.Hide();
        }

        private void btnviewp_Click(object sender, EventArgs e)
        {
            viewPatient v = new viewPatient();
            v.Show(this);
            this.Hide();
        }

        private void btndeletep_Click(object sender, EventArgs e)
        {
            deletePatient d = new deletePatient();
            d.Show(this);
            this.Hide();
        }
    }
}
