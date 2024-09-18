using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic_View
{
    public partial class frmShowPersonDetails : Form
    {

        int _personID;
        public frmShowPersonDetails(int PersonID)
        {
            InitializeComponent();
            _personID = PersonID;
        }

        private void frmShowPersonDetails_Load(object sender, EventArgs e)
        {
            
            ctrlPersonCard1._LoadPersonData(_personID);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPersoninfo(_personID);
            frm.ShowDialog();

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPersoninfo(-1);
            frm.ShowDialog();

        }
    }
}
