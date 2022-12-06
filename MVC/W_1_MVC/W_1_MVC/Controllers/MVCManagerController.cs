using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using W_1_MVC.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace W_1_MVC.Controllers
{
    public class MVCManagerController : Controller
    {
        // GET: MVCManager
        public ActionResult Index()
        {
            return View();
        }
        //avtion method that is to consume the web api get
        public ActionResult DisplayEmplist()
        {
            IEnumerable<MVCManagerModel> Emplist = null;
            using (var webclient = new HttpClient())
            {
                webclient.BaseAddress = new Uri("http://localhost:52967/api/");
                var task = webclient.GetAsync("Manager");
                task.Wait();
                var Result = task.Result;
                if (Result.IsSuccessStatusCode)
                {
                    var resultdata = Result.Content.ReadAsStringAsync().Result;
                    Emplist = JsonConvert.DeserializeObject<List<MVCManagerModel>>(resultdata);
                }
                else
                {
                    Emplist = Enumerable.Empty<MVCManagerModel>();
                    ModelState.AddModelError(string.Empty, "Some Error Occured .. Try Later");
                }
                return View(Emplist);

            }
           
        }
    }
}