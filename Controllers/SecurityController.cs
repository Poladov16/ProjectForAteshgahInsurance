using Ateshgah_Insurance_Project.Interfaces;
using Ateshgah_Insurance_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Ateshgah_Insurance_Project.Controllers
{
    public class SecurityController: Controller
    {
        public ActionResult SignUp()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SignUp(Client cl, FormCollection fc)
        {
            //DataSet CusTom = .SeeAllUser();
            //var CusT_Info = CusTom.Tables[0].AsEnumerable();
            if (ModelState.IsValid)
            {
                Task<string> res1 = Helper.SHA1.SHA(cl.Clien_Password);
                Task<string> res2 = Helper.SHA1.SHA(cl.Confirm_Pass);
                var HashPass = await res1;
                var ConfirmPass = await res2;
                if (HashPass == ConfirmPass)
                {
                    //var emails = CusT_Info.SingleOrDefault(w => w.Field<string>("Email") == cl.Client_Email);
                    if (cl.Client_Email!= null)
                    {
                        ModelState.AddModelError("Email", "The Email was used once");
                        return View(cl);
                    }
                    cl.Name = fc["Username"];
                    cl.Client_Email = fc["Email"];
                    cl.Clien_Password = HashPass;
                    cl.Confirm_Pass = ConfirmPass;
                   // CU.AddUser(cl);
                    return RedirectToAction("Login", "SignUp");
                }
            }
            return View();
        }
    }
}