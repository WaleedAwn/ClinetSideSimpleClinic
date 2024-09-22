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
            
            cbDoctors.Items.Clear();

            if (!doctors.IsSuccess)
                return;

            string displayText;

            if (doctors.Result == null)
                MessageBox.Show("error");

            foreach (var a in doctors.Result)
            {
                displayText = $"{a.PersonName} - {a.Specialization}";
                cbDoctors.Items.Add(new { Id = a.Id, Display = displayText });
                
            }

            cbDoctors.DisplayMember = "Display";
            cbDoctors.ValueMember = "Id";

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

            lblAppointmentId.Text = _AppointmentId.ToString();

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

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void cbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
