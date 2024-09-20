using SimpleClinic_View.Doctors.DTOs;
using SimpleClinic_View.Globals;
using SimpleClinic_View.Patients;
using SimpleClinic_View.Patients.DTOs;
using SimpleClinic_View.Person.DTOs;
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
    public partial class frmAddEditDoctorinfo : Form
    {

        private readonly DoctorFacade _doctorFacade;
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        int _doctorID = -1;

        public frmAddEditDoctorinfo(int PatientID)
        {
            _doctorID = PatientID;
            _doctorFacade = new DoctorFacade();
            InitializeComponent();


            _Mode = (_doctorID == -1) ? enMode.AddNew : enMode.Update;
        }


        public async void _LoadData()
        {
            if (_Mode == enMode.Update)
            {
                lblAddEditPatientTitel.Text = "Edit Doctor Info";
                try
                {
                    var doctorResult = await _doctorFacade.GetDoctorByIdAsync(_doctorID);

                    if (doctorResult.IsSuccess && doctorResult.Result != null)
                    {
                        FillAllFields(doctorResult.Result);
                    }
                    else
                    {
                        ShowError($"Error loading Doctors data: {doctorResult.ErrorMessage}");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    ShowError($"Exception occurred: {ex.Message}");
                }
            }
        }

        private void FillAllFields(AllDoctorsInfoDTO Doctor)
        {
            lbPersonID.Text = Doctor.PersonId.ToString();
            lbDoctorID.Text = Doctor.Id.ToString();

            tbName.Text = Doctor.PersonName;
            dtpDateOFBirth.Text = Doctor.DateOfBirth.ToString("yyyy-MM-dd");
            pbGender.Text = Doctor.Gender.ToString();
            tbPhoneNumber.Text = Doctor.PhoneNumber;
            tbEmail.Text = Doctor.Email;
            tbAdress.Text = Doctor.Address;
            txbSpecialization.Text = Doctor.Specialization;
        }

        //private bool ValidateForm(out string errorMessage)
        //{
        //    errorMessage = string.Empty;

        //    if (string.IsNullOrEmpty(tbName.Text))
        //        errorMessage = "Name is required.";

        //    DateTime dob;
        //    if (!DateTime.TryParse(dtpDateOFBirth.Text, out dob))
        //        errorMessage = "Invalid date of birth format.";

        //    if (string.IsNullOrEmpty(pbGender.Text))
        //        errorMessage = "Gender is required.";

        //    return string.IsNullOrEmpty(errorMessage);
        //}


        string SetGender()
        {
            if (cbgender.SelectedIndex == 0)
                return "M";

            return "F";

        }

       


        


        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmAddEditDoctorinfo_Load(object sender, EventArgs e)
        {
            _LoadData();
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

            var doctorDto = new DoctorsDTO();
            doctorDto.PersonId = personDto.Id;
            doctorDto.Specialization=txbSpecialization.Text.ToString();

            try
            {
                ApiResult<AllDoctorsInfoDTO> result;



                if (_Mode == enMode.AddNew)
                {
                    result = await _doctorFacade.CreateDoctorWithPersonAsync(personDto, doctorDto);
                    _doctorID = result.Result.Id;

                }
                else if (_Mode == enMode.Update)
                {
                    personDto.Id = Convert.ToInt32(lbPersonID.Text);
                    result = await _doctorFacade.UpdateDoctorWithPersonAsync(_doctorID, personDto, doctorDto);

                    MessageBox.Show($"{result.IsSuccess}");

                }

                else
                {
                    return;
                }


                if (result.IsSuccess)
                {
                    MessageBox.Show("Doctor information saved successfully.");

                    _Mode = enMode.Update;

                    _LoadData();
                }
                else
                {
                    ShowError($"Waleed Error saving Doctor information: {result.ErrorMessage}");
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
    }
}
