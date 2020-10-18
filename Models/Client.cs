using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Compilation;

namespace Ateshgah_Insurance_Project.Models
{
    public class Client
    {
        [Key]
        public int ClientUniqueId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TelephoneNr { get; set; }
        public virtual ICollection<Loan> Loans { get; set; }

        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Client_Email { get; set; }
        public string Clien_Password{get;set;}
        public string Confirm_Pass { get; set; }
    }
}