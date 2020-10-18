using Ateshgah_Insurance_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ateshgah_Insurance_Project.Controllers
{
    public class ClientController : Controller
    {
        private readonly DbConnection _context;

        public ClientController(DbConnection context)
        {
            _context = context;
        }
        public ActionResult ListOfLoans()
        {
            var model =_context.Loans.ToList();
            return View(model);
        }
        public ActionResult ListOfLoans(int? id)
        {
            _context.Loans.Find(id);
            return View();
        }
    }
}