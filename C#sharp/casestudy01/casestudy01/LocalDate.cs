using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy01
{
    class LocalDate
    {
        public DateTime Enrollmentdate { get; set; }
        public LocalDate(DateTime enrollmentdate)
        {
            Enrollmentdate = enrollmentdate;
        }
    }
}
