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
        public frmManageUsers()
        {
            InitializeComponent();
            _userServices = new UserService();
        }

        private async void _RefreshUsers()
        {
            dgvListAllUsers.Rows.Clear();
            var userList = await _userServices.GetAllUsers();


            foreach (var user in userList.Result)
            {
                dgvListAllUsers.Rows.Add(user.Id,user.PersonId,user.Name,user.UserName);
            }
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsers();
        }
    }
}
