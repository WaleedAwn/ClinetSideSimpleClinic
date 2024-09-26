using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic_View.Appointments
{
    public partial class frmShowAppointmentCard : Form
    {

        private int _AppointmentId = -1;
        public int AppointmentId
        {
            get
            {
                return _AppointmentId;
            }
        }


        public frmShowAppointmentCard(int appointmentId)
        {
            InitializeComponent();
            _AppointmentId = appointmentId;
        }

        private async void frmShowAppointmentCard_Load(object sender, EventArgs e)
        {
            
            await ctrlAppointmentCard1.LoadAppointmentInfo(_AppointmentId);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
