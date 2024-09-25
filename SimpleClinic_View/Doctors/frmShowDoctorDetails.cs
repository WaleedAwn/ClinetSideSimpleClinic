using SimpleClinic_View.Patients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic_View.Doctors
{
    public partial class frmShowDoctorDetails : Form
    {
        private readonly DoctorApiClient _doctorAPI;

        int _doctorId=-1 ;
        public frmShowDoctorDetails(int DoctorID)
        {
            _doctorId = DoctorID;
            _doctorAPI = new DoctorApiClient();
            InitializeComponent();
        }

       

        private async void frmShowDoctorDetails_Load(object sender, EventArgs e)
        {
            var Doctor = await _doctorAPI.Find(_doctorId);

            if (_doctorId == -1)
            {
                MessageBox.Show("This form will be closed because No Doctor with ID = " + _doctorId);

                this.Close();
            }
            lbDoctoriD.Text = _doctorId.ToString();
            lbSpecialization.Text = Doctor.Result.Specialization.ToString();
            ctrlPersonCard1._LoadPersonData(Doctor.Result.PersonId);


        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
