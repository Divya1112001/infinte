using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Assignmentmvc1.Models
{
    public class MovieContext:DbContext
    {

        public MovieContext() : base("name=Cinemas")
        {

        }
        public DbSet<Movie> movies { get; set; }
     }

 }

