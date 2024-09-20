using Microsoft.VisualBasic.ApplicationServices;
using SimpleClinic_View.Controls;
using SimpleClinic_View.Globals;
using SimpleClinic_View.Users.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic_View.Users
{
    public partial class frmChangeUserPassword : Form
    {

        private UserService _userService;
        private ApiResult<AllUserDTO> _apiResult;
        private int _userId = -1;

        public frmChangeUserPassword(int userId)
        {
            InitializeComponent();
            _apiResult = new ApiResult<AllUserDTO>();
            _userId = userId;
        }


        private void _ResetDefualtValues()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Focus();
        }

        private async void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            _userService = await UserService.StatFind(_userId);


            _apiResult = _userService.ApiResult;

            if (!_apiResult.IsSuccess)
            {
                MessageBox.Show(_apiResult.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            ctrlUserCard1.LoadUserInfo(_userId);

        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            };

            if (_apiResult.Result.Password != txtCurrentPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Current password is wrong!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            };
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "New Password cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            };

            if (txtNewPassword.Text.Length < 6)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "Password length must be at least 6 chars");

            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            }


        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match new Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            };
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

            _apiResult.Result.Password = txtNewPassword.Text.Trim();

            _userService.ApiResult = _apiResult;

            if (await _userService.Save())
            {
                MessageBox.Show("Password changed successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show(_userService.ApiResult.ErrorMessage, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
