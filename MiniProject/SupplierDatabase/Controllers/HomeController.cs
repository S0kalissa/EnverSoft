using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using SupplierDatabase.Models;

namespace SupplierDatabase.Controllers
{
    public class HomeController : Controller
    {
        Dictionary<string, string> SupplierList = new Dictionary<string,string>();
        Random rd = new Random();
        
        public List<SupplierViewModel> ListSuppliers()
        {

            List<SupplierViewModel> SuppliersModelList = new List<SupplierViewModel>();
            List<SupplierTable> Suppliers = new List<SupplierTable>();
            using (EnverSoftDBEntities1 connection = new EnverSoftDBEntities1())
            {
                Suppliers = connection.SupplierTables.ToList();
            }
            foreach(var rec in Suppliers)
            {
                SuppliersModelList.Add(new SupplierViewModel { Code = rec.Code, Name = rec.Name, PhoneNumber = rec.Telephone_No });
            }

            return SuppliersModelList;
        }
        
        public ActionResult Index(string name)
        {

            var test = ListSuppliers();
            if (!string.IsNullOrEmpty(name))
            {
                test = test.Where(x => x.Name == name).ToList();
            }
            return View(test);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Supplier()
        {
            ViewBag.Message = "";

            return View();
        }

        [HttpPost]
        public ActionResult Supplier(SupplierViewModel model)
        {
            ViewBag.Message = "Data loaded.";
            model.Code = rd.Next(10, 9000);
            if (ModelState.IsValid)
            {
                {
                    
                    using (EnverSoftDBEntities1 connection = new EnverSoftDBEntities1()) {
                        connection.SupplierTables.Add(new SupplierTable { Code=Convert.ToInt16(model.Code),Name=model.Name,Telephone_No=model.PhoneNumber});
                        connection.SaveChanges();
                    }
                }
            }
            return View();
        }



        public ActionResult Ordering()
        {
            ViewBag.Message = "Ordering.";

            return View();
        }

        public ActionResult WarehouseManagement()
        {
            ViewBag.Message = "WarehouseManagement.";

            return View();
        }

        public ActionResult Logistics()
        {
            ViewBag.Message = "Logistics.";

            return View();
        }

        public ActionResult Finances()
        {
            ViewBag.Message = "Finances.";

            return View();
        }


    }
}