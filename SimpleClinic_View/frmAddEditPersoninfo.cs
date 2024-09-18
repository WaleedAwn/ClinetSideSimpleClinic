using SimpleClinic_View.ApiClients;
using SimpleClinic_View.DTOs;
using SimpleClinic_View.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic_View
{
    public partial class frmAddEditPersoninfo : Form
    {
        private PersonService _personService;
        private PersonsDTO _personDto;
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        int _PersonID = -1;
        public frmAddEditPersoninfo(int PersonID)
        {
            InitializeComponent();
            _personService = new PersonService();
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
                _personDto = new PersonsDTO();
                return;
            }
            _Mode = enMode.Update;
            _personDto = await _personService.Find(_PersonID);

            if (_personDto == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _PersonID);

                this.Close();
                return;
            }
            string formattedDateOfBirth = _personDto.DateOfBirth.ToString("yyyy-MM-dd");
            lblAddEditPersonTitel.Text = "Edit Person Info ";

            lbPersonID.Text = _personDto.Id.ToString();
            tbName.Text = _personDto.PersonName.ToString();
            tbPhoneNumber.Text = _personDto.PhoneNumber.ToString();
            tbEmail.Text = _personDto.Email.ToString();
            tbAdress.Text = _personDto.Address.ToString();
            dtpDateOFBirth.Text = formattedDateOfBirth.ToString();
            cbgender.Text = _personDto.Gender.ToString();

        }
       
        
        private void frmAddEditPersoninfo_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            int newPersonID = 0;
            _personDto.PersonName=tbName.Text;
            _personDto.PhoneNumber=tbPhoneNumber.Text;
            _personDto.Email=tbEmail.Text;
            if (cbgender.SelectedIndex == 0)
            {
                _personDto.Gender = "Male";

            }
            else {
                _personDto.Gender = "Female";

            }
            _personDto.Address=tbAdress.Text;
            _personDto.DateOfBirth = dtpDateOFBirth.Value;

            //if (PersonDataValidation.ValidateAllPersonInfo(_personDto))
            //{

                if (_Mode == enMode.AddNew)
                {
                    if (!await _personService.ISPersonExist(_personDto.Id))
                    {
                        newPersonID = await _personService.AddNewPerson(_personDto);
                        if (newPersonID!= -1)
                        {
                            

                            MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK);
                            MessageBox.Show($"New Person ID {newPersonID}  ","Saved", MessageBoxButtons.OK);


                        }
                        else
                            MessageBox.Show("Error: Person is Not  Saved ", "Error", MessageBoxButtons.OK);
                    }
                    else { 
                    
                            MessageBox.Show("Error: this Person is found before Insert New One ", "Error", MessageBoxButtons.OK);

                    }

                }

                if (_Mode == enMode.Update)
                {
                    _personDto.Id = _PersonID;
                    if (await _personService.UpdatePerson(_personDto.Id, _personDto))
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
