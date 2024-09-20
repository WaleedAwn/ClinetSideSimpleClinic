using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClinic_View.Appointments.DTOs
{
    public class AppointmentDTO
    {

        public AppointmentDTO()
        {
            
        }
        public AppointmentDTO(int id, int patientId, int doctorId, DateTime appointmentDate, byte appointmentStatus, int? medicalRecordId, int? paymentId)
        {
            Id = id;
            PatientId = patientId;
            DoctorId = doctorId;
            AppointmentDate = appointmentDate;
            AppointmentStatus = appointmentStatus;
            MedicalRecordId = medicalRecordId;
            PaymentId = paymentId;
        }

        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }

        public DateTime AppointmentDate { get; set; }

        public byte AppointmentStatus { get; set; }

        public int? MedicalRecordId { get; set; }
        public int? PaymentId { get; set; }


    }



}
