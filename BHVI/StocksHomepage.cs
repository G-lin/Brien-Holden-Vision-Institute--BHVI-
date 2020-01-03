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
    public partial class StocksHomepage : Form
    {
        public StocksHomepage()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Homepage h = new Homepage();
            h.Show(this);
            this.Hide();
        }

        private void btnframes_Click(object sender, EventArgs e)
        {
            frames_stock f = new frames_stock();
            f.Show(this);
            this.Hide();
        }

        private void btnlenses_Click(object sender, EventArgs e)
        {
            lense_stock l = new lense_stock();
            l.Show(this);
            this.Hide();
        }

        private void btnnonstock_Click(object sender, EventArgs e)
        {
            non_stock ns = new non_stock();
            ns.Show(this);
            this.Hide();
        }
    }
}
