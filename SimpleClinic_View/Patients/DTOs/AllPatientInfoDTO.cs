namespace SimpleClinic_View.Patients.DTOs
{
    public class AllPatientInfoDTO
    {
        public AllPatientInfoDTO()
        {

        }
        public AllPatientInfoDTO(int id, int personId, string personName, DateTime dateOfBirth, string gender, string PhoneNumber, string email, string address)
        {
            Id = id;
            this.personId = personId;

            PersonName = personName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            this.PhoneNumber = PhoneNumber;
            Email = email;
            Address = address;

        }
        public int Id { get; set; }
        public int personId { get; set; }

        public string PersonName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

    }


}
