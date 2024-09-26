using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic_View.Preception.FormsPreception
{
    public partial class frmShowPreception : Form
    {
        private int _PreceptionID;
        public frmShowPreception(int preceptionID)
        {
            InitializeComponent();
            _PreceptionID = preceptionID;
        }

        private async void frmShowPreception_Load(object sender, EventArgs e)
        {
            await ctrShowPreception1.LoadDataPreception(_PreceptionID);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
