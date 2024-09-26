using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleClinic_View.MedicalRecords.Repositry;
using System.Net.Http.Json;
using SimpleClinic_View.Globals;
using System.Collections.Generic;
using SimpleClinic_View.MedicalRecords.Repositry.Repositories;
using SimpleClinic_View.MedicalRecords.Model;

namespace SimpleClinic_View.MedicalRecords.ctrMedicalRecords
{
    public partial class ctrShowMedicalRecordss: UserControl
    {
       
        private readonly HttpClient _httpClient;
        private readonly string _apiEndpoint;
        private ClientRepository<MedicalRecordsDTO> ClientRepository;
        private MedicalRecordsDTO? _medicalRecord { set; get; }

        public ctrShowMedicalRecordss()
        {
            InitializeComponent();
            ClientRepository = new ClientRepository<MedicalRecordsDTO>("MedicalRecords");
        }
        private void _RestMedicalRecordToDefult()
        {
            lblMedicalRecordID.Text = "[????]";
            lblVistiteDescribation.Text = "[????]";
            lblDiagnosis.Text = "[????]";
            lblAdditionalNotes.Text = "[????]";

        }
      
        private void _FillMedicalRecordInfo()
        {
            lblMedicalRecordID.Text = _medicalRecord.MedicalRecordID.ToString();
            lblVistiteDescribation.Text =   _medicalRecord.VisitDescription;
            lblDiagnosis.Text =_medicalRecord.Diagnosis;
            lblAdditionalNotes.Text = _medicalRecord.AdditionalNotes;
        }

        
        public async Task LoadDataMedicalRecord(int MedicalRecordId)
        {
            _medicalRecord = await ClientRepository.GetByIdAsync(MedicalRecordId);
            if (_medicalRecord == null)
            {
                MessageBox.Show("The Medical Record Not exit", "Not Exit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _RestMedicalRecordToDefult();

            }
            else 
            { 
                _FillMedicalRecordInfo();
            }
        }
    }
}
