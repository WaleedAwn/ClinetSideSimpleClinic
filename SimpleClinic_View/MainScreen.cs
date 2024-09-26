//using Polly.CircuitBreaker;
//using SimpleClinic_View.Appointments;
//using SimpleClinic_View.Doctors;
//using SimpleClinic_View.Patients;
//using SimpleClinic_View.Users;
//using System;
//using System.Windows.Forms;


//namespace SimpleClinic_View
//{
//    public partial class MainScreen : Form
//    {
//        private readonly PatientApiClient patientApiClient;
//        private readonly DoctorApiClient _doctorApiClient;
//        private readonly AppointmentService _appointmentService;
//        public MainScreen()
//        {
//            patientApiClient = new PatientApiClient();
//            _doctorApiClient = new DoctorApiClient();
//            _appointmentService = new AppointmentService();
//            InitializeComponent();
//        }

//        // Method to load data for patients and doctors
//        private async void _LoadData()
//        {
//            try
//            {
//                // Load patient count
//                var numberOfPatients = await patientApiClient.GetPatientsNumber();

//                if (numberOfPatients.IsSuccess && numberOfPatients.Result != -1)
//                {
//                    lbTotalPatient.Text = numberOfPatients.Result.ToString();
//                }
//                else
//                {
//                    lbTotalPatient.Text = "No patients";
//                }
//            }
//            catch (BrokenCircuitException e)  // Immediately catch circuit breaker exception
//            {
//                // Show error immediately if circuit breaker is open
//                MessageBox.Show("The API server is temporarily unavailable due to repeated failures. Please try again later.", "Service Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);


//            }
//            catch (HttpRequestException)
//            {
//                MessageBox.Show("The API server is unavailable. Please check if the server is running and try again.", "API Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            catch (Exception ex)
//            {

//                MessageBox.Show("An unexpected error occurred while loading patient data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }

//            try
//            {
//                // Load doctor count
//                var numberOfDoctors = await _doctorApiClient.GetDoctorsNumber();

//                if (numberOfDoctors.IsSuccess && numberOfDoctors.Result != -1)
//                {
//                    lbTotalDoctors.Text = numberOfDoctors.Result.ToString();
//                }
//                else
//                {
//                    lbTotalDoctors.Text = "No doctors";

//                }
//            }
//            catch (HttpRequestException)
//            {
//                MessageBox.Show("The API server is unavailable. Please check if the server is running and try again.", "API Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("An unexpected error occurred while loading doctor data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }

//            try
//            {
//                // Load doctor count
//                var numberOfAppointments = await _appointmentService.GetAppointmentsNumber();

//                if (numberOfAppointments.IsSuccess && numberOfAppointments.Result != -1)
//                {
//                    lbTotalAppointment.Text = numberOfAppointments.Result.ToString();
//                }
//                else
//                {
//                    lbTotalDoctors.Text = "No Appointments";

//                }
//            }
//            catch (HttpRequestException)
//            {
//                MessageBox.Show("The API server is unavailable. Please check if the server is running and try again.", "API Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("An unexpected error occurred while loading doctor data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }



//        }

//        private void MainScreen_Load(object sender, EventArgs e)
//        {
//            _LoadData(); // Load data for patients and doctors when form is loaded
//        }

//        // Open Person management screen
//        private void btnPerson_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                Form frm = new frmListAllPeople();
//                frm.ShowDialog();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("An error occurred while opening the Person screen. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        // Open Patient management screen
//        private void btn_Patients_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                Form frm = new frmListAllPatients();
//                frm.ShowDialog();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("An error occurred while opening the Patients screen. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        // Open Doctor management screen
//        private void btn_Doctors_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                Form frm = new frmListAllDoctors();
//                frm.ShowDialog();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("An error occurred while opening the Doctors screen. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        // Show appointments management message
//        private void btn_Appointments_Click(object sender, EventArgs e)
//        {
//            MessageBox.Show("All Appointments will be here.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }

//        // Open User management screen
//        private void btn_Users_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                Form frm = new frmManageUsers();
//                frm.ShowDialog();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("An error occurred while opening the Users screen. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }
//    }
//}



using Polly.CircuitBreaker;
using SimpleClinic_View.Appointments;
using SimpleClinic_View.Doctors;
using SimpleClinic_View.Globals;
using SimpleClinic_View.MedicalRecords.ListMedicalRecods;
using SimpleClinic_View.Patients;
using SimpleClinic_View.Users;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic_View
{
    public partial class MainScreen : Form
    {
        private readonly PatientApiClient _patientApiClient;
        private readonly DoctorApiClient _doctorApiClient;
        private readonly AppointmentService _appointmentService;

        public MainScreen()
        {
            _patientApiClient = new PatientApiClient();
            _doctorApiClient = new DoctorApiClient();
            _appointmentService = new AppointmentService();
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            _ = LoadDataAsync(); // Load data for patients, doctors, and appointments asynchronously
        }


        private async Task LoadDataAsync()
        {
            await LoadEntityData(
                async () => await _patientApiClient.GetPatientsNumber(),
                lbTotalPatient,
                "patients"
            );

            await LoadEntityData(
                async () => await _doctorApiClient.GetDoctorsNumber(),
                lbTotalDoctors,
                "doctors"
            );

            await LoadEntityData(
                async () => await _appointmentService.GetAppointmentsNumber(),
                lbTotalAppointment,
                "appointments"
            );
        }


        private async Task LoadEntityData(Func<Task<ApiResult<int>>> apiCall, Label label, string entityName)
        {
            try
            {
                var result = await apiCall();

                if (result.IsSuccess && result.Result != -1)
                {
                    label.Text = result.Result.ToString();
                }
                else
                {
                    label.Text = $"No {entityName}";
                }
            }
            catch (BrokenCircuitException)
            {
                ShowErrorMessage("The API server is temporarily unavailable due to repeated failures. Please try again later.", "Service Unavailable");
            }
            catch (HttpRequestException)
            {
                ShowErrorMessage("The API server is unavailable. Please check if the server is running and try again.", "API Server Error");
            }
            catch (Exception)
            {
                ShowErrorMessage($"An unexpected error occurred while loading {entityName} data. Please try again.", "Error");
            }
        }



        private void ShowErrorMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // UI Handling: Improved separation of concerns for form-related logic and data loading.

        #region UI Button Click Events

        // Opens the Person management screen
        private void btnPerson_Click(object sender, EventArgs e)
        {
            OpenFormSafely(new frmListAllPeople(), "Person screen");
        }

        // Opens the Patient management screen
        private void btn_Patients_Click(object sender, EventArgs e)
        {
            OpenFormSafely(new frmListAllPatients(), "Patients screen");
        }

        // Opens the Doctor management screen
        private void btn_Doctors_Click(object sender, EventArgs e)
        {
            OpenFormSafely(new frmListAllDoctors(), "Doctors screen");
        }

        // Shows the appointments management message
        private void btn_Appointments_Click(object sender, EventArgs e)
        {
            OpenFormSafely(new frmManageAppointments(), "Appointments Screen");
        }


        private void btn_MedicalRecord_Click(object sender, EventArgs e)
        {
            OpenFormSafely(new ListMedicalRecod(), "Medical Record screen");
        }
        // Opens the User management screen
        private void btn_Users_Click(object sender, EventArgs e)
        {
            OpenFormSafely(new frmManageUsers(), "Users screen");
        }

        private void btn_Preceptions_Click(object sender, EventArgs e)
        {
            //OpenFormSafely(new (), "Users screen");

        }

        #endregion


        private void OpenFormSafely(Form form, string formName)
        {
            try
            {
                form.ShowDialog();
            }
            catch (Exception)
            {
                ShowErrorMessage($"An error occurred while opening the {formName}. Please try again.", "Error");
            }
        }

       
    }
}
