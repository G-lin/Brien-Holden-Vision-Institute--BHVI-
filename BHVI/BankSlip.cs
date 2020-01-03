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
    public partial class BankSlip : Form
    {
        public BankSlip()
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
