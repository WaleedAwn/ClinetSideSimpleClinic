using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic_View.Patients
{
    public partial class frmShowPatientDetails : Form
    {
        private readonly PatientApiClient patientApiClient;
        int _PatientID;
        public frmShowPatientDetails(int PatientID)
        {
            InitializeComponent();
            _PatientID = PatientID;
            patientApiClient = new PatientApiClient();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmShowPatientDetails_Load(object sender, EventArgs e)
        {
            var Patient=await patientApiClient.Find(_PatientID);

            if (_PatientID == -1)
            {
                MessageBox.Show("This form will be closed because No Patient with ID = " + _PatientID);

                this.Close();
            }
            lbPatientID.Text = _PatientID.ToString();
            ctrlPersonCard1._LoadPersonData(Patient.Result.personId);
        
        
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            Form frm =new frmAddEditPatientinfo(_PatientID);
            frm.ShowDialog();

        }
    }





}
