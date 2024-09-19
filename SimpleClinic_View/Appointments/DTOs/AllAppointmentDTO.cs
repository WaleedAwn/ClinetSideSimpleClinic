namespace SimpleClinic_View.Appointments.DTOs
{
    public class AllAppointmentDTO
    {
        public AllAppointmentDTO()
        {
            
        }
        public AllAppointmentDTO(int id, int patientId, string personName, int doctorId, string doctorName, DateTime appointmentDate, string appointmentStatus, int? medicalRecordId, int? paymentId)
        {
            Id = id;
            PatientId = patientId;
            PersonName = personName;
            DoctorName = doctorName;
            DoctorId = doctorId;
            AppointmentDate = appointmentDate;
            AppointmentStatus = appointmentStatus;
            MedicalRecordId = medicalRecordId;
            PaymentId = paymentId;
        }

        public int Id { get; set; }
        public int PatientId { get; set; }
        public string PersonName { get; set; }
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public DateTime AppointmentDate { get; set; }

        public string AppointmentStatus { get; set; }

        public int? MedicalRecordId { get; set; }
        public int? PaymentId { get; set; }


    }



}
