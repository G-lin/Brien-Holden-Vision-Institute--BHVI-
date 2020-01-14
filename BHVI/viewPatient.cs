using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BHVI
{
    public partial class viewPatient : Form
    {
        dbConnection db = new dbConnection();
        DataTable dt = new DataTable();
        MySqlCommand cmd;
        MySqlDataAdapter adapter;

        public viewPatient()
        {
            InitializeComponent();

            dgvpdetails.ColumnCount = 10;
            dgvpdetails.Columns[0].Name = "Patient ID";
            dgvpdetails.Columns[1].Name = "Name";
            dgvpdetails.Columns[2].Name = "Address";
            dgvpdetails.Columns[3].Name = "Gender";
            dgvpdetails.Columns[4].Name = "Age";
            dgvpdetails.Columns[5].Name = "Adult/Child";
            dgvpdetails.Columns[6].Name = "Phone";
            dgvpdetails.Columns[7].Name = "Mobile";
            dgvpdetails.Columns[8].Name = "Disability";
            dgvpdetails.Columns[9].Name = "Date";

            dgvpdetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvpdetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvpdetails.MultiSelect = false;

            retrieve();
        }

        public void populate(String id, String name, String address, String gender, String age, String aC, String phone, String mob, String disab, String date)
        {
            dgvpdetails.Rows.Add(id, name, address, gender, age, aC, phone, mob, disab, date);
        }

        public void retrieve()
        {
            dgvpdetails.Rows.Clear();

            cmd = new MySqlCommand("Select * from patientdetails", db.getConnection);

            try
            {
                db.openConnection();

                adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dt);

                foreach(DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString());
                }

                db.closeConnection();

                dt.Rows.Clear();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                db.closeConnection();
            }
        }

        /*private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public DataTable Source()
        {
            db.openConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand("Select * from patientdetails");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                ds.Clear();
                adapter.Fill(ds);
                dt = ds.Tables[0];
                db.closeConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return dt;
        }

        private void updateEventHandler(object sender, patientForm.UpdateEventArgs args)
        {
            dgvpdetails.DataSource = Source();
        }*/

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

        private void dgvpdetails_CellContentClick(object sender, EventArgs e)
        {
            //dgvpdetails.DataSource = Source();
        }

        private void dgvpdetails_MouseClick(object sender, MouseEventArgs e)
        {
            lselectedPatientID.Text = dgvpdetails.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
