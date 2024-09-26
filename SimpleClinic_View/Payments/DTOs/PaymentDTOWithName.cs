using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClinic_View.Payments.DTOs
{
    internal class PaymentDTOWithName
    {
        public PaymentDTOWithName()
        {
            
        }
        public PaymentDTOWithName(int id, string paidPatient, DateTime paymentDate, int paymentMethodId, string paymentMethod, decimal amountPaid, string? additionalNotes)
        {
            Id = id;
            PaymentDate = paymentDate;
            PaymentMethod = paymentMethod;
            AmountPaid = amountPaid;
            AdditionalNotes = additionalNotes;
            PaidPatient = paidPatient;
            PaymentMethodId = paymentMethodId;
        }

        public int Id { get; set; }
        public string PaidPatient { get; set; }
        public DateTime PaymentDate { get; set; }
        public int PaymentMethodId { get; set; }
        public string PaymentMethod { get; set; }
        public decimal AmountPaid { get; set; }
        public string? AdditionalNotes { get; set; }

    }
}
