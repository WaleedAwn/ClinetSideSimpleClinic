//using SimpleClinic_View.Patients;
//using SimpleClinic_View.Patients.DTOs;
//using SimpleClinic_View.Person.DTOs;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Xml.Linq;

//namespace SimpleClinic_View
//{
//    public partial class frmAddEditPatientinfo : Form
//    {
//        private readonly PatientFacade _patientFacade;

//        public enum enMode { AddNew = 0, Update = 1 };
//        private enMode _Mode;
//        int _PatientID = -1;
//        public frmAddEditPatientinfo(int PatientID)
//        {
//            _PatientID = PatientID;
//            _patientFacade = new PatientFacade();
//            InitializeComponent();

//            if (_PatientID == -1)
//                _Mode = enMode.AddNew;
//            else
//                _Mode = enMode.Update;
//        }

//        public async void _LoadData()
//        {

//        }



//        private void frmAddEditPatientinfo_Load(object sender, EventArgs e)
//        {
//            _LoadData();

//        }


//        private void btnSave_Click(object sender, EventArgs e)
//        {

//        }

//        private void btnClose_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }



//    }
//}
using SimpleClinic_View.Globals;
using SimpleClinic_View.Patients;
using SimpleClinic_View.Patients.DTOs;
using SimpleClinic_View.Person.DTOs;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SimpleClinic_View
{
    public partial class frmAddEditPatientinfo : Form
    {
        private readonly PatientFacade _patientFacade;
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        int _PatientID = -1;

        public frmAddEditPatientinfo(int PatientID)
        {
            _PatientID = PatientID;
            _patientFacade = new PatientFacade();
            InitializeComponent();

            
            _Mode = (_PatientID == -1) ? enMode.AddNew : enMode.Update;
        }

      
        public async void _LoadData()
        {
            if (_Mode == enMode.Update)
            {
                lblAddEditPatientTitel.Text = "Edit Patient Info";
                try
                {
                    var patientResult = await _patientFacade.GetPatientAsync(_PatientID);

                    if (patientResult.IsSuccess && patientResult.Result != null)
                    {
                        PopulateFields(patientResult.Result);
                    }
                    else
                    {
                        ShowError($"Error loading patient data: {patientResult.ErrorMessage}");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    ShowError($"Exception occurred: {ex.Message}");
                }
            }
        }

        private void PopulateFields(AllPatientInfoDTO patient)
        {
            lbPersonID.Text=patient.personId.ToString();
            lbPatientID.Text = patient.Id.ToString();

            tbName.Text = patient.PersonName;
            dtpDateOFBirth.Text = patient.DateOfBirth.ToString("yyyy-MM-dd");
            pbGender.Text = patient.Gender.ToString();
            tbPhoneNumber.Text = patient.PhoneNumber;
            tbEmail.Text = patient.Email;
            tbAdress.Text = patient.Address;
        }

        private bool ValidateForm(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrEmpty(tbName.Text))
                errorMessage = "Name is required.";

            DateTime dob;
            if (!DateTime.TryParse(dtpDateOFBirth.Text, out dob))
                errorMessage = "Invalid date of birth format.";

            if (string.IsNullOrEmpty(pbGender.Text))
                errorMessage = "Gender is required.";

            return string.IsNullOrEmpty(errorMessage);
        }


        string SetGender()
        {
            if (cbgender.SelectedIndex == 0)
             return "M";
            
            return "F";
           
        }
       
        private async void btnSave_Click(object sender, EventArgs e)
        {
           
            btnSave.Enabled = false;

            var personDto = new PersonsDTO();
             
            personDto.PersonName = tbName.Text;
            personDto.DateOfBirth = dtpDateOFBirth.Value;
            personDto.Gender = SetGender();
            personDto.PhoneNumber = tbPhoneNumber.Text;
            personDto.Email = tbEmail.Text;
            personDto.Address = tbAdress.Text;

            var patientDto = new PatientDTO();
            patientDto.PersonId = personDto.Id;
           
            try
            {
                ApiResult<AllPatientInfoDTO> result;
             


                if (_Mode == enMode.AddNew)
                {
                    result = await _patientFacade.CreatePatientAsync(personDto, patientDto);
                    _PatientID = result.Result.Id;
                
                }
                else if (_Mode == enMode.Update)
                {
                    personDto.Id = Convert.ToInt32(lbPersonID.Text);
                    result = await _patientFacade.UpdatePatientAsync(_PatientID, personDto, patientDto);
                  
                    MessageBox.Show($"{result.IsSuccess}");
                
                }

                else
                {
                    return;
                }

                
                if (result.IsSuccess)
                {
                    MessageBox.Show("Patient information saved successfully.");
                 
                    _Mode=enMode.Update;
                       
                    _LoadData();
                }
                else
                {
                    ShowError($"WAleed Error saving patient information: {result.ErrorMessage}");
                }
            }
            catch (Exception ex)
            {
                ShowError($"Exception occurred: {ex.Message}");
            }
            finally
            {
                
                btnSave.Enabled = true;
            }
        }

      
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

       
        private void frmAddEditPatientinfo_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
