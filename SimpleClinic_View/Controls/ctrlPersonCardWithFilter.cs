using Microsoft.VisualBasic.ApplicationServices;
using SimpleClinic_View.Globals;
using SimpleClinic_View.Users;
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

namespace SimpleClinic_View.Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        private ApiResult<AllUserDTO> _apiResult;
        private int _personId = -1;
        public int PersonId
        {
            get
            {
                return _personId;
            }
        }


        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
            _apiResult = new ApiResult<AllUserDTO>();
        }

        private async void btnFind_Click(object sender, EventArgs e)
        {
            epPersonFilter.Clear();
            if (txtSearch.Text.Trim() == "")
            {
                epPersonFilter.SetError(txtSearch, "Search field is Empty!!");
                return;
            }

            if (cbPersonFilters.SelectedIndex == 0)
            {
                if (!int.TryParse(txtSearch.Text.ToString(), out _personId))
                {
                    epPersonFilter.SetError(txtSearch, "Person ID is not valid,only digits!");
                    return;
                }
            }

            switch (cbPersonFilters.SelectedIndex)
            {
                case 0:
                    {
                        _apiResult = await UserService.StatFind(_personId);

                        if (!_apiResult.IsSuccess)
                        {
                            MessageBox.Show(_apiResult.ErrorMessage, nameof(_apiResult.Status), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                            return;
                        }
                        ctrlPersonCard1._LoadPersonData(_personId);

                    }
                    break;
                case 1:
                    {
                        MessageBox.Show("Search with national No not implemented yet");
                    }
                    break;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbPersonFilters.SelectedIndex = 0;
        }



    }
}
