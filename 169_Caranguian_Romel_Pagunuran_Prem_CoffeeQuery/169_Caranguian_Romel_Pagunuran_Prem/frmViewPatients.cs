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
    public partial class frmViewPatients : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:/169_Caranguian_JanRomel_SC/169_Caranguian_Romel_Pagunuran_Prem_AppDB/dbHospital.accdb");
        string query;
        public frmViewPatients()
        {
            InitializeComponent();
        }

   
        private void frmViewPatients_Load(object sender, EventArgs e)
        {
            clearAndDisableEverything();

            query = "SELECT * FROM Patient";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dgPatients.DataSource = dt;
        }

        private void rdbSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSearch.Checked) {
                txtFirstName.Enabled = true;
            } else {
                clearAndDisableEverything();
            }
        }

       

        private void rdbCreate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCreate.Checked) {
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                txtBirthday.Enabled = true;
                txtSex.Enabled = true;
                txtCellphoneNumber.Enabled = true;
                txtAddress.Enabled = true;
                txtAge.Enabled = true;
            } else {
                clearAndDisableEverything();
            }
        }

        private void rdbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbUpdate.Checked) {
                txtID.Enabled = true;
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                txtBirthday.Enabled = true;
                txtSex.Enabled = true;
                txtCellphoneNumber.Enabled = true;
                txtAddress.Enabled = true;
                txtAge.Enabled = true;
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
            if (rdbSearch.Checked == false && rdbCreate.Checked == false && rdbUpdate.Checked == false && rdbDelete.Checked == false) {
                MessageBox.Show("Choose a query.");
            } else {
                if (rdbSearch.Checked)
                {
                    string firstName = txtFirstName.Text;
                    query = ($"SELECT * FROM Patient WHERE FirstName = '{firstName}'");
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dgPatients.DataSource = dt;
                    txtFirstName.Enabled = false;

                } else if (rdbCreate.Checked) {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = ($@"INSERT INTO Patient (FirstName, LastName, Sex, Birthday, Age, Address, CellphoneNumber)
                                        VALUES ('{txtFirstName.Text}', '{txtLastName.Text}', '{txtSex.Text}', '{txtBirthday.Text}', '{txtAge.Text}', '{txtAddress.Text}', '{txtCellphoneNumber.Text}');");
                    cmd.ExecuteNonQuery();

                } else if (rdbUpdate.Checked) {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = ($@"UPDATE Patient SET FirstName = '{txtFirstName.Text}', 
                                LastName ='{txtLastName.Text}',
                                Sex = '{txtSex.Text}',
                                Birthday = '{txtBirthday.Text}',
                                Age = '{txtAge.Text}',
                                Address = '{txtAddress.Text}',
                                CellphoneNumber = '{txtCellphoneNumber.Text}'
                                WHERE PatientID = {int.Parse(txtID.Text)};");
                    cmd.ExecuteNonQuery();

                } else if (rdbDelete.Checked) {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = ($"DELETE FROM Patient WHERE FirstName = '{txtFirstName.Text}';");
                    cmd.ExecuteNonQuery();

                }

                if (!rdbSearch.Checked) {
                    query = ("SELECT * FROM Patient");
                    OleDbCommand command = new OleDbCommand(query, conn);
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dgPatients.DataSource = dt;
                    conn.Close();
                }

                clearAndDisableEverything();
            }
        }

        public void clearAndDisableEverything()
        {
            txtID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtBirthday.Clear();
            txtSex.Clear();
            txtAge.Clear();
            txtAddress.Clear();
            txtCellphoneNumber.Clear();

            txtID.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtBirthday.Enabled = false;
            txtAge.Enabled = false;
            txtCellphoneNumber.Enabled = false;
            txtAddress.Enabled = false;
            txtSex.Enabled = false;
        }
    }
}
