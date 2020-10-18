using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ateshgah_Insurance_Project.Models
{
    public class Invoices
    {
        [Key]
       public int InvoicesID { get; set; }
        public float Amount { get; set; }
        public DateTime DueData { get; set; }
        public int InvoiceNr { get; set; }
        public int OrderNr { get; set; }
    }
}