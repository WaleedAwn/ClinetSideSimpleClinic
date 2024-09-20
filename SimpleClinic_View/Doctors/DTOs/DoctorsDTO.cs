using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClinic_View.Doctors.DTOs
{
   

    public class DoctorsDTO
    {
        public DoctorsDTO()
        {
            
        }
        public DoctorsDTO(int id, int Personid, string specialization)
        {
            this.Id = id;
            this.PersonId = Personid;
            Specialization = specialization;
        }

        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Specialization { get; set; }

    }

}
