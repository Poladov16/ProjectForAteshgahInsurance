using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ateshgah_Insurance_Project.Models
{   
    public class DbConnection:DbContext
    {
        public DbConnection() : base("conn")
        { }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<Loan> Loans { get; set; }
    }
}