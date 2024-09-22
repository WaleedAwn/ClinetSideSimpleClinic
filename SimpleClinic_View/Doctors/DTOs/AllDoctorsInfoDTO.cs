namespace SimpleClinic_View.Doctors.DTOs
{
    public class AllDoctorsInfoDTO
    {
        public AllDoctorsInfoDTO(int id, int PersonId, string specialization, string personName, DateTime dateOfBirth, string gender, string PhoneNumber, string email, string address)
        {
            this.Id = id;
            this.PersonId = PersonId;
            this.PersonName = personName;
            this.Specialization = specialization;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.PhoneNumber = PhoneNumber;
            this.Email = email;
            this.Address = address;

        }
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Specialization { get; set; }


        public string PersonName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{this.PersonName} - {this.Specialization}";
        }
    }

}
