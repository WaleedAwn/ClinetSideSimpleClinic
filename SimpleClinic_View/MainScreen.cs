using Polly.CircuitBreaker;
using SimpleClinic_View.Doctors;
using SimpleClinic_View.Patients;
using SimpleClinic_View.Users;
using System;
using System.Windows.Forms;


namespace SimpleClinic_View
{
    public partial class MainScreen : Form
    {
        private readonly PatientApiClient patientApiClient;
        private readonly DoctorApiClient _doctorApiClient;

        public MainScreen()
        {
            patientApiClient = new PatientApiClient();
            _doctorApiClient = new DoctorApiClient();
            InitializeComponent();
        }

        // Method to load data for patients and doctors
        private async void _LoadData()
        {
            try
            {
                // Load patient count
                var numberOfPatients = await patientApiClient.GetPatientsNumber();

                if (numberOfPatients.IsSuccess && numberOfPatients.Result != -1)
                {
                    lbTotalPatient.Text = numberOfPatients.Result.ToString();
                }
                else
                {
                    lbTotalPatient.Text = "No patients";
                }
            }
            catch (BrokenCircuitException e)  // Immediately catch circuit breaker exception
            {
                // Show error immediately if circuit breaker is open
                MessageBox.Show("The API server is temporarily unavailable due to repeated failures. Please try again later.", "Service Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
            
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("The API server is unavailable. Please check if the server is running and try again.", "API Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show("An unexpected error occurred while loading patient data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                // Load doctor count
                var numberOfDoctors = await _doctorApiClient.GetDoctorsNumber();

                if (numberOfDoctors.IsSuccess && numberOfDoctors.Result != -1)
                {
                    lbTotalDoctors.Text = numberOfDoctors.Result.ToString();
                }
                else
                {
                    lbTotalDoctors.Text = "No doctors";
                    
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("The API server is unavailable. Please check if the server is running and try again.", "API Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while loading doctor data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            _LoadData(); // Load data for patients and doctors when form is loaded
        }

        // Open Person management screen
        private void btnPerson_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = new frmListAllPeople();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the Person screen. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Open Patient management screen
        private void btn_Patients_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = new frmListAllPatients();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the Patients screen. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Open Doctor management screen
        private void btn_Doctors_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = new frmListAllDoctors();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the Doctors screen. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Show appointments management message
        private void btn_Appointments_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Appointments will be here.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Open User management screen
        private void btn_Users_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = new frmManageUsers();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the Users screen. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

