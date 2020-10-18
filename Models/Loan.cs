using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ateshgah_Insurance_Project.Models
{
    public class Loan
    {
        [Key]
        public int LoanId { get; set; }
        public float Amount { get; set; }
        public double InteresRate { get; set; }
        public int LoanPeriod { get; set; }
        public DateTime PayoutDate { get; set; }
        public int ClientID { get; set; }
    }
}