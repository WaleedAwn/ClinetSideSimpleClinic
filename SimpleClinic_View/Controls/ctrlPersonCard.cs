using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleClinic_View.Globals;
using SimpleClinic_View.Patients;
using SimpleClinic_View.Patients.DTOs;
using SimpleClinic_View.Person;
using SimpleClinic_View.Person.DTOs;
using SimpleClinic_View.Users.DTOs;


namespace SimpleClinic_View.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        private ApiResult<PersonsDTO> _apiResult;
        private ApiResult<AllPatientInfoDTO> _patientApiResult;
        private PatientApiClient _patinet;

        private int _PersonId = -1;
        private int _PatientId = -1; 
        private bool _FindPatient = false;

        public int PatientId
        {
            get
            {
                return _PatientId;
            }
        }
        public int PersonId
        {
            get
            {
                return _PersonId;
            }
        }
        public ApiResult<PersonsDTO> SelectedPersonInfo
        {
            get
            {
                return _apiResult;
            }
        }

        public ctrlPersonCard()
        {
            InitializeComponent();
            _apiResult  = new ApiResult<PersonsDTO>();
            _patientApiResult = new ApiResult<AllPatientInfoDTO>();
            _patinet = new PatientApiClient();

        }
        public async void _LoadPersonData(int _PersonID)
        {
            _FindPatient = false;
            MessageBox.Show($"{_PersonID}");
             _apiResult = await PersonApiClient.StatFind(_PersonID);

            if(!_apiResult.IsSuccess)
            {
                MessageBox.Show(_apiResult.ErrorMessage, nameof(_apiResult.Status), MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetDeffultValues();
                return;
            }
            else
                _FillPersonInfo();


        }
        private void _PatientIdVisiblty()
        {
            lblPatientIdValue.Visible = _FindPatient;
            lblPatientId.Visible = _FindPatient;

        }
        public async void _LoadPatientData(int patientId)
        {
            _FindPatient = true;
            _patientApiResult = await _patinet.Find(patientId);

            if (!_patientApiResult.IsSuccess)
            {
                MessageBox.Show(_patientApiResult.ErrorMessage, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetDeffultValues();
                return;
            }
            else
                _FillPatientInfo();

        }

        private void ResetDeffultValues()
        {

            lbPersonID.Text = "[???]";
            lblName.Text = "[???]";
            lblPhone.Text = "[???]";
            lblEmail.Text = "[???]";
            lblDateOfBirth.Text = "[???]";
            lblAddress.Text = "[???]";
            lblGender.Text = "[???]";
            lblPatientIdValue.Text = "[???]";

            _PatientIdVisiblty();
        }

        private void _FillPersonInfo()
        {
            _PatientIdVisiblty();
            _PersonId = _apiResult.Result.Id;
            string formattedDateOfBirth = _apiResult.Result.DateOfBirth.ToString("yyyy-MM-dd");
            lbPersonID.Text = _apiResult.Result.Id.ToString();
            lblName.Text = _apiResult.Result.PersonName.ToString();
            lblPhone.Text = _apiResult.Result.PhoneNumber.ToString();
            lblEmail.Text = _apiResult.Result.Email.ToString();
            lblDateOfBirth.Text = formattedDateOfBirth.ToString();
            lblAddress.Text = _apiResult.Result.Address.ToString();
            lblGender.Text = _apiResult.Result.Gender.ToString();
        }

        private void _FillPatientInfo()
        {
            // show the patientId label
            _PatientIdVisiblty();

             _PatientId = _patientApiResult.Result.Id;
            string formattedDateOfBirth = _patientApiResult.Result.DateOfBirth.ToString("yyyy-MM-dd");
            lblPatientIdValue.Text = _PatientId.ToString();

            lbPersonID.Text = _patientApiResult.Result.Id.ToString();
            lblName.Text = _patientApiResult.Result.PersonName.ToString();
            lblPhone.Text = _patientApiResult.Result.PhoneNumber.ToString();
            lblEmail.Text = _patientApiResult.Result.Email.ToString();
            lblDateOfBirth.Text = formattedDateOfBirth.ToString();
            lblAddress.Text = _patientApiResult.Result.Address.ToString();
            lblGender.Text = _patientApiResult.Result.Gender.ToString();
            
        }


        private void ctrlPersonCard_Load(object sender, EventArgs e)
        {

        }

        private void PnPersoncard_Enter(object sender, EventArgs e)
        {

        }
    }
}
