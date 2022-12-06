using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginAddManager.Models;
namespace LoginAddManager.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager
        static List<ManagerModal> Employees = new List<ManagerModal>();
        public ActionResult Index()
        {
            return View(Employees);
        }

        public ActionResult Details(ManagerModal employee)
        {
            Employees.Add(employee);
            return View("Details", employee);
        }
       
    }
}