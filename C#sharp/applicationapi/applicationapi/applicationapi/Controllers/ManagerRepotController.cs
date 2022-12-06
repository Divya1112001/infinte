using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using applicationapi.Models;

namespace applicationapi.Controllers
{
    public class ManagerRepotController : ApiController
    {
        newtravelbookingsystemEntities db = new newtravelbookingsystemEntities();
        public IHttpActionResult getEditing()
        {
            IEnumerable<employeelist_Result> result = db.employeelist();
            return Ok(result);
        }
    }
}
