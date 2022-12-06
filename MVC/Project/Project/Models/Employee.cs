using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Project.Models
{
    public class Employee
    {
        [Key]
        public int empid { get; set; }
        public string empname { get; set; }
        public string email { get; set; }
        public DateTime DOB { get; set; }
        public string gender { get; set; }
        public string password { get; set; }
        public string projectid { get; set; }
        public string deptid { get; set; }
        public string empdesignation { get; set; } 
        public int phone { get; set; }
        public DateTime DOJ { get; set; }
        public string reportmanager { get; set; }
        public int salary { get; set; }
     
    }
}