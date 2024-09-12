using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _046_Caranguian_Obordo_L3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string query;
        OleDbConnection conn;
        DataTable dt = new DataTable();

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || cmbDepartment.SelectedIndex == -1) {
                MessageBox.Show("All input fields are required");
            }
            else {
                
                dt.Rows.Add(txtFirstName.Text.ToString(), txtLastName.Text.ToString(), cmbDepartment.SelectedItem.ToString());
                dtgMain.DataSource = dt;
                resetValues();
            }   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Department");
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            dt.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetValues();
        }

        public void resetValues() {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            cmbDepartment.SelectedIndex = -1;
        }
    }
}
