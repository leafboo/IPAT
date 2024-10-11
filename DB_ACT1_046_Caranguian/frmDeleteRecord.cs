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
    public partial class frmDeleteRecord : Form
    {
        string connectionStr = "server=localhost; database=db_act1; pwd=uslt; uid=root; port=3306";
        MySqlConnection conn;

        public frmDeleteRecord()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtModel.Text) || cboBrand.SelectedIndex == -1) 
            {
                MessageBox.Show("All input fields are required");
            } 
            else 
            {
                try 
                {
                    string query = ($"DELETE FROM car WHERE model={txtModel.Text} AND brand={cboBrand.Text}");
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
}
