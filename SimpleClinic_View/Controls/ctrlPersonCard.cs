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
using SimpleClinic_View.Person;
using SimpleClinic_View.Person.DTOs;
using SimpleClinic_View.Users.DTOs;


namespace SimpleClinic_View.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        private ApiResult<PersonsDTO> _apiResult;
        private int _PersonId = -1;

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

        }
        public async void _LoadPersonData(int _PersonID)
        {
            MessageBox.Show($"{_PersonID}");
             _apiResult = await PersonApiClient.StatFind(_PersonID);

            if (!_apiResult.IsSuccess)
            {
                MessageBox.Show(_apiResult.ErrorMessage, nameof(_apiResult.Status), MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetDeffultValues();
                return;
            }
            else
                _FillPersonInfo();


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

        }

        private void _FillPersonInfo()
        {
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

        private void ctrlPersonCard_Load(object sender, EventArgs e)
        {

        }

        private void PnPersoncard_Enter(object sender, EventArgs e)
        {

        }
    }
}
