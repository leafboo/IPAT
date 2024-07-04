using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _169_Caranguian_Romel_Pagunuran_Prem
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(cboPatientDoctor.Text == "Patient")
            {
                frmViewPatients patientform = new frmViewPatients();
                patientform.ShowDialog();
            }
            else if(cboPatientDoctor.Text == "Doctor")
            {
                frmViewDoctors doctorform = new frmViewDoctors();
                doctorform.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
