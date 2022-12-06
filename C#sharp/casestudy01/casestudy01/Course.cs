using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy01
{
    class Course
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public string Duration { get; set; }
        public double Fees { get; set; }
        public Course(int courseid, string cname, string coursedur, double coursefee)
        {
            CId = courseid;
            CName = cname;
            Duration = coursedur;
            Fees = coursefee;
        }
    }
}
