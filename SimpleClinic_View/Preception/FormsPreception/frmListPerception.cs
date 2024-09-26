using SimpleClinic_View.MedicalRecords.Repositry.Repositories;
using SimpleClinic_View.Preception.Model;
using System.Windows.Forms;

namespace SimpleClinic_View.Preception.FormsPreception
{
    public partial class frmListPerception : Form
    {
        private ClientRepository<PerceptionDTO> _clientRepository;

        public frmListPerception()
        {
            InitializeComponent();
            _clientRepository = new ClientRepository<PerceptionDTO>("Prescriptions");
        }

        private async void frmListPerception_Load(object sender, EventArgs e)
        {
            await _LoadPreceptionAsync();
        }
        private async Task _LoadPreceptionAsync()
        {
            var Precepation = await _clientRepository.GetAllAsync();
            if (Precepation != null)
            {
                dgvPreception.DataSource = Precepation;
                lblRowCount.Text = dgvPreception.Rows.Count.ToString();
            }
            else
                MessageBox.Show("There is Any Precepation", "No Precepation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPreceptionInfo_Click(object sender, EventArgs e)
        {
            frmShowPreception frm = new frmShowPreception((int)dgvPreception.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private async void AddNewPreception_Click(object sender, EventArgs e)
        {
            frmAddEditPreciption frm = new frmAddEditPreciption();
            frm.ShowDialog();
            await _LoadPreceptionAsync();
        }

        private async void EditPreception_Click(object sender, EventArgs e)
        {
            frmAddEditPreciption frm = new frmAddEditPreciption((int)dgvPreception.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            await _LoadPreceptionAsync();
        }

        private async void DeletePreception_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want Delete this Medical Record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int RowNumber = (int)dgvPreception.CurrentRow.Cells[0].Value;
                if (await _clientRepository.DeleteAsync(RowNumber))
                {
                    MessageBox.Show($"The Medical Record With ID {RowNumber} Deleted SuccessFully :-)", "Deleted Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await _LoadPreceptionAsync();

                }
                else
                {
                    MessageBox.Show("Error! Failed To Delete MedicalRecord :-(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
