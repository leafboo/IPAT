using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _169_Caranguian_Romel_Pagunuran_Prem
{
    public partial class frmViewDoctors : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:/169_Caranguian_JanRomel_SC/169_Caranguian_Romel_Pagunuran_Prem_AppDB/dbHospital.accdb");
        string query;
        public frmViewDoctors()
        {
            InitializeComponent();
        }

        private void frmViewDoctors_Load(object sender, EventArgs e)
        {
            clearAndDisableEverything();

            query = "SELECT * FROM Doctor";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dgDoctors.DataSource = dt;
        }

        private void rdbSearch_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbSearch.Checked) {
                txtFirstName.Enabled = true;
            } else {
                clearAndDisableEverything();
            }
        }

        private void rdbCreate_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbCreate.Checked) {
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                txtBirthday.Enabled = true;
                txtEmail.Enabled = true;
                txtCellphoneNumber.Enabled = true;
                txtAddress.Enabled = true;
                txtSpecialization.Enabled = true;
            } else {
                clearAndDisableEverything();
            }
        }

        private void rdbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbUpdate.Checked) {
                txtID.Enabled = true;
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                txtBirthday.Enabled = true;
                txtEmail.Enabled = true;
                txtCellphoneNumber.Enabled = true;
                txtAddress.Enabled = true;
                txtSpecialization.Enabled = true;
            } else {
                clearAndDisableEverything();
            }
        }

        private void rdbDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDelete.Checked) {
                txtFirstName.Enabled = true;
            } else {
                clearAndDisableEverything();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (rdbSearch.Checked == false && rdbCreate.Checked == false && rdbUpdate.Checked == false && rdbDelete.Checked == false)
            {
                MessageBox.Show("Choose a query.");
            }
            else {
                if (rdbSearch.Checked) { 
                    string firstName = txtFirstName.Text;
                    query = ($"SELECT * FROM Doctor WHERE FirstName = '{firstName}'");
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dgDoctors.DataSource = dt;
                    txtFirstName.Enabled = false;

                } else if (rdbCreate.Checked) {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = ($@"INSERT INTO Doctor (FirstName, LastName, Birthday, Address, CellphoneNumber, Email, Specialization)
                                        VALUES ('{txtFirstName.Text}', '{txtLastName.Text}', '{txtBirthday.Text}', '{txtAddress.Text}', '{txtCellphoneNumber.Text}', '{txtEmail.Text}', '{txtSpecialization.Text}');");
                    cmd.ExecuteNonQuery();

                } else if (rdbUpdate.Checked) {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = ($@"UPDATE Doctor SET FirstName = '{txtFirstName.Text}', 
                                LastName ='{txtLastName.Text}',
                                Birthday = '{txtBirthday.Text}',
                                Address = '{txtAddress.Text}',
                                CellphoneNumber = '{txtCellphoneNumber.Text}',
                                Email = '{txtEmail.Text}',
                                Specialization = '{txtSpecialization.Text}'
                                WHERE doctorID = {int.Parse(txtID.Text)};");
                    cmd.ExecuteNonQuery();

                } else if (rdbDelete.Checked) {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = ($"DELETE FROM Doctor WHERE FirstName = '{txtFirstName.Text}';");
                    cmd.ExecuteNonQuery();

                }

                if (!rdbSearch.Checked) {
                    query = ("SELECT * FROM Doctor");
                    OleDbCommand command = new OleDbCommand(query, conn);
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dgDoctors.DataSource = dt;
                    conn.Close();
                }

                clearAndDisableEverything();
            }

        }


        public void clearAndDisableEverything() {
            txtID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtBirthday.Clear();
            txtEmail.Clear();
            txtCellphoneNumber.Clear();
            txtAddress.Clear();
            txtSpecialization.Clear();

            txtID.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtBirthday.Enabled = false;
            txtEmail.Enabled = false;
            txtCellphoneNumber.Enabled = false;
            txtAddress.Enabled = false;
            txtSpecialization.Enabled = false;
        }
    }
}
