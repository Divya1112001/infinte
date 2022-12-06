using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignmentmvc1.Models;

namespace Assignmentmvc1.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        MoviesDBEntities obj = new MoviesDBEntities();
        public ActionResult Index()
        {
            return View(obj.Movies.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Create(FormCollection frm)
        {
            Movie m = new Movie();
            m.Mid = Convert.ToInt32(frm["ShipperID"]);
            m.Moviename = frm["Moviename"].ToString();
            m.DateofRelease = frm["DateofRelease"].ToString();

            obj.Movies.Add(m);
            obj.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}