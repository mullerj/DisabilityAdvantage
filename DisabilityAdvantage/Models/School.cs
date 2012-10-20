using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DisabilityAdvantage.Models
{
    public class School
    {
        public string Name { get; set; }

        public int StudentsWithDisabilityCount { get; set; }

        public int TotalStudentCount { get; set; }

        public string Disability { get; set; }
    }
}