﻿using System;
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
        public frmManageUsers()
        {
            InitializeComponent();
            _userServices = new UserService();
        }

        private async void _RefreshUsers()
        {
            dgvListAllUsers.Rows.Clear();
            var userList = await _userServices.GetAllUsers();
            if (userList.Result.Count > 0)
                lblCounter.Text = userList.Result.Count.ToString();

            foreach (var user in userList.Result)
            {
                dgvListAllUsers.Rows.Add(user.Id, user.PersonId, user.Name, user.UserName);
            }
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
    }
}
