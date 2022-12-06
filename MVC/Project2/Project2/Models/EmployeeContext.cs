using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Data.Entity;
using System.Web.Configuration;

namespace Project2.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(): base("name=Employee")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}