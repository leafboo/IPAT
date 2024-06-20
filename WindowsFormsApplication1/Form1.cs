using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double Item1 = 120.00;
        double Item2 = 110.00;
        double Item3 = 125.00;
        double Item4 = 150.00;
        double Item5 = 90.00;
        double Item6 = 135.00;
        double Item7 = 155.00;
        double Item8 = 162.00;
        double PointsEarned;
        double Total = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void chkItem1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem1.Checked) {
                nudItem1.Enabled = true;
            } else {
                nudItem1.Value = 0;
                nudItem1.Enabled = false;
            }
            
        }

        private void chkItem2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem2.Checked) {
                nudItem2.Enabled = true;
            } else {
                nudItem2.Value = 0;
                nudItem2.Enabled = false;
            }
        }

        private void chkItem3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem3.Checked) {
                nudItem3.Enabled = true;
            } else {
                nudItem3.Value = 0;
                nudItem3.Enabled = false;
            }
        }

        private void chkItem4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem4.Checked) {
                nudItem4.Enabled = true;
            } else {
                nudItem4.Value = 0;
                nudItem4.Enabled = false;
            }
        }

        private void chkItem5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem5.Checked) {
                nudItem5.Enabled = true;
            } else {
                nudItem5.Value = 0;
                nudItem5.Enabled = false;
            }
        }

        private void chkItem6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem6.Checked) {
                nudItem6.Enabled = true;
            } else {
                nudItem6.Value = 0;
                nudItem6.Enabled = false;
            }
        }

        private void chkItem7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem7.Checked) {
                nudItem7.Enabled = true;
            } else {
                nudItem7.Value = 0;
                nudItem7.Enabled = false;
            }
        }

        private void chkItem8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItem1.Checked) {
                nudItem8.Enabled = true;
            } else {
                nudItem8.Value = 0;
                nudItem8.Enabled = false;
            }
        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            double tempTotal = 0;

            if(!chkItem1.Checked && !chkItem2.Checked && !chkItem3.Checked && !chkItem4.Checked && !chkItem5.Checked && !chkItem6.Checked && !chkItem7.Checked && !chkItem8.Checked) {
                MessageBox.Show("Please select an item from the menu.");
                
            } else if(!rdForHere.Checked && !rdToGo.Checked) {
                MessageBox.Show("Please select dining method."); 
            } else {
                tempTotal = computeOrder(tempTotal);

                if (rdToGo.Checked)
                {
                    tempTotal += 10;
                }

                if (chkMember.Checked)
                {
                    tempTotal -= 50;
                    PointsEarned = tempTotal * 0.03;
                    lblPoints.Text = "Points: " + PointsEarned.ToString();
                }
                else if (!chkMember.Checked)
                {
                    lblPoints.Text = "Points: ";
                }

                // Display
                if (tempTotal != Total)
                {
                    Total = tempTotal;
                    lblTotal.Text = "Total: " + Total.ToString();
                }
            }


        }

        public double computeOrder(double tempTotal)
        {
            if (chkItem1.Checked) {
                tempTotal += Item1 * double.Parse(nudItem1.Value.ToString());
            }
            if (chkItem2.Checked) {
                tempTotal += Item2 * double.Parse(nudItem2.Value.ToString());
            }
            if (chkItem3.Checked) {
                tempTotal += Item3 * double.Parse(nudItem3.Value.ToString());
            }
            if (chkItem4.Checked) {
                tempTotal += Item4 * double.Parse(nudItem4.Value.ToString());
            }
            if (chkItem5.Checked) {
                tempTotal += Item5 * double.Parse(nudItem5.Value.ToString());
            }
            if (chkItem6.Checked) {
                tempTotal += Item6 * double.Parse(nudItem6.Value.ToString());
            }
            if (chkItem7.Checked) {
                tempTotal += Item7 * double.Parse(nudItem7.Value.ToString());
            }
            if (chkItem8.Checked) {
                tempTotal += Item8 * double.Parse(nudItem8.Value.ToString());
            }
            return tempTotal;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }






















        private void clear()
        {
            lblTotal.Text = "Total:";
            lblPoints.Text = "Points:";
            chkMember.Checked = false;
            rdForHere.Checked = false;
            rdToGo.Checked = false;
            chkItem1.Checked = false;
            chkItem2.Checked = false;
            chkItem3.Checked = false;
            chkItem4.Checked = false;
            chkItem5.Checked = false;
            chkItem6.Checked = false;
            chkItem7.Checked = false;
            chkItem8.Checked = false;
            nudItem1.Enabled = false;
            nudItem2.Enabled = false;
            nudItem3.Enabled = false;
            nudItem4.Enabled = false;
            nudItem5.Enabled = false;
            nudItem6.Enabled = false;
            nudItem7.Enabled = false;
            nudItem8.Enabled = false;
            nudItem1.Value = 0;
            nudItem2.Value = 0;
            nudItem3.Value = 0;
            nudItem4.Value = 0;
            nudItem5.Value = 0;
            nudItem6.Value = 0;
            nudItem7.Value = 0;
            nudItem8.Value = 0;
        }
    }
}
