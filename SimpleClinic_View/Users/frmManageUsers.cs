using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleClinic_View.Globals;
using SimpleClinic_View.Users.DTOs;

namespace SimpleClinic_View.Users
{
    public partial class frmManageUsers : Form
    {
        private UserService _userServices;
        DataTable _dtUsers;
        public frmManageUsers()
        {
            InitializeComponent();
            _userServices = new UserService();
            _dtUsers = new DataTable();
        }

        private async void _RefreshUsers()
        {

            var userList = await _userServices.GetAllUsers();

            if (!userList.IsSuccess)
                return;

            _dtUsers = userList.Result.ToDataTable();
            _dtUsers.Columns.Remove("Password"); 
            dgvListAllUsers.DataSource = _dtUsers;

            lblCounter.Text = dgvListAllUsers.Rows.Count.ToString();


            if (dgvListAllUsers.Rows.Count > 0)
            {
                dgvListAllUsers.Columns[0].HeaderText = "User Id";
                dgvListAllUsers.Columns[0].Width = 125;

                dgvListAllUsers.Columns[1].HeaderText = "Person Id";
                dgvListAllUsers.Columns[1].Width = 125;

                dgvListAllUsers.Columns[2].HeaderText = "Full Name";
                dgvListAllUsers.Columns[2].Width = 300;

                dgvListAllUsers.Columns[3].HeaderText = "UserName";
                dgvListAllUsers.Columns[3].Width = 125;

            }
            cbFilterBy.SelectedIndex = 0;

        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvListAllUsers.CurrentRow.Cells[0].Value;
            frmShowUserCard user = new frmShowUserCard(id);
            user.ShowDialog();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser(-1);
            frm.ShowDialog();
            _RefreshUsers();
        }

        private void AddNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser(-1);
            frm.ShowDialog();
            _RefreshUsers();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvListAllUsers.CurrentRow.Cells[0].Value;
            frmAddEditUser frm = new frmAddEditUser(id);
            frm.ShowDialog();
            _RefreshUsers();
        }

        private async void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int id = (int)dgvListAllUsers.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure you want to delete User with Id[{id}]?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

            var apiResult = await _userServices.DeleteUser(id);
            if (apiResult.IsSuccess)
            {
                MessageBox.Show($"User with Id ={id} deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshUsers();
            }
            else
            {
                MessageBox.Show(apiResult.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvListAllUsers.CurrentRow.Cells[0].Value;
            frmChangeUserPassword frm = new frmChangeUserPassword(id);
            frm.ShowDialog();

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
            switch (cbFilterBy.Text)
            {
                case "User Id":
                    FilterColumn = "Id";
                    break;
                case "Person Id":
                    FilterColumn = "PersonId";
                    break;
                case "Full Name":
                    FilterColumn = "Name";
                    break;
                case "User Name":
                    FilterColumn = "UserName";
                    break;
                default:
                    FilterColumn = "None";
                    break;

            }

            if (txtFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtUsers.DefaultView.RowFilter = "";
                lblCounter.Text = dgvListAllUsers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "Id" || FilterColumn == "PersonId")
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());


        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterBy.Text == "User Id" || cbFilterBy.Text == "Person Id")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
