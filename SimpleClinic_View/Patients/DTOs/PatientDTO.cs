using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClinic_View.Patients.DTOs
{

    public class PatientDTO
    {
        public PatientDTO()
        {

        }
        public PatientDTO(int id, int Personid)
        {
            Id = id;
            PersonId = Personid;

        }


        public int Id { get; set; }
        public int PersonId { get; set; }

    }


}
