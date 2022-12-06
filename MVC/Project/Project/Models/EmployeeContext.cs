using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Project.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext():base("name=Employee")
        {

        }
        public DbSet<Employee> Employees{ get; set; }
    }
    
}