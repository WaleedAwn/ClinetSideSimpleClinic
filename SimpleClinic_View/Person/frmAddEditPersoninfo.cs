using SimpleClinic_View.Globals;
using SimpleClinic_View.Person;
using SimpleClinic_View.Person.DTOs;

namespace SimpleClinic_View
{
    public partial class frmAddEditPersoninfo : Form
    {
        private PersonApiClient _personService;
        private ApiResult<PersonsDTO> _personDto;
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        int _PersonID = -1;
        public frmAddEditPersoninfo(int PersonID)
        {
            InitializeComponent();
            _personService = new PersonApiClient();
            _PersonID = PersonID;
            if (_PersonID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }



        public async void _LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                lblAddEditPersonTitel.Text = "Add New Person ";
                _personDto = new ApiResult<PersonsDTO>();
                //_personDto.Result = new PersonsDTO();

                return;
            }
            _Mode = enMode.Update;
            _personDto = await _personService.Find(_PersonID);

            if (_personDto.Result == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _PersonID);

                this.Close();
                return;
            }
            string formattedDateOfBirth = _personDto.Result.DateOfBirth.ToString("yyyy-MM-dd");
            lblAddEditPersonTitel.Text = "Edit Person Info ";

            lbPersonID.Text = _personDto.Result.Id.ToString();
            tbName.Text   = _personDto.Result.PersonName.ToString();
            tbPhoneNumber.Text = _personDto.Result.PhoneNumber.ToString();
            tbEmail.Text   = _personDto.Result.Email.ToString();
            tbAdress.Text = _personDto.Result.Address.ToString();
            dtpDateOFBirth.Text = formattedDateOfBirth.ToString();
            cbgender.Text     = _personDto.Result.Gender.ToString();

        }


        private void frmAddEditPersoninfo_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private PersonsDTO SetPersonData()
        {
            PersonsDTO person = new PersonsDTO();
            person.PersonName = tbName.Text;
            person.PhoneNumber = tbPhoneNumber.Text;
            person.Email = tbEmail.Text;

            if (cbgender.SelectedIndex == 0)
            {
                person.Gender = "M";

            }
            else
            {
                person.Gender = "F";

            }
          
            
            person.Address = tbAdress.Text;
            person.DateOfBirth = dtpDateOFBirth.Value;

            return person;


        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            _personDto.Result = SetPersonData();

            //if (Validation.ValidateAllPersonInfo(_personDto.Result))
            //{
            MessageBox.Show($"{_personDto.Result.PersonName}");


            if (_Mode == enMode.AddNew)
            {
                //  var isExist = await _personService.ISPersonExist(_personDto.Result.Id);


                //if (isExist.IsSuccess)
                //{
                var NewPersonInfo = await _personService.AddNewPerson(_personDto.Result);
                if (NewPersonInfo.IsSuccess)
                {
                    MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK);
                    MessageBox.Show($"New Person ID {NewPersonInfo.Result.Id}  ", "Saved", MessageBoxButtons.OK);

                }
                else
                    MessageBox.Show("Error: Person is Not  Saved ", "Error", MessageBoxButtons.OK);
                //}
                //else { 

                //        MessageBox.Show("Error: this Person is found before Insert New One ", "Error", MessageBoxButtons.OK);

                //}

            }

            else if (_Mode == enMode.Update)
            {
                _personDto.Result.Id = _PersonID;
                var isUpdated = await _personService.UpdatePersonInfo(_personDto.Result.Id, _personDto.Result);

                if (isUpdated.IsSuccess)
                {
                    MessageBox.Show("Data Updated Successfully", "Saved", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Error: Person is Not  Updated ", "Error", MessageBoxButtons.OK);

            }


            //}

            //else
            //{
            //    MessageBox.Show("Ensure that Data Are Correct");
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
