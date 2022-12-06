using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_EF.Models;

namespace WebAPI_EF.Controllers
{
    public class CustomersController : ApiController
    {
        NorthwindEntities Ne = new NorthwindEntities();
        //Get
        public IEnumerable<Customer>Get()
        {
            return Ne.Customers.ToList();

        }

    }
}
