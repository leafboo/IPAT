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
    public partial class frmNew_UpdateRecord : Form
    {
        string connectionStr = "server=localhost; database=db_act1; pwd=uslt; uid=root; port=3306";
        MySqlConnection conn;

        public frmNew_UpdateRecord()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string query = ($"INSERT INTO car(id, model, brand, year) VALUES({txtId.Text}, {txtModel.Text}, {cboBrand.Text}, {txtYear.Text})");
                conn = new MySqlConnection(connectionStr);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query = ($"UPDATE car SET model={txtModel.Text}, brand={cboBrand.Text}, year={txtYear.Text} WHERE id={txtId.Text}");
                conn = new MySqlConnection(connectionStr);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
          
        }
    }
}
