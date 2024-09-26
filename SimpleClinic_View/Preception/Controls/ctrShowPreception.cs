using SimpleClinic_View.MedicalRecords.Repositry.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleClinic_View.HttpConection;
using SimpleClinic_View.Preception.Model;
using SimpleClinic_View.Preception.Repositry;

namespace SimpleClinic_View.Preception.Controls
{
    public partial class ctrShowPreception : UserControl
    {

        private readonly HttpClient _httpClient;
        private readonly string _apiEndpoint;
        private PerceptionRepository<PerceptionDTO> _PerceptionRepository;
        private PerceptionDTO? _PerceptionDTO;
        public ctrShowPreception()
        {
            InitializeComponent();
            _PerceptionRepository = new PerceptionRepository<PerceptionDTO>("Prescriptions/");
        }
        private void _RestPreceptionToDefult()
        {
            lblPreceptionID.Text    = "[????]";
            lblMedicalRecordID.Text = "[????]";
            lblMedicalName.Text     = "[????]";
            lblDosage.Text          = "[????]"; 
            lblFrequency.Text       = "[????]";
            lblStartDate.Text       = "[????]";
            lblEndDate.Text         = "[????]";
            lblSpecialInstructions.Text = "[????]";

        }

        private void _FillPerecptionInfo()
        {
            lblPreceptionID.Text = _PerceptionDTO.PrescriptionID.ToString();
            lblMedicalRecordID.Text = _PerceptionDTO.MedicalRecordID.ToString() ?? null;
            lblMedicalName.Text = _PerceptionDTO.MedicationName;
            lblDosage.Text = _PerceptionDTO.Dosage;
            lblFrequency.Text= _PerceptionDTO.Frequency;
            lblStartDate.Text=_PerceptionDTO.StartDate.ToShortDateString();
            lblEndDate.Text = _PerceptionDTO.EndDate.ToShortDateString();
            lblSpecialInstructions.Text = _PerceptionDTO.SpecialInstructions??"Null";
        }


        public async Task LoadDataPreception(int PreceptionID)
        {
            _PerceptionDTO = await _PerceptionRepository.GetByIdAsync(PreceptionID);
            if (_PerceptionDTO == null)
            {
                MessageBox.Show("The Preception Not exit", "Not Exit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _RestPreceptionToDefult();

            }
            else
            {
                _FillPerecptionInfo();
            }
        }

    }
}
