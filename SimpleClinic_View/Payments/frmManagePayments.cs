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

namespace SimpleClinic_View.Payments
{
    public partial class frmManagePayments : Form
    {

        private PaymentService _PaymentService;
        DataTable _dtPayments;

        public frmManagePayments()
        {
            InitializeComponent();
            _PaymentService = new PaymentService();
        }


        private async void _RefreshPayments()
        {
            var payments = await _PaymentService.GetAllPaymentsAsync();

            if (!payments.IsSuccess)
            {
                return;
            }

            _dtPayments = payments.Result.ToDataTable();

            dgvListAllPayments.DataSource = _dtPayments;

            lblCounter.Text = dgvListAllPayments.Rows.Count.ToString();

            if (dgvListAllPayments.Rows.Count > 0)
            {
                dgvListAllPayments.Columns[0].HeaderText = "Id";
                dgvListAllPayments.Columns[0].Width = 90;
                dgvListAllPayments.Columns[1].HeaderText = "Patient Name";
                dgvListAllPayments.Columns[2].HeaderText = "Pay Date";
                dgvListAllPayments.Columns[3].HeaderText = "Method Id";
                dgvListAllPayments.Columns[3].Width = 140;
                dgvListAllPayments.Columns[4].HeaderText = "Pay Method";
                dgvListAllPayments.Columns[5].HeaderText = "Amount Paid";
                dgvListAllPayments.Columns[6].HeaderText = "Additional Notes";
            }

            cbFilterBy.SelectedIndex = 0;

        }


        private void frmManagePayments_Load(object sender, EventArgs e)
        {
            _RefreshPayments();
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
            string columnFilter = "";

            switch (cbFilterBy.SelectedIndex)
            {
                case 1:
                    columnFilter = "Id";
                    break;
                case 2:
                    columnFilter = "PaidPatient";
                    break;
                case 3:
                    columnFilter = "PaymentMethodId";
                    break;
                case 4:
                    columnFilter = "PaymentMethod";
                    break;
                case 5:
                    columnFilter = "AmountPaid";
                    break;
                case 6:
                    columnFilter = "AdditionalNotes";
                    break;
                default:
                    columnFilter = "None";
                    break;



            }


            if (txtFilter.Text.Trim() == "" || columnFilter == "None")
            {
                _dtPayments.DefaultView.RowFilter = "";
                lblCounter.Text = dgvListAllPayments.Rows.Count.ToString();
                return;
            }

            if (columnFilter == "Id" || columnFilter == "PaymentMethodId" || columnFilter == "AmountPaid")
            {
                _dtPayments.DefaultView.RowFilter = string.Format("[{0}] = {1}", columnFilter, txtFilter.Text.Trim());
            }
            else
                _dtPayments.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", columnFilter, txtFilter.Text.Trim());

            lblCounter.Text = dgvListAllPayments.Rows.Count.ToString();

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 1 || cbFilterBy.SelectedIndex == 3 || cbFilterBy.SelectedIndex == 5)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
