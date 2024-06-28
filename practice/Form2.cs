using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class Form2 : Form
    {
        int total, payment, change;
        DataTable dt = new DataTable();

        public Form2(int total, DataTable dt)
        {
            InitializeComponent();
            this.total = total;
            this.dt = dt;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblTotal.Text = total.ToString();
            dtgItems.DataSource = dt;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            payment = int.Parse(txtPayment.Text);

            if(payment < total) {
                DialogResult dig = MessageBox.Show("Insufficient amount entered");
                

            } else {
                change = payment - total;
                MessageBox.Show("Item/s purchased successfully." + "\n Total Amount: " + total
                                                                 + "\n Payment Amount: " + payment
                                                                 + "\n Change: " + change);
            }
        }
    }
}
