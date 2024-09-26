using SimpleClinic_View.Patients;
using System;
using System.Windows.Forms;

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

        // Method to refresh all patient data in the DataGridView
        private async void _RefreshAllPatientsData()
        {
            try
            {
                dgvListAllPatients.Rows.Clear(); // Clear previous data

                var peopleList = await _Patient.GetAllPatientsAsync();

                if (peopleList != null && peopleList.IsSuccess && peopleList.Result.Count > 0)
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
                    MessageBox.Show("No patients to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("The API server is unavailable. Please check if the server is running and try again.", "API Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while loading the data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmListAllPatients_Load(object sender, EventArgs e)
        {
            _RefreshAllPatientsData(); // Load all patient data when form is loaded
        }

        
        private void ShowDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvListAllPatients.CurrentRow != null)
            {
                try
                {
                    int patientId = (int)dgvListAllPatients.CurrentRow.Cells[0].Value;
                    Form frm = new frmShowPatientDetails(patientId);
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while trying to show the patient details. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No patient selected for viewing. Please select a patient from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Method to add a new patient
        private void btnAddNewpatient_Click(object sender, EventArgs e)
        {
            Form fr = new frmAddEditPatientinfo(-1); // Open the form for adding a new patient
            fr.ShowDialog();
            _RefreshAllPatientsData(); // Refresh the data after adding a new patient
        }

        // Method to edit the selected patient's information
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Guard clause: Exit early if no row is selected
            if (dgvListAllPatients.CurrentRow == null)
            {
                MessageBox.Show("No patient selected for editing. Please select a patient from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method early if no patient is selected
            }

            try
            {
                int patientId = (int)dgvListAllPatients.CurrentRow.Cells[0].Value;
                Form frm = new frmAddEditPatientinfo(patientId);
                frm.ShowDialog();
                _RefreshAllPatientsData(); // Refresh after editing the patient
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to edit the patient information. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to delete the selected patient
        private async void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Guard clause: Exit early if no row is selected
            if (dgvListAllPatients.CurrentRow == null)
            {
                MessageBox.Show("No patient selected for deletion. Please select a patient from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method early if no patient is selected
            }

            try
            {
                int patientId = (int)dgvListAllPatients.CurrentRow.Cells[0].Value;

                if (MessageBox.Show($"Are you sure you want to delete this patient [{patientId}]?", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    var isDeleted = await _Patient.DeletePatient(patientId);
                    if (isDeleted.IsSuccess)
                    {
                        MessageBox.Show("Patient deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshAllPatientsData(); // Refresh the data after deletion
                    }
                    else
                    {
                        MessageBox.Show("The patient could not be deleted. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Network error occurred while attempting to delete the patient. Please check your connection and try again.", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while attempting to delete the patient. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Menu item to add a new patient
        private void AddNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPatientinfo(-1); // Open the form for adding a new patient
            frm.ShowDialog();
            _RefreshAllPatientsData(); // Refresh after adding the patient
        }

        // Close the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

