using SimpleClinic_View.Globals;
using SimpleClinic_View.Users.DTOs;
using SimpleClinic_View.Appointments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleClinic_View.Appointments.DTOs;
using SimpleClinic_View.Doctors;
using SimpleClinic_View.Doctors.DTOs;
using SimpleClinic_View.Users;
using System.Numerics;

namespace SimpleClinic_View.Appointments
{
    public partial class frmAddUpdateAppointment : Form
    {

        public delegate void DataBackEventHandler(object sender, int appointmentId);
        public event DataBackEventHandler DataBack;
        

        public enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode;
        private int _AppointmentId = -1;


        private AppointmentService _appointmentService;
        private ApiResult<AllAppointmentDTO> _appointmentApiResult;


        public frmAddUpdateAppointment()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            _appointmentApiResult = new ApiResult<AllAppointmentDTO>();
        }

        public frmAddUpdateAppointment(int appointmentId)
        {
            InitializeComponent();
            _appointmentApiResult = new ApiResult<AllAppointmentDTO>(); // this to store the new appointment info
            _AppointmentId = appointmentId;
            _Mode = enMode.Update;
        }

        private async void _FillDoctorsInComboBox()
        {

            var doctors = await DoctorApiClient.GetAllDoctors();

            if (!doctors.IsSuccess)
                return;

            foreach (var a in doctors.Result)
            {

                cbDoctors.Items.Add(a);

            }

            cbDoctors.SelectedIndex = 0;

        }

        private void _ResetDefualtValues()
        {

            // deleting the personId and nationa No filter from the combo box 
            ctrlPersonCardWithFilter1.DeleteItemFromFilter(0);
            ctrlPersonCardWithFilter1.DeleteItemFromFilter(1);

            _FillDoctorsInComboBox();

            if (_Mode == enMode.AddNew)
            {
                dtpAppointmentDate.MinDate = DateTime.Now;

                lblMode.Text = "Add New Appointment";
                this.Text = "Add New Appointment";

                _appointmentService = new AppointmentService();
                _appointmentApiResult.Result = new AllAppointmentDTO(); // this to store the new appointment info

                tpAppointmentInfo.Enabled = false;

                ctrlPersonCardWithFilter1.FilterFocus();
            }
            else
            {
                lblMode.Text = "Update Appointment";
                this.Text = "Update Appointment";

                tpAppointmentInfo.Enabled = true;
                btnSave.Enabled = true;
            }


        }

        private async void _LoadData()
        {
            _appointmentService = await AppointmentService.StatFind(_AppointmentId);

            ctrlPersonCardWithFilter1.FilterEnabled = false;

            _appointmentApiResult = _appointmentService.ApiResult;

            if (!_appointmentApiResult.IsSuccess)
            {
                MessageBox.Show(_appointmentApiResult.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlPersonCardWithFilter1.LoadPersonInfo(_appointmentApiResult.Result.PatientId);

            lblAppointmentId.Text = _appointmentApiResult.Result.Id.ToString();
            _AppointmentId = _appointmentApiResult.Result.Id;

            dtpAppointmentDate.Value = _appointmentApiResult.Result.AppointmentDate;

            cbDoctors.SelectedIndex = cbDoctors.FindString($"{_appointmentApiResult.Result.DoctorName} - {_appointmentApiResult.Result.Specialization}");

        }

        private void frmAddUpdateAppointment_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpAppointmentInfo.Enabled = true;
                tcAppointments.SelectedTab = tcAppointments.TabPages["tpAppointmentInfo"];
                return;
            }

            if (ctrlPersonCardWithFilter1.PatientId == -1)
            {
                MessageBox.Show("Please Select a Patient", "Select a Patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();
            }
            else
            {
                btnSave.Enabled = true;
                tpAppointmentInfo.Enabled = true;
                tcAppointments.SelectedTab = tcAppointments.TabPages["tpAppointmentInfo"];

            }

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            _appointmentApiResult.Result.Id = _AppointmentId;
            _appointmentApiResult.Result.PatientId = ctrlPersonCardWithFilter1.PatientId;
            _appointmentApiResult.Result.AppointmentDate = dtpAppointmentDate.Value;
            _appointmentApiResult.Result.AppointmentStatus = "New";

            AllDoctorsInfoDTO doctor = new AllDoctorsInfoDTO();

            if (cbDoctors.SelectedItem != null)
                doctor = (AllDoctorsInfoDTO)cbDoctors.SelectedItem;

            _appointmentApiResult.Result.DoctorId = doctor.Id;

            _appointmentService.ApiResult = _appointmentApiResult;

            if (await _appointmentService.Save())
            {
                MessageBox.Show("New appointment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // firing the event
                DataBack?.Invoke(this, _appointmentService.AppointmentId);

                ctrlPersonCardWithFilter1.FilterEnabled = false;

                lblMode.Text = "Update Appointment";
                this.Text = "Update Appointment";
                _Mode = enMode.Update;
                lblAppointmentId.Text = _appointmentService.AppointmentId.ToString();
                _AppointmentId = _appointmentService.AppointmentId;

            }
            else
            {
                MessageBox.Show("Appointment save failed!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDoctors.SelectedItem != null)
            {
                var doctor = (AllDoctorsInfoDTO)cbDoctors.SelectedItem;

                MessageBox.Show($"{doctor.Id}, {doctor.PersonName}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
