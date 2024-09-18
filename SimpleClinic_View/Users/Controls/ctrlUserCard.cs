using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleClinic_View.DTOs;
using SimpleClinic_View.Users.DTOs;
using SimpleClinic_View.Globals;

namespace SimpleClinic_View.Users.Controls
{
    public partial class ctrlUserCard : UserControl
    {
        private ApiResult<AllUserDTO> _apiResult;
        private int _UserId = -1;
        public int UserId
        {
            get
            {
                return _UserId;
            }
        }

        public ctrlUserCard()
        {
            InitializeComponent();

        }
        public  async void LoadUserInfo(int userID)
        {

            _apiResult = await UserService.StatFind(userID);

            if(!_apiResult.IsSuccess)
            {
                MessageBox.Show(_apiResult.ErrorMessage,nameof(_apiResult.Status),MessageBoxButtons.OK,MessageBoxIcon.Error);
                _ResetUserInfo();
               
            }
            else
                _FillUserInfo();

        }

        private void _ResetUserInfo()
        {

            lblUserID.Text = "????";
            lblUsername.Text = "????";
            

        }

        private void _FillUserInfo()
        {
            _UserId = _apiResult.Result.Id;

            ctrlPersonCard1._LoadPersonData(_apiResult.Result.PersonId);
            lblUserID.Text = _apiResult.Result.Id.ToString();
            lblUsername.Text = _apiResult.Result.UserName;
           // lblIsActive.Text = (_User.IsActive == true) ? "Yes" : "No";

        }


    }
}
