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
        private int _appointmentId = -1;
        public int AppointmentId
        {
            get
            {
                return ctrlAppointmentCardWithFilter1.AppointmentId;
            }
        }
        enType _Type;

        private PaymentService _paymentService;

        private ApiResult<PaymentDTOWithName> _paymentApiResult;

        public frmAddUpdatePayment()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            _paymentApiResult = new ApiResult<PaymentDTOWithName>();
        }

        public frmAddUpdatePayment(int Id, enType type = enType.Payment)
        {
            InitializeComponent();

            _paymentApiResult = new ApiResult<PaymentDTOWithName>();
            _Type = type;

            if (_Type == enType.Payment)
            {
                _paymentId = Id;
                _Mode = enMode.Update;
            }
            else
            {
                _appointmentId = Id;
                _Mode = enMode.AddNew;
            }

        }

        private async void _FillPaymentMethodsInComboBox()
        {

            var methods = await PaymentService.GetAllPaymentMethodsAsync();

            if (!methods.IsSuccess)
                return;

            foreach (var a in methods.Result)
            {

                cbPaymentMethods.Items.Add(a.Name);
            }

            cbPaymentMethods.SelectedIndex = 0;

        }

        private void _ResetDefualtValues()
        {

            if (_Type == enType.Appointment)
            {
                ctrlAppointmentCardWithFilter1.LoadAppointmentInfo(_appointmentId);
                ctrlAppointmentCardWithFilter1.FilterEnabled = false;
            }

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

        private async void _LoadData()
        {
            _paymentService = await PaymentService.StatFind(_paymentId);

            ctrlAppointmentCardWithFilter1.FilterEnabled = false;

            _paymentApiResult = _paymentService.ApiPaymentResult;

            if (!_paymentApiResult.IsSuccess)
            {
                MessageBox.Show(_paymentApiResult.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var appointmentId = await AppointmentService.GetAppointmentIdByPaymentId(_paymentApiResult.Result.Id);

            if (!appointmentId.IsSuccess)
            {
                MessageBox.Show(appointmentId.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _appointmentId = appointmentId.Result;

            ctrlAppointmentCardWithFilter1.LoadAppointmentInfo(appointmentId.Result);

            lblPaymentId.Text = _paymentApiResult.Result.Id.ToString();
            _paymentId = _paymentApiResult.Result.Id;

            dtpPaymentDate.Value = _paymentApiResult.Result.PaymentDate;

            cbPaymentMethods.SelectedIndex = cbPaymentMethods.FindString($"{_paymentApiResult.Result.PaymentMethod}");
            txtAmountPaid.Text = _paymentApiResult.Result.AmountPaid.ToString();
            txtAdditionalNotes.Text = _paymentApiResult.Result.AdditionalNotes ?? "";

        }

        private void frmAddUpdatePayment_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpPaymentInfo.Enabled = true;
                tcPayments.SelectedTab = tcPayments.TabPages["tpPaymentInfo"];
                return;
            }

            if (ctrlAppointmentCardWithFilter1.AppointmentId != -1)
            {
                var appointment = await AppointmentService.StatFind(ctrlAppointmentCardWithFilter1.AppointmentId);

                if (appointment.ApiResult.Result.PaymentId != null)
                {
                    MessageBox.Show($"Appointment with Id [{ctrlAppointmentCardWithFilter1.AppointmentId} {Environment.NewLine}]Already have payment with Id[{appointment.ApiResult.Result.PaymentId}]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlAppointmentCardWithFilter1.FilterFocus();
                }
                else
                {
                    btnSave.Enabled = true;
                    tpPaymentInfo.Enabled = true;
                    tcPayments.SelectedTab = tcPayments.TabPages["tpPaymentInfo"];
                }
            }
            else
            {
                MessageBox.Show("Select appointmnet first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlAppointmentCardWithFilter1.FilterFocus();
            }

        }

        private void txtAmountPaid_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmountPaid.Text.Trim()))
            {
                e.Cancel = true;
                epPayments.SetError(txtAmountPaid, "Amount paid cannot be blank");

            }
            else
            {

                epPayments.SetError(txtAmountPaid, null);
            }
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            AppointmentService appointment = await AppointmentService.StatFind(AppointmentId);

            _paymentApiResult.Result.PaymentMethodId = cbPaymentMethods.SelectedIndex + 1;
            _paymentApiResult.Result.AmountPaid = decimal.Parse(txtAmountPaid.Text);
            _paymentApiResult.Result.PaymentDate = dtpPaymentDate.Value;
            _paymentApiResult.Result.AdditionalNotes = txtAdditionalNotes.Text;
            _paymentApiResult.Result.PaymentMethod = cbPaymentMethods.Text;

            _paymentService.ApiPaymentResult = _paymentApiResult;
            
            if (await _paymentService.Save())
            {
                MessageBox.Show("Payment added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                appointment.ApiResult.Result.PaymentId = _paymentService.PaymentId;
                
                lblPaymentId.Text = _paymentService.PaymentId.ToString();

                lblMode.Text = "Update payment";
                this.Text = "Update payment";
                _Mode = enMode.Update;
               

                if (await appointment.Save())
                {
                    appointment.SetWaiting();
                    
                    MessageBox.Show("Appointment status updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Appointment update failed", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Paymed adding failed", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
