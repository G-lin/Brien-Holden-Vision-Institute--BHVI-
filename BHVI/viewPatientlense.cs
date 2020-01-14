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
    public partial class viewPatientlense : Form
    {
        dbConnection db = new dbConnection();
        DataTable dt = new DataTable();
        MySqlCommand cmd;
        MySqlDataAdapter adapter;

        public viewPatientlense()
        {
            InitializeComponent();

            dgvpdetails.ColumnCount = 10;
            dgvpdetails.Columns[0].Name = "Patient ID";
            dgvpdetails.Columns[1].Name = "Date";
            dgvpdetails.Columns[2].Name = "Lense type";
            dgvpdetails.Columns[3].Name = "Status";
            dgvpdetails.Columns[4].Name = "BF seg Ht";
            dgvpdetails.Columns[5].Name = "Material";
            dgvpdetails.Columns[6].Name = "Lense code";
            dgvpdetails.Columns[7].Name = "Rms power";
            dgvpdetails.Columns[8].Name = "Sell price";
            dgvpdetails.Columns[9].Name = "Frame";

            dgvpdetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvpdetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvpdetails.MultiSelect = false;

            retrieve();
        }

        public void populate(String id, String date, String ltype, String status, String bfseght, String mat, String lcode, String rmspower, String price, String frame)
        {
            dgvpdetails.Rows.Add(id, date, ltype, status, bfseght, mat, lcode, rmspower, price, frame);
        }

        public void retrieve()
        {
            dgvpdetails.Rows.Clear();

            cmd = new MySqlCommand("Select * from patientlense", db.getConnection);

            try
            {
                db.openConnection();

                adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString());
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

        private void btnplense_Click(object sender, EventArgs e)
        {
            viewPatientlense v = new viewPatientlense();
            v.Show(this);
            this.Hide();
        }

        private void btnpdetails_Click(object sender, EventArgs e)
        {
            viewPatient v = new viewPatient();
            v.Show(this);
            this.Hide();
        }

        private void btnspv_Click(object sender, EventArgs e)
        {
            viewPatientspv v = new viewPatientspv();
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
