using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClinic_View.Preception.Model
{
    public class PerceptionDTO
    {
        public int PrescriptionID { get; set; }
        public int? MedicalRecordID { get; set; }
        public string MedicationName { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? SpecialInstructions { get; set; }

        public PerceptionDTO() { }
        public PerceptionDTO(int PrescriptionID,int? MedicalRecordID,string MedicationName,string Dosage,string Frequency,DateTime StartDate,DateTime EndDate,string? SpecialInstructions) 
        { 
            this.PrescriptionID = PrescriptionID;
            this.MedicalRecordID = MedicalRecordID;
            this.MedicationName = MedicationName;
            this.Dosage = Dosage;
            this.Frequency = Frequency;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.SpecialInstructions = SpecialInstructions;
        }
    }

}
