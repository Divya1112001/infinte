using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Test.Models;

namespace MVC_Test.Controllers
{
    public class CodeController : Controller
    {
        NorthwindEntities Ne = new NorthwindEntities();
        // GET: Code
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Details(string  Country)
        {
            if (Country == "Germany")
            {
                ViewBag.Country = new SelectList(Ne.Customers, "CustomerID", "CompanyName", "ContactName", "ContactTitle", "Country");
                return View();
            }
            
        }
        public ActionResult Edit(int? orderid)
        {
            if (orderid == 10248)
            {
                return ViewBag.Country = new SelectList(Ne.Customers, "CustomerID", "CompanyName", "ContactName", "ContactTitle", Customer.Country);
            }
           
        }



    }
}