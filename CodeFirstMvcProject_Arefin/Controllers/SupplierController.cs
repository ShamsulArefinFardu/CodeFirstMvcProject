using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CodeFirstMvcProject_Arefin.Models;

namespace MVCProjectArefin.Controllers
{
    public class SupplierController : Controller
    {
        private ApplicationDbContext _context;
        public SupplierController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult List()
        {
            return Json(_context.Suppliers.ToList(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Add(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
            return Json(JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetbyID(int ID)
        {
            return Json(_context.Suppliers.FirstOrDefault(x => x.SupplierID == ID), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Update(Supplier supplier)
        {
            var data = _context.Suppliers.FirstOrDefault(x => x.SupplierID == supplier.SupplierID);
            if (data != null)
            {
                data.SupplierName = supplier.SupplierName;
                data.Email = supplier.Email;
                data.Phone = supplier.Phone;
                data.Address = supplier.Address;

                _context.SaveChanges();
            }
            return Json(JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(int ID)
        {
            var data = _context.Suppliers.FirstOrDefault(x => x.SupplierID == ID);
            _context.Suppliers.Remove(data);
            _context.SaveChanges();
            return Json(JsonRequestBehavior.AllowGet);
        }
    }
}