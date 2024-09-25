using SimpleClinic_View.Patients;

namespace SimpleClinic_View
{
    public partial class frmListAllPatients : Form
    {
        private readonly PatientApiClient _Patient;
        public frmListAllPatients()
        {
            _Patient = new PatientApiClient();
            InitializeComponent();
        }



        private async void _RefreshAllPatientsData()
        {
            dgvListAllPatients.Rows.Clear();

            var peopleList = await _Patient.GetAllPatientsAsync();

            if (peopleList != null && peopleList.Result.Count > 0)
            {
                foreach (var person in peopleList.Result)
                {
                    string formattedDateOfBirth = person.DateOfBirth.ToString("yyyy-MM-dd");
                    dgvListAllPatients.Rows.Add(person.Id, person.PersonName, person.PhoneNumber,
                    person.Email, formattedDateOfBirth, person.Gender, person.Address, person.personId);
                }
                lblCounter.Text = peopleList.Result.Count.ToString();
            }
            else
            {
                MessageBox.Show("No people to display.", "Information", MessageBoxButtons.OK);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListAllPatients_Load(object sender, EventArgs e)
        {
            _RefreshAllPatientsData();
        }

        private void ShowDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowPatientDetails((int)dgvListAllPatients.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void btnAddNewpatient_Click(object sender, EventArgs e)
        {
            Form fr = new frmAddEditPatientinfo(-1);
            fr.ShowDialog();
            _RefreshAllPatientsData();

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPatientinfo((int)dgvListAllPatients.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshAllPatientsData();
        }

        private async void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int PatientID = (int)dgvListAllPatients.CurrentRow.Cells[0].Value;
            //  int PersonID = (int)dgvListAllPatients.CurrentRow.Cells[7].Value; 
            // i Will USe this Way To Avoid Create Object With all Patient Date 


            if (MessageBox.Show("Are you sure you want to delete this Patient [" + PatientID + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var Isdeleted = await PatientFacade.DeletePatient(PatientID);
                if (Isdeleted.IsSuccess)
                {
                    MessageBox.Show("Patient  deleted Successfully.");
                    _RefreshAllPatientsData();
                }
                else
                {
                    MessageBox.Show("Patient is not  Deleted.");

                }


            }

        }

        private void AddNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPatientinfo(-1);
            frm.ShowDialog();
            _RefreshAllPatientsData();
        }
    }
}
