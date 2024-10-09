using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DB_ACT1_046_Caranguian
{
    public partial class frmMain : Form
    {
        // does this run if the mysql workbench is turned off?
        string connectionStr = "server=localhost; database=db_act1; pwd=uslt; uid=root; port=3306";
        MySqlConnection conn;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchCar();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKeyword.Clear();
            grdResults.DataSource = null;
            grdResults.Rows.Clear();
            cboBrand.SelectedIndex = -1;
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            searchCar();
        }

        void searchCar()
        {
            if (string.IsNullOrEmpty(cboBrand.Text)) {
                txtKeyword.Clear();
                MessageBox.Show("Select a car brand first");
            } else{
                DataTable dt = new DataTable();

                dt.Columns.Add("MODEL");
                dt.Columns.Add("BRAND");
                dt.Columns.Add("YEAR");

                conn = new MySqlConnection(connectionStr);
                string query = ($"SELECT model, brand, year FROM car WHERE model LIKE '{txtKeyword.Text}%' AND brand='{cboBrand.Text}';");
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                conn.Close();
                grdResults.DataSource = dt;
            }
           
        }
    }
}
