using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace EF_CodeFirstPrj.Models
{
    public class CarContext : DbContext
    {
        public CarContext() : base("name=Vehicles")
        {

        }

        public DbSet<Car> Cars { get; set; }
    }
}