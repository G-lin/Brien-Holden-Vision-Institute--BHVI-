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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void btnforms_Click(object sender, EventArgs e)
        {
            FormsHomepage f = new FormsHomepage();
            f.Show(this);
            this.Hide();
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            reportsHomepage r = new reportsHomepage();
            r.Show(this);
            this.Hide();
        }

        private void btnreporting_Click(object sender, EventArgs e)
        {
            reportingHomepage rp = new reportingHomepage();
            rp.Show(this);
            this.Hide();
        }

        private void btnstocks_Click(object sender, EventArgs e)
        {
            StocksHomepage s = new StocksHomepage();
            s.Show(this);
            this.Hide();
        }

        private void btnpatient_Click(object sender, EventArgs e)
        {
            PatientHomePage p = new PatientHomePage();
            p.Show(this);
            this.Hide();
        }
    }
}
