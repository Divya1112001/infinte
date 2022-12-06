using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_TravelReq.Models
{
    public class TravelRequest
    {
        public int RequestId { get; set; }
        public DateTime RequestDate { get; set; }
        public string FromLocation { get; set; }
        public  string ToLocation { get; set; }
        public int UserId { get; set; }
        public string CurrentStatus { get; set; }
    }
}