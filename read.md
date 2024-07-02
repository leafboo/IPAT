OleDbConnection conn = new OleDbConnection(/*PASTE PATH HERE*/);  // global variable
string query = "SELECT * FROM patients";

OleDbCommand cmd = new OleDbCommand(query, conn);
OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
DataTable dt = new DataTable();

dataAdapter.Fill(dt);
dataGridView1.DataSource = dt;

if(dt.Rows.Count == 1) {
    MessageBox.Show("No results found")
}