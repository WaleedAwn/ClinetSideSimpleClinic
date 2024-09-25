using SimpleClinic_View.Appointments.DTOs;
using SimpleClinic_View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic_View.Appointments
{
    public partial class ctrlAppointmentCardWithFilter : UserControl
    {
        public ctrlAppointmentCardWithFilter()
        {
            InitializeComponent();
        }


        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }

        private int _AppointmentId = -1;
        public int AppointmentId
        {
            get
            {
                return _AppointmentId;
            }
        }

        public AppointmentDTO GetAppointmentDto
        {
            get
            {
                return ctrlAppointmentCardMini1.GetAppointmenDto;
            }
        }

        public void LoadAppointmentInfo(int AppointmentID)
        {

            cbAppointmentFilters.SelectedIndex = 0;
            txtSearch.Text = AppointmentID.ToString();
            FindNow();

        }

        private async void FindNow()
        {
            switch (cbAppointmentFilters.Text)
            {

                case "Appointment Id":
                    await ctrlAppointmentCardMini1.LoadAppointmentInfo(int.Parse(txtSearch.Text));
                    break;

            }
        }


        private void ctrlAppointmentCardWithFilter_Load(object sender, EventArgs e)
        {
            cbAppointmentFilters.SelectedIndex = 0;
            txtSearch.Focus();
        }

        private void txtSearch_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSearch, "This field is required!");

            }
            else
                errorProvider1.SetError(txtSearch, null);
        }

        public void FilterFocus()
        {
            txtSearch.Focus();
        }


        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // if pressed enter perform click 
            {

                btnFind.PerformClick();
            }

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            FindNow();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdateAppointment frmAdd = new frmAddUpdateAppointment();
            frmAdd.DataBack += frmAddAppointment_DataBack;
            frmAdd.ShowDialog();
        }

        private void frmAddAppointment_DataBack(object sender, int appointmentId)
        {
            if (appointmentId > 0)
            {
                _AppointmentId = appointmentId;
                txtSearch.Focus();
                LoadAppointmentInfo(appointmentId);
            }
            else
                MessageBox.Show("Invalid appointment Id","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
           
        }
    
    
    }
}
