using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppCustomLayout.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            ViewBag.msg = "List Of Customers";
            return View();
        }
        public ActionResult NameList()
        {
            List<string> customers = new List<string>()
            {
            "Raj",
            "Ravi",
            "Nithin",
            "Vijay",
            "Dipesh"
            };
            ViewBag.NameList = customers;
            return View();
        }
    }
}