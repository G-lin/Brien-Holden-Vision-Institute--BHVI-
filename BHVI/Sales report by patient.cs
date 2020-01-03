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
    public partial class Sales_report_by_patient : Form
    {
        public Sales_report_by_patient()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            reportsHomepage r = new reportsHomepage();
            r.Show(this);
            this.Hide();
        }
    }
}
