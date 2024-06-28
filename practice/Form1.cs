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
    public partial class chkAirMax : Form
    {
        int item1 = 3500;
        int item2 = 4200;
        int item3 = 7800;
        int item4 = 6000;
        int item5 = 5400;
        int item6 = 3800;
        int total = 0;

        public chkAirMax()
        {
            InitializeComponent();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if(chkItem1.Checked == true || chkItem2.Checked == true || chkItem3.Checked == true || chkItem4.Checked == true || chkItem5.Checked == true || chkItem6.Checked == true) {

                DataTable dt = new DataTable();
                dt.Columns.Add("Item");
                dt.Columns.Add("Price");
                compute(dt);

                Form2 frm2 = new Form2(total, dt);
                frm2.ShowDialog();
                clear();
            } else {
                MessageBox.Show("You need to check atleast one.");
            }
            
        }


        public void compute(DataTable dt) {
            if (chkItem1.Checked == true)
            {
                total += item1;
                dt.Rows.Add("Balmain", item1);
            }
            if (chkItem2.Checked == true)
            {
                total += item2;
                dt.Rows.Add("Air Jordan", item2);
            }
            if (chkItem3.Checked == true)
            {
                total += item3;
                dt.Rows.Add("Air Mag", item3);
            }
            if (chkItem4.Checked == true)
            {
                total += item4;
                dt.Rows.Add("Court Vision", item4);
            }
            if (chkItem5.Checked == true)
            {
                total += item5;
                dt.Rows.Add("Elevate", item1);
            }
            if (chkItem6.Checked == true)
            {
                total += item6;
                dt.Rows.Add("Air Maxs", item1);
            }
        }

        public void clear() {
            chkItem1.Checked = false;
            chkItem2.Checked = false;
            chkItem3.Checked = false;
            chkItem4.Checked = false;
            chkItem5.Checked = false;
            chkItem6.Checked = false;
            total = 0;
        }
    }
}
