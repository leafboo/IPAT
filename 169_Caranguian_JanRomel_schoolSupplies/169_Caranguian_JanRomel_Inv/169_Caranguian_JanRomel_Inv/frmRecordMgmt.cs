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


namespace _169_Caranguian_JanRomel_Inv
{

    public partial class frmRecordMgmt : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:/169_Caranguian_JanRomel_SC/169_Caranguian_JanRomel_schoolSupplies/dbSchoolSupplies.accdb");
        string query;
        public frmRecordMgmt()
        {
            InitializeComponent();
        }

        private void frmRecordMgmt_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = ($@"INSERT INTO Product(productName, quantity, price) 
                                VALUES('{txtProductName.Text}', {txtQuantity.Text}, '{txtPrice.Text}');");
            cmd.ExecuteNonQuery();
            displayData();
            conn.Close();

        }

        public void displayData() {
            query = "SELECT * FROM Product";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);

            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dtgRecord.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = ($@"UPDATE Product 
                                SET productName = '{txtProductName.Text}', quantity = {txtQuantity.Text}, price = '{txtPrice.Text}' 
                                WHERE productID = {txtProductID.Text};");
            cmd.ExecuteNonQuery();
            displayData();
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = ($"DELETE FROM Product WHERE productID = {txtProductID.Text}");
            cmd.ExecuteNonQuery();
            displayData();
            conn.Close();
        }
    }
}
