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
    public partial class reportsHomepage : Form
    {
        public reportsHomepage()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Homepage h = new Homepage();
            h.Show(this);
            this.Hide();
        }

        private void btnbankslip_Click(object sender, EventArgs e)
        {
            BankSlip b = new BankSlip();
            b.Show();
            this.Hide();
        }

        private void btnsrPx_Click(object sender, EventArgs e)
        {
            Sales_report_by_patient s = new Sales_report_by_patient();
            s.Show(this);
            this.Hide();
        }

        private void btndailyrec_Click(object sender, EventArgs e)
        {

        }

        private void btntakingsreport_Click(object sender, EventArgs e)
        {
            Takingsreport t = new Takingsreport();
            t.Show(this);
            this.Hide();
        }

        private void btnsalesreport_Click(object sender, EventArgs e)
        {
            Salesreport s = new Salesreport();
            s.Show(this);
            this.Hide();
        }
    }
}
