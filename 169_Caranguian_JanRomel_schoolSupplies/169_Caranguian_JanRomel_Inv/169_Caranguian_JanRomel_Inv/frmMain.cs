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
    public partial class frmMain : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:/169_Caranguian_JanRomel_SC/169_Caranguian_JanRomel_schoolSupplies/dbSchoolSupplies.accdb");
        string query;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM Product";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);

            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dtgMain.DataSource = dt;
        }

        private void btnGoToRecord_Click(object sender, EventArgs e)
        {
            frmRecordMgmt recordForm = new frmRecordMgmt();
            recordForm.ShowDialog();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if(int.Parse(txtQuantity.Text) <= 0) {
                MessageBox.Show("Low value.");
            }
            else if(int.Parse(txtQuantity.Text) <= int.Parse(dtgMain.SelectedCells[2].Value.ToString())) {
                frmPurchase purchaseForm = new frmPurchase(dtgMain.SelectedCells[0].Value.ToString(), dtgMain.SelectedCells[1].Value.ToString(), int.Parse(txtQuantity.Text), dtgMain.SelectedCells[3].Value.ToString());
                purchaseForm.ShowDialog();
            } else {
                MessageBox.Show("Entered quantity exceeds available stock.");
            }
            
        }
    }
}
