using SimpleClinic_View.Appointments.DTOs;
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
    public partial class ctrlAppointmentCard : UserControl
    {

        AppointmentDTO _AppointmentDto;
        

        public ctrlAppointmentCard()
        {
            InitializeComponent();
        }

        public void LoadAppointmentInfo(AppointmentDTO appointmnetDto)
        {

            if(appointmnetDto == null)
            {
                MessageBox.Show("No appointment data found!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _AppointmentDto = appointmnetDto;
            _FillAppointmentInfo();

        }

        private void _ResetDefaults()
        {
            lblAppointmentId.Text = "????";
            lblStatus.Text = "????";
            lblAppointmentDate.Text = "????";
            llShowMedicalRecord.Enabled = false;
            llShowPayment.Enabled = false;
        }

        private  void _FillAppointmentInfo()
        {

            llShowPayment.Enabled = _AppointmentDto.PaymentId != null;
            llShowMedicalRecord.Enabled = _AppointmentDto.MedicalRecordId != null;

             ctrlPersonCard1._LoadPatientData(_AppointmentDto.PatientId);

            ctrlDoctorCard1.LoadDoctorInfo(_AppointmentDto.DoctorId);

            lblAppointmentId.Text = _AppointmentDto.Id.ToString();
            lblAppointmentDate.Text = _AppointmentDto.AppointmentDate.ToShortDateString();

            switch(_AppointmentDto.AppointmentStatus)
            {
                case 1:
                    lblStatus.Text = "New";
                    break;
                case 2:
                    lblStatus.Text = "Cancelled";
                    break;
                case 3:
                    lblStatus.Text = "Waiting";
                    break;
                case 4:
                    lblStatus.Text = "Completed";
                    break;
            }
            
        }

        private void ctrlDoctorCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
