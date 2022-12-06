using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginAddManager.Controllers
{
    public class LoginController : Controller
    {

        // GET: Login
        public ActionResult LoginIndex()
        {
            return View();
        }
        //public ActionResult Test(LoginModel Userlogin)
        //{
        //      [HttpPost]
        //public ActionResult Index(LoginModel objuserlogin)
        //{
        //    var display = Userloginvalues().Where(m => m.UserName == objuserlogin.UserName && m.UserPassword == objuserlogin.UserPassword).FirstOrDefault();
        //    if (display != null)
        //    {
        //        ViewBag.Status = "CORRECT UserNAme and Password";
        //    }
        //    else
        //    {
        //        ViewBag.Status = "INCORRECT UserName or Password";
        //    }
        //    return View(Userlogin);
        //}
    //}
    }
}