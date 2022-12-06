using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day2_EF.Models
{
    public class UserValidate
    {
        public static bool Login(string uname,string upassword)
        {
            UserBL userbl = new UserBL();
            var ulist = userbl.GetUsers();
            return ulist.Any(user => user.User_Name.Equals(uname, StringComparison.OrdinalIgnoreCase)
            && user.pwd == upassword);
        }
    }
}