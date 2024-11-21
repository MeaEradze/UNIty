using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIty.Domain
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; } // e.g., Credit Card, PayPal
        public string Status { get; set; } // e.g., Completed, Pending
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }

}
