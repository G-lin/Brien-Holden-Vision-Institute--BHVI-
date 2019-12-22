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
    public partial class LenseForm : Form
    {
        public LenseForm()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            FrameForm f = new FrameForm();
            f.Show(this);
            this.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbfseght.Text = "";
            txtlsprice.Text = "";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PatientHomePage p = new PatientHomePage();
            p.Show(this);
            this.Hide();
        }
    }
}
