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
    public partial class reportingHomepage : Form
    {
        public reportingHomepage()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Homepage h = new Homepage();
            h.Show(this);
            this.Hide();
        }

        private void btnmreport_Click(object sender, EventArgs e)
        {
            Monitoring_report m = new Monitoring_report();
            m.Show(this);
            this.Hide();
        }

        private void btnfs_Click(object sender, EventArgs e)
        {
            Finance_summary f = new Finance_summary();
            f.Show(this);
            this.Hide();
        }

        private void btnor_Click(object sender, EventArgs e)
        {
            other_reporting o = new other_reporting();
            o.Show(this);
            this.Hide();
        }
    }
}
