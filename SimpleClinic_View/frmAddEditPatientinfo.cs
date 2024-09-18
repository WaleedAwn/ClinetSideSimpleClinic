using SimpleClinic_View.ApiClients;
using SimpleClinic_View.DTOs;
using SimpleClinic_View.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic_View
{
    public partial class frmAddEditPatientinfo : Form
    {
        private PersonService _personService;
        private PatientApiClient _PatientApiClient;
        private AllPatientInfoDTO _AllPatientInfoDTO;
        private PersonsDTO _personDto;
        private  PatientDTO _patientDto;

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        int _PatientID = -1;
        public frmAddEditPatientinfo(int PatientID)
        {
            _PatientID = PatientID;
            _AllPatientInfoDTO = new AllPatientInfoDTO();
            _PatientApiClient= new PatientApiClient();
            _personService = new PersonService();
            InitializeComponent();

            if (_PatientID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        public async void _LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                lblAddEditPatientTitel.Text = "Add New Patient ";
                _personDto = new PersonsDTO();
                _patientDto=new PatientDTO();
                return;
            }
            _Mode = enMode.Update;
            _personDto=new PersonsDTO();
            _AllPatientInfoDTO = await _PatientApiClient.Find(_PatientID);

            _personDto = await _personService.Find(_AllPatientInfoDTO.personId);

            if (_personDto == null)
            {
                MessageBox.Show("This form will be closed because No Patient with ID = " + _PatientID);

                this.Close();
                return;
            }

            string formattedDateOfBirth = _personDto.DateOfBirth.ToString("yyyy-MM-dd");
            lblAddEditPatientTitel.Text = "Edit Patient Info ";

            lbPatientID.Text = _AllPatientInfoDTO.Id.ToString();

            tbName.Text = _personDto.PersonName.ToString();
            tbPhoneNumber.Text = _personDto.PhoneNumber.ToString();
            tbEmail.Text = _personDto.Email.ToString();
            tbAdress.Text = _personDto.Address.ToString();
            dtpDateOFBirth.Text = formattedDateOfBirth.ToString();
            cbgender.Text = _personDto.Gender.ToString();




        }


        private void frmAddEditPatientinfo_Load(object sender, EventArgs e)
        {
            _LoadData();

        }
    }
}
