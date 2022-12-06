using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Day1_client.Models;
using System.Net.Http;

namespace Day1_client.Controllers
{
    public class MVCEmployeeController : Controller
    {
        EmployeetravelsystemEntities ENTITY = new EmployeetravelsystemEntities();
        // GET: MVCEmployee
        public ActionResult Index()
        {
            return View();
        }
        //avtion method that is to consume the web api get
        public ActionResult DisplayEmplist()
        {
            IEnumerable<MVCEmployeeModel> Emplist = null;
            using (var webclient = new HttpClient())
            {
                webclient.BaseAddress = new Uri("http://localhost:54846/api/");
                var responsetask = webclient.GetAsync("Manager");
                responsetask.Wait();
                var Result = responsetask.Result;
                if (Result.IsSuccessStatusCode)
                {
                    var resultdata = Result.Content.ReadAsStringAsync().Result;
                    Emplist = JsonConvert.DeserializeObject<List<MVCEmployeeModel>>(resultdata);
                }
                else
                {
                    Emplist = Enumerable.Empty<MVCEmployeeModel>();
                    ModelState.AddModelError(string.Empty, "Some Error Occured .. Try Later");
                }
                return View(Emplist);
                 
            }
            

            }
        public ActionResult get()
        {
            List<Employee_tbl> Elist = new List<Employee_tbl>();

            return View(Employee_tbl.ToList());
        }

    }

    
}