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
    public partial class frmPurchase : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:/169_Caranguian_JanRomel_SC/169_Caranguian_JanRomel_schoolSupplies/dbSchoolSupplies.accdb");
        string query;

        string ID;
        string productName;
        int quantity;
        string price;

        public frmPurchase(string ID, string productName, int quantity, string price)
        {
            InitializeComponent();

            this.ID = ID;
            this.productName = productName;
            this.quantity = quantity;
            this.price = price;
        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {
            lblID.Text += " " + ID;
            lblProductName.Text += " " + productName;
            lblQuantity.Text += " " + quantity.ToString();
            lblPrice.Text += " " + price;
            lblTotalPrice.Text += (quantity * int.Parse(price)).ToString();

        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            
            OleDbCommand cmd = new OleDbCommand();

            if (!string.IsNullOrWhiteSpace(txtFirstName.Text) && !string.IsNullOrWhiteSpace(txtLastName.Text)) {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = ($"INSERT INTO Customer(firstName, lastName) VALUES('{txtFirstName.Text}', '{txtLastName.Text}');");
                cmd.ExecuteNonQuery();

                query = "SELECT * FROM Customer;";
                OleDbCommand command = new OleDbCommand(query, conn);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dtgCustomers.DataSource = dt;
                conn.Close();

               
            } else {
                MessageBox.Show("Empty Textbox/es");
            }

           

        }
    }
}
