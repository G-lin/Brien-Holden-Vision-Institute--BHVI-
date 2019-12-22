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
    public partial class FrameForm : Form
    {
        public FrameForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtasellprice.Text = "";
            txtcolour.Text = "";
            txtfsellp.Text = "";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PatientHomePage p = new PatientHomePage();
            p.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Finances f = new Finances();
            f.Show(this);
            this.Hide();
        }
    }
}
