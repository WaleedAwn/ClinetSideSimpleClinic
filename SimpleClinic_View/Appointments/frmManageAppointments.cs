using Microsoft.VisualBasic;
using SimpleClinic_View.Appointments.DTOs;
using SimpleClinic_View.Globals;
using SimpleClinic_View.Users;
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
    public partial class frmManageAppointments : Form
    {
        private AppointmentService _appointmentService;
        DataTable _dtAppointments;

        BindingSource _bindingSource = new BindingSource();
        public frmManageAppointments()
        {
            InitializeComponent();
            _appointmentService = new AppointmentService();

        }

        private async void _RefreshAppointments()
        {

            var appointments = await  _appointmentService.GetAllAppointments();

            if (!appointments.IsSuccess)
                return;


            _dtAppointments = appointments.Result.ToDataTable();

            dgvListAllAppointments.DataSource = _dtAppointments;

            
            lblCounter.Text = dgvListAllAppointments.Rows.Count.ToString();

            if (dgvListAllAppointments.Rows.Count > 0)
            {
                dgvListAllAppointments.Columns[0].HeaderText = "Id";

                dgvListAllAppointments.Columns[1].HeaderText = "Patient Id";
                dgvListAllAppointments.Columns[2].HeaderText = "Patient Name";
                dgvListAllAppointments.Columns[3].HeaderText = "Dr.Id";
                dgvListAllAppointments.Columns[4].HeaderText = "Dr.Name";
                dgvListAllAppointments.Columns[5].HeaderText = "Dr.Specialization";
                dgvListAllAppointments.Columns[6].HeaderText = "App Date";
                dgvListAllAppointments.Columns[7].HeaderText = "Status";
                dgvListAllAppointments.Columns[8].HeaderText = "Medical Record";
                dgvListAllAppointments.Columns[9].HeaderText = "Payment";

            }

            cbFilterBy.SelectedIndex = 0;
        }

        private void frmManageAppointments_Load(object sender, EventArgs e)
        {

            _RefreshAppointments();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = (cbFilterBy.Text != "None");

            if (txtFilter.Visible)
            {
                txtFilter.Text = "";
                txtFilter.Focus();
            }

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.SelectedIndex)
            {

                case 1:
                    FilterColumn = "Id";
                    break;

                case 2:
                    FilterColumn = "PatientID";
                    break;


                case 3:
                    FilterColumn = "PersonName";
                    break;

                case 4:
                    FilterColumn = "DoctorID";
                    break;
                case 5:
                    FilterColumn = "DoctorName";
                    break;
                case 6:
                    FilterColumn = "AppointmentStatus";
                    break;
                case 7:
                    FilterColumn = "MedicalRecordId";
                    break;
                case 8:
                    FilterColumn = "PaymentId";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAppointments.DefaultView.RowFilter = "";
                lblCounter.Text = dgvListAllAppointments.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "Id" || FilterColumn == "PatientID" || FilterColumn == "DoctorID"
                || FilterColumn == "MedicalRecordId" || FilterColumn == "PaymentId")
                //in this case we deal with integer not string.
                _dtAppointments.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
            else
                _dtAppointments.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());

            lblCounter.Text = dgvListAllAppointments.Rows.Count.ToString();

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 1 || cbFilterBy.SelectedIndex == 2 || cbFilterBy.SelectedIndex == 4 || cbFilterBy.SelectedIndex == 7 || cbFilterBy.SelectedIndex == 8)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AddNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateAppointment frm = new frmAddUpdateAppointment();
            frm.ShowDialog();
            _RefreshAppointments();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvListAllAppointments.CurrentRow.Cells[0].Value;
            frmAddUpdateAppointment frm = new frmAddUpdateAppointment(id);
            frm.ShowDialog();
            _RefreshAppointments();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdateAppointment frm = new frmAddUpdateAppointment();
            frm.ShowDialog();
            _RefreshAppointments();
        }

        private async void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int id = (int)dgvListAllAppointments.CurrentRow.Cells[0].Value;
            if (MessageBox.Show($"Are you sure you want to delete appointment wiht Id=[{id}]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                var deleteResult = await AppointmentService.DeleteAppointment(id);
                if (deleteResult.IsSuccess)
                {
                    MessageBox.Show("Delete Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshAppointments();
                }
                else
                {
                    MessageBox.Show(deleteResult.ErrorMessage, "Delete Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void cancelAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to cancel this appointment?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int id = (int)dgvListAllAppointments.CurrentRow.Cells[0].Value;
            var appointmentService = await AppointmentService.StatFind(id);

            if (appointmentService != null)
            {
                if (await appointmentService.Cancel())
                {
                    MessageBox.Show("Appointment cancelled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshAppointments();
                }
                else
                {
                    MessageBox.Show(appointmentService.ApiResult.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private async void cmsAppointmentMenu_Opening(object sender, CancelEventArgs e)
        {
            int id = (int)dgvListAllAppointments.CurrentRow.Cells[0].Value;

            AppointmentService appointment = await AppointmentService.StatFind(id);

            bool isNewOrWait = (appointment.AppointmentStatus == AppointmentService.enAppointmentStatus.New ||
                       appointment.AppointmentStatus == AppointmentService.enAppointmentStatus.Waiting);

            EditToolStripMenuItem.Enabled = isNewOrWait;

            deleteToolStripMenuItem1.Enabled = appointment.AppointmentStatus == AppointmentService.enAppointmentStatus.New;

            cancelAppointmentToolStripMenuItem.Enabled = isNewOrWait;

            completeProceduresToolStripMenuItem.Enabled = isNewOrWait;

            tsmiPayment.Enabled = appointment.AppointmentStatus == AppointmentService.enAppointmentStatus.New;

            tsmiVisitDoctor.Enabled = appointment.AppointmentStatus == AppointmentService.enAppointmentStatus.Waiting;

        }

        private void ShowDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvListAllAppointments.CurrentRow.Cells[0].Value;
            frmShowAppointmentCard frm = new frmShowAppointmentCard(id);
            frm.ShowDialog();

        }
    }
}
