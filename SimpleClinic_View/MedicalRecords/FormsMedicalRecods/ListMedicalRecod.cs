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
using SimpleClinic_View.MedicalRecords.Repositry.Repositories;
using SimpleClinic_View.MedicalRecords.FormsMedicalRecods;
using SimpleClinic_View.MedicalRecords.Model;
namespace SimpleClinic_View.MedicalRecords.ListMedicalRecods
{
    public partial class ListMedicalRecod : Form
    {
        private ClientRepository<MedicalRecordsDTO> _clientRepository;
        public ListMedicalRecod()
        {
            InitializeComponent();
            _clientRepository = new ClientRepository<MedicalRecordsDTO>("MedicalRecords");
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

        private async void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void ShowDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowMedicalInfo frm = new frmShowMedicalInfo((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            
        }
        private async void muAddMedicalRecord_Click(object sender,EventArgs e) 
        {

            frmAddNewMedicalRecords frm = new frmAddNewMedicalRecords();
             frm.ShowDialog();
            await LoadMedicalRecordsAsync();
        }
        private async void EditMedicalRecord_Click(object sender, EventArgs e)
        {
            frmAddNewMedicalRecords frm = new frmAddNewMedicalRecords((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            await LoadMedicalRecordsAsync();

        }
        private async void DeleteMedicalRecord_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want Delete this Medical Record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int RowNumber = (int)dataGridView1.CurrentRow.Cells[0].Value;
              if ( await _clientRepository.DeleteAsync(RowNumber))
                {
                    MessageBox.Show($"The Medical Record With ID {RowNumber} Deleted SuccessFully :-)", "Deleted Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   await LoadMedicalRecordsAsync();
                }
                else
                {
                    MessageBox.Show("Error! Failed To Delete MedicalRecord :-(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private async void pbAddNewMedicalRecord_Click(object sender,EventArgs e)
        {
            frmAddNewMedicalRecords frm = new frmAddNewMedicalRecords();
            frm.ShowDialog();
            await LoadMedicalRecordsAsync();
        }
    }
}
