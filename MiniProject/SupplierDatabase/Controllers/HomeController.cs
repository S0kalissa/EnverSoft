using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;
using SupplierDatabase.Models;

namespace SupplierDatabase.Controllers
{
    public class HomeController : Controller
    {
        Dictionary<string, string> SupplierList = new Dictionary<string,string>();

        public List<SupplierViewModel> ListSuppliers()
        {

            List<SupplierViewModel> test = new List<SupplierViewModel>();
            SupplierViewModel rec = new SupplierViewModel();
            rec.Code = "123"; rec.Name = "Londy"; rec.PhoneNumber = "0784518956";
            test.Add(rec);
            SupplierViewModel rec1 = new SupplierViewModel();
            rec1.Code = "231"; rec1.Name = "Lindani"; rec1.PhoneNumber = "0784518745";
            test.Add(rec1);
            SupplierViewModel rec2 = new SupplierViewModel();
            rec2.Code = "412"; rec2.Name = "Lindiwe"; rec2.PhoneNumber = "0784511474";
            test.Add(rec2);
            SupplierViewModel rec3 = new SupplierViewModel();
            rec3.Code = "123"; rec3.Name = "Londy"; rec3.PhoneNumber = "0784518956";
            test.Add(rec3);
            SupplierViewModel rec13 = new SupplierViewModel();
            rec13.Code = "231"; rec13.Name = "Lindani"; rec13.PhoneNumber = "0784518745";
            test.Add(rec13);
            SupplierViewModel rec23 = new SupplierViewModel();
            rec23.Code = "412"; rec23.Name = "Lindiwe"; rec23.PhoneNumber = "0784511474";
            test.Add(rec23);
            SupplierViewModel rec33 = new SupplierViewModel();
            rec33.Code = "123"; rec33.Name = "Londy"; rec33.PhoneNumber = "0784518956";
            test.Add(rec33);
            SupplierViewModel rec133 = new SupplierViewModel();
            rec133.Code = "231"; rec133.Name = "Lindani"; rec133.PhoneNumber = "0784518745";
            test.Add(rec1);
            SupplierViewModel rec233 = new SupplierViewModel();
            rec233.Code = "412"; rec233.Name = "Lindiwe"; rec233.PhoneNumber = "0784511474";
            test.Add(rec233);
            return test;
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
            ViewBag.Message = "Supplier.";

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