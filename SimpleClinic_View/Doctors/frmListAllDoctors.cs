//using SimpleClinic_View.Patients;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace SimpleClinic_View.Doctors
//{
//    public partial class frmListAllDoctors : Form
//    {
//        private readonly DoctorApiClient _Doctor;
//        public frmListAllDoctors()
//        {
//            _Doctor = new DoctorApiClient();
//            InitializeComponent();
//        }



//        private async void _RefreshAllDoctorsData()
//        {
//            dgvListAllDoctors.Rows.Clear();

//            var DoctorList = await _Doctor.GetAllDoctorsAsync();

//            if (DoctorList != null && DoctorList.Result.Count > 0)
//            {
//                foreach (var doctor in DoctorList.Result)
//                {
//                    string formattedDateOfBirth = doctor.DateOfBirth.ToString("yyyy-MM-dd");
//                    dgvListAllDoctors.Rows.Add(doctor.Id, doctor.Specialization, doctor.PersonName, doctor.PhoneNumber,
//                    doctor.Email, formattedDateOfBirth, doctor.Gender, doctor.Address, doctor.PersonId);
//                }
//                lblCounter.Text = DoctorList.Result.Count.ToString();
//            }
//            else
//            {
//                MessageBox.Show("No Doctors to display.", "Information", MessageBoxButtons.OK);
//            }

//        }

//        private void frmListAllDoctors_Load(object sender, EventArgs e)
//        {
//            _RefreshAllDoctorsData();
//        }

//        private void ShowDetailesToolStripMenuItem_Click(object sender, EventArgs e)
//        {

//            Form form = new frmShowDoctorDetails((int)dgvListAllDoctors.CurrentRow.Cells[0].Value);
//            form.ShowDialog();
//            _RefreshAllDoctorsData();
//        }

//        private void AddNewToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            Form form = new frmShowDoctorDetails(-1);
//            form.ShowDialog();
//            _RefreshAllDoctorsData();

//        }

//        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            Form form = new frmAddEditDoctorinfo((int)dgvListAllDoctors.CurrentRow.Cells[0].Value);
//            form.ShowDialog();
//            _RefreshAllDoctorsData();

//        }



//        private void btnAddNewDoctor_Click(object sender, EventArgs e)
//        {
//            Form frm = new frmAddEditDoctorinfo(-1);
//            frm.ShowDialog();
//            _RefreshAllDoctorsData();

//        }
//        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
//        {


//            _RefreshAllDoctorsData();

//        }

//        private void btnClose_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }
//    }
//}

using Polly.CircuitBreaker;
using SimpleClinic_View.Patients;
using System;
using System.Windows.Forms;

namespace SimpleClinic_View.Doctors
{
    public partial class frmListAllDoctors : Form
    {
        private readonly DoctorApiClient _Doctor;

        public frmListAllDoctors()
        {
            _Doctor = new DoctorApiClient();
            InitializeComponent();
        }

        // Method to refresh all doctor data
        private async void _RefreshAllDoctorsData()
        {
            try
            {
                dgvListAllDoctors.Rows.Clear(); // Clear the previous data

                var doctorList = await _Doctor.GetAllDoctorsAsync();

                if (doctorList != null && doctorList.IsSuccess && doctorList.Result.Count > 0)
                {
                    foreach (var doctor in doctorList.Result)
                    {
                        string formattedDateOfBirth = doctor.DateOfBirth.ToString("yyyy-MM-dd");
                        dgvListAllDoctors.Rows.Add(doctor.Id, doctor.Specialization, doctor.PersonName, doctor.PhoneNumber,
                            doctor.Email, formattedDateOfBirth, doctor.Gender, doctor.Address, doctor.PersonId);
                    }
                    lblCounter.Text = doctorList.Result.Count.ToString(); // Update counter
                }
                else
                {
                    MessageBox.Show("No doctors to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (BrokenCircuitException ex)
            {
                // This will be executed if Polly's circuit breaker is open due to repeated failures.
                MessageBox.Show($"The API is temporarily unavailable due to repeated failures: {ex.Message}", "Service Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (HttpRequestException ex)
            {
                // This will be executed if a network-related error occurs.
                MessageBox.Show($"Network error: {ex.Message}", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while loading the data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmListAllDoctors_Load(object sender, EventArgs e)
        {
            _RefreshAllDoctorsData(); // Load doctor data when form is loaded
        }

        // Method to show doctor details
        private void ShowDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvListAllDoctors.CurrentRow == null)
            {
                MessageBox.Show("No doctor selected for viewing. Please select a doctor from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit if no doctor is selected
            }

            try
            {
                int doctorId = (int)dgvListAllDoctors.CurrentRow.Cells[0].Value;
                Form form = new frmShowDoctorDetails(doctorId);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to show the doctor details. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _RefreshAllDoctorsData(); // Refresh data after viewing details
        }

        // Method to add a new doctor
        private void btnAddNewDoctor_Click(object sender, EventArgs e)
        {
            Form form = new frmAddEditDoctorinfo(-1); // Open the form for adding a new doctor
            form.ShowDialog();
            _RefreshAllDoctorsData(); // Refresh the data after adding a doctor
        }

        // Method to edit the selected doctor
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvListAllDoctors.CurrentRow == null)
            {
                MessageBox.Show("No doctor selected for editing. Please select a doctor from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit if no doctor is selected
            }

            try
            {
                int doctorId = (int)dgvListAllDoctors.CurrentRow.Cells[0].Value;
                Form form = new frmAddEditDoctorinfo(doctorId); // Open the edit form
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to edit the doctor information. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _RefreshAllDoctorsData(); // Refresh data after editing
        }

        // Method to delete the selected doctor
        private async void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvListAllDoctors.CurrentRow == null)
            {
                MessageBox.Show("No doctor selected for deletion. Please select a doctor from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit if no doctor is selected
            }

            try
            {
                int doctorId = (int)dgvListAllDoctors.CurrentRow.Cells[0].Value;

                if (MessageBox.Show($"Are you sure you want to delete this doctor [{doctorId}]?", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    var isDeleted = await _Doctor.DeleteDoctor(doctorId);

                    if (isDeleted.IsSuccess)
                    {
                        MessageBox.Show("Doctor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The doctor could not be deleted. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    _RefreshAllDoctorsData(); // Refresh after deletion
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Network error occurred while attempting to delete the doctor. Please check your connection and try again.", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while attempting to delete the doctor. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Menu option to add a new doctor
        private void AddNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmAddEditDoctorinfo(-1); // Open the form for adding a new doctor
            form.ShowDialog();
            _RefreshAllDoctorsData(); // Refresh the data after adding a new doctor
        }

        // Close the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

