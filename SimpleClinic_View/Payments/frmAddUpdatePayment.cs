using SimpleClinic_View.Appointments.DTOs;
using SimpleClinic_View.Appointments;
using SimpleClinic_View.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleClinic_View.Payments.DTOs;
using SimpleClinic_View.Doctors;
using SimpleClinic_View.Controls;

namespace SimpleClinic_View.Payments
{
    public partial class frmAddUpdatePayment : Form
    {
        public enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode;
        private int _paymentId = -1;


        private PaymentService _paymentService;

        private ApiResult<PaymentDTOWithName> _paymentApiResult;


        public frmAddUpdatePayment()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            _paymentApiResult = new ApiResult<PaymentDTOWithName>();
        }

        public frmAddUpdatePayment(int paymentId)
        {
            InitializeComponent();
            _paymentId = paymentId;
            _Mode = enMode.AddNew;
            _paymentApiResult = new ApiResult<PaymentDTOWithName>();

        }

        private async void _FillPaymentMethodsInComboBox()
        {

            var methods = await PaymentService.GetAllPaymentMethodsAsync();

            if (!methods.IsSuccess)
                return;

            foreach (var a in methods.Result)
            {

                cbPaymentMethods.Items.Add(a);

            }

            cbPaymentMethods.SelectedIndex = 0;

        }

        private void _ResetDefualtValues()
        {


            _FillPaymentMethodsInComboBox();

            if (_Mode == enMode.AddNew)
            {
                dtpPaymentDate.MinDate = DateTime.Now;

                lblMode.Text = "Add New Payment";
                this.Text = "Add New Payment";

                _paymentService = new PaymentService();
                _paymentApiResult.Result = new PaymentDTOWithName(); // this to store the new appointment info

                tpPaymentInfo.Enabled = false;

                ctrlAppointmentCardWithFilter1.FilterFocus();
            }
            else
            {
                lblMode.Text = "Update Payment";
                this.Text = "Update Payment";

                tpPaymentInfo.Enabled = true;
                btnSave.Enabled = true;
            }


        }

        //private async void _LoadData()
        //{
        //    _paymentService = await PaymentService.StatFind(_paymentId);

        //    ctrlAppointmentCardWithFilter1.FilterEnabled = false;

        //    _paymentApiResult = _paymentService.ApiPaymentResult;

        //    if (!_paymentApiResult.IsSuccess)
        //    {
        //        MessageBox.Show(_paymentApiResult.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    ctrlAppointmentCardWithFilter1.LoadAppointmentInfo(_paymentApiResult.Result);

        //    lblAppointmentId.Text = _appointmentApiResult.Result.Id.ToString();
        //    _AppointmentId = _appointmentApiResult.Result.Id;

        //    dtpAppointmentDate.Value = _appointmentApiResult.Result.AppointmentDate;

        //    cbDoctors.SelectedIndex = cbDoctors.FindString($"{_appointmentApiResult.Result.DoctorName} - {_appointmentApiResult.Result.Specialization}");

        //}




    }
}
