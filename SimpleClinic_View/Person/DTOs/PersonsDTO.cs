using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClinic_View.Person.DTOs
{
    public class PersonsDTO
    {
        public PersonsDTO()
        {

        }
        public PersonsDTO(int id, string personName, DateTime dateOfBirth, string gender, string PhoneNumber, string email, string address)
        {
            Id = id;
            PersonName = personName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            this.PhoneNumber = PhoneNumber;
            Email = email;
            Address = address;
        }

        public int Id { get; set; }
        public string PersonName { get; set; }
        //public DateTime? DateOfBirth { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        //public string? Email { get; set; }
        //public string? Address { get; set; }

        public string Email { get; set; }
        public string Address { get; set; }




    }

}
