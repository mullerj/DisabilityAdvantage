using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DisabilityAdvantage.Models
{
    public class SchoolResult
    {
        public string Name { get; set; }
        public int DisabilityCount { get; set; }
        public int TotalCount { get; set; }
        public string DisabilityName { get; set; }
    }
}