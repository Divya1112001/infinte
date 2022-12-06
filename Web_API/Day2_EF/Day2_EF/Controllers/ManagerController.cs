using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Http;
using System.Web.Http;
using Day2_EF.Models;

namespace Day2_EF.Controllers
{
    public class ManagerController : ApiController
    {
        EmployeetravelsystemEntities db = new EmployeetravelsystemEntities();
        //Get
        public IEnumerable<Employee_tbl> Get()
        {
            return db.Employee_tbl.ToList();
        }
    }
}
