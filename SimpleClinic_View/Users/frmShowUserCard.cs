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
    public partial class frmShowUserCard : Form
    {
        int _UserId = -1;
        public frmShowUserCard(int usreId)
        {
            InitializeComponent();
            _UserId = usreId;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowUserCard_Load(object sender, EventArgs e)
        {
            ctrlUserCard1.LoadUserInfo(_UserId);
        }
    }
}
