using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using Project2.Models;

namespace Project2.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext ec = new EmployeeContext();
        // GET: Employee
        public ActionResult Index()
        {
            return View(ec.Employees.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            ec.Employees.Add(employee);
            ec.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}