using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Day2_EF.Models;

namespace Day2_EF.Models
{
    public class UserBL
    {
        EmployeetravelsystemEntities db = new EmployeetravelsystemEntities();

        public List<User>GetUsers()
        {
            return db.Users.ToList();
        }
    }
}