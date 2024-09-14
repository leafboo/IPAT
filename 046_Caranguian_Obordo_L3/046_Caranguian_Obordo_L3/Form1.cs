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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            txtFirstName.Clear();
            txtLastName.Clear();
            cmbDepartment.SelectedIndex = -1;
        }

        private void importExcelFile_Click(object sender, EventArgs e)
        {
            openExcel.Title = "Open Excel"; // Initialize the title of the dialogue box
            openExcel.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openExcel.Filter = "All files (*.*)|*.*|Excel File (*.xlsx)|*.xlsx";
            openExcel.FilterIndex = 2;

            if (openExcel.ShowDialog() == DialogResult.OK) {

                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + openExcel.FileName + "; Extended Properties='Excel 12.0 Xml; HDR=Yes'"); // HDR=Yes makes the first row in the excel file the header/column name in the datatable
                
                // SQL query
                query = "SELECT * FROM [Sheet1$]";
                OleDbCommand cmd = new OleDbCommand(query, conn);

                // Data adapter to fill the data into a datatable
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                // Fill the DataTable with the values of the SQL Query that is in the dataAdapter
                dataAdapter.Fill(dt);

              
                // Loop through each row of the "dept" column in the DataTable and add it to the comboBox
                for (int i = 0; i < dt.Rows.Count; i++) {
                    cmbDepartment.Items.Add(dt.Rows[i]["dept"].ToString());
                }

                /* Alternative way
                 
                 foreach (DataRow row in dt.Rows) {
                    cmbDepartment.Items.Add(row["dept"]);
                 }

                */

            }
        }

        private void importTextFile_Click(object sender, EventArgs e)
        {
            openText.Title = "Open Text";
            openText.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openText.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt";
            openText.FilterIndex = 2;

            if (openText.ShowDialog() == DialogResult.OK)
            {
                string [] departments = File.ReadAllLines(openText.FileName);
                for (int i = 0; i < departments.Length;i++) {
                    cmbDepartment.Items.Add (departments[i]);
                }

                /* Alternative way
                 
                foreach (string department in departments) {
                    cmbDepartment.Items.Add(department);
                }

                */
            }
        }

        private void btnSaveForm_Click(object sender, EventArgs e)
        {
            saveText.Title = "Save as file";
            saveText.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveText.DefaultExt = "txt";
            saveText.Filter = "(*.*)|*.*|Text File(*.txt)|*.txt";
            saveText.FilterIndex = 2;

            // Save dataGrid data to string array for testing purposes

            if (saveText.ShowDialog() == DialogResult.OK) {
                using (StreamWriter writer = File.CreateText(saveText.FileName)) {
                    // Skip the last row because it is empty, hence, dtgMain.Rows.Count - 1
                    for (int i = 0; i < dtgMain.Rows.Count - 1; i++) {
                        writer.WriteLine(dtgMain.Rows[i].Cells["First Name"].Value.ToString());
                        writer.WriteLine(dtgMain.Rows[i].Cells["Last Name"].Value.ToString());
                        writer.WriteLine(dtgMain.Rows[i].Cells["Department"].Value.ToString() + "\n");
                    }
                }
            }
           

        }
    }
}
