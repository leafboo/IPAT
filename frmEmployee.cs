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

namespace _046_Pattaguan_Caranguian
{
    public partial class frmEmployee : Form
    {
        string connStr = "server=localhost; database=crud; pwd=uslt; uid=root; port=3306";
        string query;
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            query = "SELECT deptID FROM department";

            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cboDeptID.Items.Add(dr["deptID"].ToString());
            }

            dr.Close();
            conn.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cboCRUD.SelectedIndex == 0) // Create
            {
                query = ($@"INSERT INTO employee(emp_name, emp_age, emp_sex, marital_status, deptID) 
                        VALUES('{txtEmpName.Text}', {txtEmpAge.Text}, '{txtEmpSex.Text}', '{txtMarStat.Text}', {cboDeptID.Text})");
                MySqlConnection conn = new MySqlConnection(connStr);

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{txtEmpName.Text} is successfully added");
                conn.Close();
            }
            else if (cboCRUD.SelectedIndex == 1) // Read
            {

            }
            else if (cboCRUD.SelectedIndex == 2) // Update
            {
                query = ($@"UPDATE employee SET emp_name='{txtEmpName.Text}', emp_age={txtEmpAge.Text},
                        emp_sex='{txtEmpSex.Text}', marital_status='{txtMarStat.Text}', deptID={cboDeptID.Text} 
                        WHERE EmpID={txtEmpID.Text}");
                MySqlConnection conn = new MySqlConnection(connStr);

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{txtEmpName.Text} is successfully Updated!");
                conn.Close();
            }
            else if (cboCRUD.SelectedIndex == 3) //Delete
            {

            }
        }

        private void cboCRUD_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable textbox when Update is chosen
            if (cboCRUD.SelectedIndex == 2)
            {
                txtEmpID.Enabled = true;
            }
            else
            {
                txtEmpID.Enabled = false;
            }
        }
    }
}
