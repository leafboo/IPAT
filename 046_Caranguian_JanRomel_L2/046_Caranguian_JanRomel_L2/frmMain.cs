using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _046_Caranguian_JanRomel_L2
{
    public partial class ExcelImportingApp : Form
    {
        
        string query;
        OleDbConnection conn;

        public ExcelImportingApp()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtInput.TextLength > 0) {
                if (comboBox1.SelectedItem.ToString() == "Student") {

                    query = "SELECT * FROM [" + comboBox1.SelectedItem.ToString() + "$] WHERE [ID number] = " + txtInput.Text + " ";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dgMain.DataSource = dt;

                } else if (comboBox1.SelectedItem.ToString() == "Subject") {

                    query = "SELECT * FROM [" + comboBox1.SelectedItem.ToString() + "$] WHERE [code] = " + txtInput.Text + " ";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dgMain.DataSource = dt;
                }

            } else {
                MessageBox.Show("Input text box is Empty");
            }


            
        }

        private void importExcelFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text)) {
                MessageBox.Show("Pick a table.");
            } else {
                openFileDialog1.Title = "Open Excel";
                openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog1.Filter = "All files (*.*)|*.*|Excel File (*.xlsx)|*.xlsx";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.ShowDialog();

                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + openFileDialog1.FileName + "; Extended Properties='Excel 12.0 Xml; HDR=Yes'");
                query = "SELECT * FROM [" + comboBox1.SelectedItem.ToString() + "$]";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dgMain.DataSource = dt;
            }
            


        }

        private void ExcelImportingApp_Load(object sender, EventArgs e)
        {
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (conn == null) {
                MessageBox.Show("Import an excel file first");
            } else {
                query = "SELECT * FROM [" + comboBox1.SelectedItem.ToString() + "$]";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dgMain.DataSource = dt;
            }
           
        }
    }
        
}
