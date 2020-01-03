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
    public partial class other_reporting : Form
    {
        public other_reporting()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            reportingHomepage h = new reportingHomepage();
            h.Show(this);
            this.Hide();
        }
    }
}
