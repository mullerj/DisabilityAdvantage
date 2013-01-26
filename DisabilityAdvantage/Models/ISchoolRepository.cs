using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisabilityAdvantage.Models
{
    interface ISchoolRepository
    {
        IQueryable<SchoolResult> FetchMany(string disability, string grade, string division);
    }
}
