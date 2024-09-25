using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic_View.MedicalRecords.ListMedicalRecods
{
    public partial class frmShowMedicalInfo : Form
    {
        private int _MedicalRecords = -1;
        public frmShowMedicalInfo(int MedicalRecord)
        {
            InitializeComponent();
            this._MedicalRecords = MedicalRecord;
        }

        private async void frmShowMedicalInfo_Load(object sender, EventArgs e)
        {
           await ctrShowMedicalRecordss1.LoadDataMedicalRecord(_MedicalRecords);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
