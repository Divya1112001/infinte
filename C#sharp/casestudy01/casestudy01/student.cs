using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy01
{
    class student
    {
        public int stdid { get; set; }
        public string stdname { get; set; }
        public DateTime dob { get; set; }
        
        public student(int stdid, string stdname, DateTime dob)
        {
            this.stdid = stdid;
            this.stdname = stdname;
            this.dob = dob;
        }
    }
}
