using SimpleClinic_View.Doctors.DTOs;
using SimpleClinic_View.Globals;
using SimpleClinic_View.Users;
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
    public partial class ctrlDoctorCard : UserControl
    {

        private ApiResult<AllDoctorsInfoDTO> _doctorApiResult;
        private DoctorApiClient _doctorApiClient;
        private int _doctorId;
        public int DoctorId
        {
            get
            {
                return _doctorId;
            }
        }
        public ctrlDoctorCard()
        {
            InitializeComponent();
            _doctorApiClient = new DoctorApiClient();
            _doctorApiResult = new ApiResult<AllDoctorsInfoDTO>();
        }
        public async void LoadDoctorInfo(int DoctorID)
        {

            _doctorApiResult = await _doctorApiClient.Find(DoctorID);
            
            if (!_doctorApiResult.IsSuccess)
            {
                MessageBox.Show(_doctorApiResult.ErrorMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDoctorInfo();

            }
            else
                _FillDoctorInfo();

        }

        private void _ResetDoctorInfo()
        {

            lblDoctorId.Text = "????";
            lblSpecialization.Text = "????";
        }

        private void _FillDoctorInfo()
        {
            _doctorId = _doctorApiResult.Result.Id;

            ctrlPersonCard1._LoadPersonData(_doctorApiResult.Result.PersonId);
            lblDoctorId.Text = _doctorApiResult.Result.Id.ToString();
            lblSpecialization.Text = _doctorApiResult.Result.Specialization;

        }


    }
}
