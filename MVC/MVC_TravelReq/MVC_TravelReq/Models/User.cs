using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_TravelReq.Models
{
    public class User
    {
      public int UserId { get; set; }
      public int  LoginId  { get; set; }
      public string Password { get; set; }
      public  int UserTypeId  { get; set; }
      public  string Name { get; set; }
      public  int   ManagerUserId { get; set; }
       
    }
}