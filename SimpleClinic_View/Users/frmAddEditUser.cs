using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmAddEditUser : Form
    {
        public enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode;
        private int _UserId = -1;


        private UserService _userService;
        private ApiResult<AllUserDTO> _apiResult;
        

        public frmAddEditUser(int userId)
        {
            InitializeComponent();
            _apiResult = new ApiResult<AllUserDTO>();
            
            

            _UserId = userId;
            if (_UserId == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }


        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values

            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New User";
                this.Text = "Add New User";

                _userService = new UserService();
                _apiResult.Result = new AllUserDTO(); // this to store the new user info

                tpUserInfo.Enabled = false;

                ctrlPersonCardWithFilter1.FilterFocus();
            }
            else
            {
                lblMode.Text = "Update User";
                this.Text = "Update User";

                tpUserInfo.Enabled = true;
                btnSave.Enabled = true;


            }

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";



        }

        private async void _LoadData()
        {

            _userService = await UserService.StatFind(_UserId);
            ctrlPersonCardWithFilter1.FilterEnabled = false;


            _apiResult = _userService.ApiResult;
            if (!_apiResult.IsSuccess)
            {
                MessageBox.Show(_apiResult.ErrorMessage, nameof(_apiResult.Status), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            _UserId = _apiResult.Result.Id;
            lblUserId.Text = _apiResult.Result.Id.ToString();
            txtUserName.Text = _apiResult.Result.UserName;
            txtPassword.Text = _apiResult.Result.Password;
            txtConfirmPassword.Text = _apiResult.Result.Password;
            ctrlPersonCardWithFilter1.LoadPersonInfo(_apiResult.Result.PersonId);

        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
                return;
            }
            else
            {

                errorProvider1.SetError(txtPassword, null);
            }

            if (txtPassword.Text.Length < 6)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password length must be at least 6 chars");

            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }

        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            };
        }

        private async void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }

            if (_Mode == enMode.AddNew)
            {
                if (await UserService.IsUserExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txtUserName, null);
                };
            }
            else
            {
                if (_apiResult.Result.UserName != txtUserName.Text.Trim())
                {
                    if (await UserService.IsUserExist(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, null);
                    };
                }
            }

        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpUserInfo.Enabled = true;
                tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpUserInfo"];
                return;
            }

            //incase of add new mode.
            if (ctrlPersonCardWithFilter1.PersonId != -1)
            {

                if (await UserService.IsPersonUser(ctrlPersonCardWithFilter1.PersonId))
                {

                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();
                }

                else
                {
                    btnSave.Enabled = true;
                    tpUserInfo.Enabled = true;
                    tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpUserInfo"];
                }
            }

            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();

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

            
            _apiResult.Result.Id = _UserId;
            _apiResult.Result.PersonId = ctrlPersonCardWithFilter1.PersonId;
            _apiResult.Result.UserName = txtUserName.Text.Trim();
            _apiResult.Result.Password = txtPassword.Text.Trim();

            
            _userService.ApiResult = _apiResult;

            if (await _userService.Save())
            {
                lblUserId.Text = _userService.UserId.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblMode.Text = "Update User";
                this.Text = "Update User";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(_userService.ApiResult.ErrorMessage, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void frmAddEditUser_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
