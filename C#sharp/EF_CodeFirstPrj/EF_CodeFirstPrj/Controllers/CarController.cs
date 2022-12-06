using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF_CodeFirstPrj.Models;

namespace EF_CodeFirstPrj.Controllers
{
    public class CarController : Controller
    {
        CarContext cc = new CarContext();
        // GET: Car
        public ActionResult Index()
        {
            return View(cc.Cars.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(Car car)
        {
            cc.Cars.Add(car);
            cc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}