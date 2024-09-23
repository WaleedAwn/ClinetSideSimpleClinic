using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClinic_View.MedicalRecords.Model
{
   
        public class MedicalRecordDTO
        {
            public int MedicalRecordID { get; set; }
            public string? VisitDescription { get; set; }
            public string? Diagnosis { get; set; }
            public string? AdditionalNotes { get; set; }

            public MedicalRecordDTO(int MedicalRecordID,string? VisitDescription,string? Diagnosis, string? AdditionalNotes) 
            {
                this.MedicalRecordID = MedicalRecordID;
                this.VisitDescription = VisitDescription;
                this.Diagnosis = Diagnosis;
                this.AdditionalNotes = AdditionalNotes;
            
            }
        }
    
}
