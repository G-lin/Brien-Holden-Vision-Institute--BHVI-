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
    public partial class FormsHomepage : Form
    {
        public FormsHomepage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prescription_form p = new Prescription_form();
            p.Show(this);
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Homepage h = new Homepage();
            h.Show(this);
            this.Hide();
        }

        private void btnreceipt_Click(object sender, EventArgs e)
        {
            receipt_form r = new receipt_form();
            r.Show(this);
            this.Hide();
        }

        private void btnquote_Click(object sender, EventArgs e)
        {
            Quote_form q = new Quote_form();
            q.Show(this);
            this.Hide();
        }
    }
}
