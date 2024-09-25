using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleClinic_View.MedicalRecords.Model;
using SimpleClinic_View.MedicalRecords.Repositry.Repositories;


namespace SimpleClinic_View.MedicalRecords.FormsMedicalRecods
{
    public partial class frmAddNewMedicalRecords : Form
    {
        private ClientRepository<MedicalRecordsDTO> _medicalRepository;
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        int _MedicalRecordID = -1;
        public frmAddNewMedicalRecords()
        {
            InitializeComponent();
            _medicalRepository = new ClientRepository<MedicalRecordsDTO>("MedicalRecords");
            _Mode = enMode.AddNew;
        }
        public frmAddNewMedicalRecords(int MedicalRecordID)
        {
            InitializeComponent();
            _medicalRepository = new ClientRepository<MedicalRecordsDTO>("MedicalRecords");
            _MedicalRecordID = MedicalRecordID;
            _Mode = enMode.Update;
        }

        private async void _LoadDateMedicalRecord()
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = "Add New MedicalRecord";
                lblTitle.Text = "Add New MedicalRecord";
                return;
            }
            lblTitle.Text = "Update New MedicalRecord";
            this.Text = "Update New MedicalRecord";
            _Mode = enMode.Update;
            var MedicalRecord = await _medicalRepository.GetByIdAsync(_MedicalRecordID);
            if (MedicalRecord == null)
            {
                MessageBox.Show("There is No Medical Record With ID" + _MedicalRecordID, "Medical Not Exist", MessageBoxButtons.OK);
                this.Close();
                return;
            }
           _SetDateFromObject(MedicalRecord);

        }
        private void _SetDateFromObject(MedicalRecordsDTO MedicalRecord)
        {
            lblMedicalRecordID.Text = MedicalRecord.MedicalRecordID.ToString();
            txtAdditionalNotes.Text = MedicalRecord.AdditionalNotes;
            txtDiagnosis.Text = MedicalRecord.Diagnosis;
            txtVisitDescription.Text = MedicalRecord.VisitDescription;
        }

        private void _SetDateFromForm(MedicalRecordsDTO MedicalRecord)
        {
            MedicalRecord.MedicalRecordID = _MedicalRecordID;
            MedicalRecord.AdditionalNotes = txtAdditionalNotes.Text ?? null;
            MedicalRecord.Diagnosis = txtDiagnosis.Text ?? null;
            MedicalRecord.VisitDescription = txtVisitDescription.Text ?? null;

        }
        private async void btnSave_Click(object sender, EventArgs e)
        {

            if (_Mode == enMode.AddNew)
            {
                var newRecord = new MedicalRecordsDTO(
                    0, // MedicalRecordID
                    txtVisitDescription.Text,
                    txtDiagnosis.Text,
                    txtAdditionalNotes.Text
                );


                int result = await _medicalRepository.AddAsync(newRecord);
                if (result != -1)
                {
                    _MedicalRecordID = result;
                    lblMedicalRecordID.Text = result.ToString();
                    MessageBox.Show("Record added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add record.");
                }
            }
            if (_Mode == enMode.Update)
            {
                var MedicalRecord = await _medicalRepository.GetByIdAsync(_MedicalRecordID);
                if (MedicalRecord != null)
                {
                    _SetDateFromForm(MedicalRecord);
                   if (await _medicalRepository.UpdateAsync(_MedicalRecordID, MedicalRecord))
                    {

                        MessageBox.Show("Data Updated SuccessFully :-)", "Success Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error! Data Not Updated  :-(", "Error Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddNewMedicalRecords_Load(object sender, EventArgs e)
        {
            _LoadDateMedicalRecord();
        }
    }
} 


