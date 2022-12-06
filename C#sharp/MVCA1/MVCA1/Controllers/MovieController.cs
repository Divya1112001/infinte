using MVCA1.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCA1.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
       MovieDBEntities dbObj = new MovieDBEntities();
        public ActionResult Movy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddMovie()
        {
            return View();
        }


    }

 
    
}


