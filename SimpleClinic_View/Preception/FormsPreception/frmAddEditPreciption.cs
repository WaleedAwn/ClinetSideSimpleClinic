using SimpleClinic_View.MedicalRecords.Model;
using SimpleClinic_View.Preception.Model;
using SimpleClinic_View.Preception.Repositry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic_View.Preception.FormsPreception
{
    public partial class frmAddEditPreciption : Form
    {
        private int _PerceptionID;
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private PerceptionRepository<PerceptionDTO> _perceptionRepository = new PerceptionRepository<PerceptionDTO>("Prescriptions/");

        public frmAddEditPreciption()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddEditPreciption(int PreceptionID)
        {
            InitializeComponent();
            _PerceptionID = PreceptionID;
            _Mode = enMode.Update;
        }
        private async void _LoadDatePerception()
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = "Add New Preception";
                lblTitle.Text = "Add Preception";
                return;
            }
            lblTitle.Text = "Update Preception";
            this.Text = "Update Preception";
            _Mode = enMode.Update;
            var perceptionDTO = await _perceptionRepository.GetByIdAsync(_PerceptionID);
            if (perceptionDTO == null)
            {
                MessageBox.Show("There is No Medical Record With ID" + _PerceptionID, "Medical Not Exist", MessageBoxButtons.OK);
                this.Close();
                return;
            }
            _SetDateFromObject(perceptionDTO);

        }
        private void _SetDateFromObject(PerceptionDTO Perception)
        {
            lblPreceptionID.Text = Perception.PrescriptionID.ToString();
            lblMedicalRecordID.Text = Perception.MedicalRecordID.ToString();
            txtMedicalName.Text = Perception.MedicationName;
            txtFrequency.Text = Perception.Frequency;
            txtDosage.Text = Perception.Dosage;
            dtpStartDate.Text = Perception.StartDate.ToShortDateString();
            dtpEneDate.Text = Perception.EndDate.ToShortDateString();
            txtSpecialInstructions.Text = Perception.SpecialInstructions ?? null;
        }

        private void _SetDateFromForm(PerceptionDTO Perception)
        {
            Perception.PrescriptionID = _PerceptionID;
            Perception.MedicalRecordID = int.Parse(Perception.MedicalRecordID.ToString());
            Perception.MedicationName = txtMedicalName.Text;
            Perception.Dosage = txtDosage.Text;
            Perception.Frequency = txtFrequency.Text;
            Perception.SpecialInstructions = txtSpecialInstructions.Text ?? null;
            Perception.StartDate = dtpStartDate.Value;
            Perception.EndDate = dtpEneDate.Value;

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                var newRecord = new PerceptionDTO(0,int.Parse(lblMedicalRecordID.Text),txtMedicalName.Text,txtMedicalName.
                    Text,txtMedicalName.Text,dtpStartDate.Value,dtpEneDate.Value,txtSpecialInstructions.Text);


                int result = await _perceptionRepository.AddAsync(newRecord);
                if (result != -1)
                {
                    _PerceptionID = result;
                    lblPreceptionID.Text = result.ToString();
                    MessageBox.Show("Preception added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add Preception.");
                }
            }
            if (_Mode == enMode.Update)
            {
                var MedicalRecord = await _perceptionRepository.GetByIdAsync(_PerceptionID);
                if (MedicalRecord != null)
                {
                    _SetDateFromForm(MedicalRecord);
                    if (await _perceptionRepository.UpdateAsync(_PerceptionID, MedicalRecord))
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
    }
}
