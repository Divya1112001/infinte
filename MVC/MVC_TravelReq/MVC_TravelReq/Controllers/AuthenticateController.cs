using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_TravelReq.Models;

namespace MVC_TravelReq.Controllers
{
    public class AuthenticateController : Controller
    {
        
        // GET: Authenticate
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
       // [HttpPost]
        //public ActionResult Index(User user)
        //{
        //    var us = User.Where(a => a.LoginId == user.LoginId && a.Password == user.Password);

        //    if (us.Count() > 0 && us.FirstOrDefault().UserTypeId == 1)
        //    {
        //        return RedirectToAction("Admin", "Employee");
        //    }
        //    if (us.Count() > 0 && us.FirstOrDefault().UserTypeId == 2)
        //    {
        //        return RedirectToAction("Index", "TravelRequest", new { userTypeId = us.FirstOrDefault().UserTypeId.ToString() });
        //    }
        //    if (us.Count() > 0 && us.FirstOrDefault().UserTypeId == 3)
        //    {

        //        return RedirectToAction("Index", "TravelRequest", new { userTypeId = us.FirstOrDefault().UserTypeId.ToString() });
        //    }

        //    return View();
        //}
    }
}