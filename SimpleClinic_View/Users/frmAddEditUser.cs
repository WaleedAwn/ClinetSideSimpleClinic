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
        private ApiResult<UserDTO> apiResult;

        public frmAddEditUser(int userId)
        {
            InitializeComponent();
            _UserId = userId;
            if(_UserId == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        private void _LoadData()
        {
            

            
        }


    }
}
