using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CodeFirstMvcProject_Arefin.Models;

namespace CodeFirstMvcProject_Arefin.Controllers
{
    public class CustomerRegistraionController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();


        // GET: CustomerRegistration
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CustomerRegistraion customer)
        {
            if (ModelState.IsValid)
            {
                db.CustomerRegistraions.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Success");
            }
            return View();
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}