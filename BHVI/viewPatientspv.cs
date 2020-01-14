using MySql.Data.MySqlClient;
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
    public partial class viewPatientspv : Form
    {
        dbConnection db = new dbConnection();
        DataTable dt = new DataTable();
        MySqlCommand cmd;
        MySqlDataAdapter adapter;

        public viewPatientspv()
        {
            InitializeComponent();

            dgvpdetails.ColumnCount = 14;
            dgvpdetails.Columns[0].Name = "Patient ID";
            dgvpdetails.Columns[1].Name = "Service type";
            dgvpdetails.Columns[2].Name = "Referred to";
            dgvpdetails.Columns[3].Name = "Referred from";
            dgvpdetails.Columns[4].Name = "R(dist)";
            dgvpdetails.Columns[5].Name = "L(dist)";
            dgvpdetails.Columns[6].Name = "Add";
            dgvpdetails.Columns[7].Name = "R vision(un)";
            dgvpdetails.Columns[8].Name = "L vision(un)";
            dgvpdetails.Columns[9].Name = "R va";
            dgvpdetails.Columns[10].Name = "L va";
            dgvpdetails.Columns[11].Name = "Dist pd";
            dgvpdetails.Columns[12].Name = "Near pd";
            dgvpdetails.Columns[13].Name = "Spectacles";

            dgvpdetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvpdetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvpdetails.MultiSelect = false;

            retrieve();
        }

        public void populate(String id, String stype, String rto, String rfrom, String rdist, String ldist, String add, String rvun, String lvun, String rva, String lva, String distpd, String nearpd, String spect)
        {
            dgvpdetails.Rows.Add(id, stype, rto, rfrom, rdist, ldist, add, rvun, lvun, rva, lva, distpd, nearpd, spect);
        }

        public void retrieve()
        {
            dgvpdetails.Rows.Clear();

            cmd = new MySqlCommand("Select * from patientdetailsspv", db.getConnection);

            try
            {
                db.openConnection();

                adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString(), row[10].ToString(), row[11].ToString(), row[12].ToString(), row[13].ToString());
                }

                db.closeConnection();

                dt.Rows.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                db.closeConnection();
            }
        }

        private void btnspv_Click(object sender, EventArgs e)
        {
            viewPatientspv v = new viewPatientspv();
            v.Show(this);
            this.Hide();
        }

        private void btnpdetails_Click(object sender, EventArgs e)
        {
            viewPatient v = new viewPatient();
            v.Show(this);
            this.Hide();
        }

        private void btnplense_Click(object sender, EventArgs e)
        {
            viewPatientlense v = new viewPatientlense();
            v.Show(this);
            this.Hide();
        }

        private void btnpframe_Click(object sender, EventArgs e)
        {
            viewPatientframe v = new viewPatientframe();
            v.Show(this);
            this.Hide();
        }

        private void btnpfiances_Click(object sender, EventArgs e)
        {
            viewPatientfinance v = new viewPatientfinance();
            v.Show(this);
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PatientHomePage h = new PatientHomePage();
            h.Show(this);
            this.Hide();
        }

        private void dgvpdetails_MouseClick(object sender, MouseEventArgs e)
        {
            lpatientID.Text = dgvpdetails.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
