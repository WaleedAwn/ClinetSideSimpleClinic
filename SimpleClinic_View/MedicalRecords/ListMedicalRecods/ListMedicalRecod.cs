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
using SimpleClinic_View.MedicalRecords.Model;
using SimpleClinic_View.MedicalRecords.Repositry.Repositories;
namespace SimpleClinic_View.MedicalRecords.ListMedicalRecods
{
    public partial class ListMedicalRecod : Form
    {
        private ClientRepository<MedicalRecordDTO> _clientRepository;
        public ListMedicalRecod()
        {
            InitializeComponent();
            _clientRepository = new ClientRepository<MedicalRecordDTO>("MedicalRecords");
        }
        private async Task LoadMedicalRecordsAsync()
        {
            var records = await _clientRepository.GetAllAsync();
            if (records != null)
                dataGridView1.DataSource = new BindingSource { DataSource = records };
            else
                MessageBox.Show("There is Any Medical Records", "No Medical Records", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private async void ListMedicalRecod_Load(object sender, EventArgs e)
        {
            await LoadMedicalRecordsAsync();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
