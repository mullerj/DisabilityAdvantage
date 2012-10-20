using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DisabilityAdvantage.Models
{
    public class SchoolRepository : ISchoolRepository
    {
        private readonly DisabilityAdvantageContainer _context = new DisabilityAdvantageContainer();

        public IQueryable<School> FetchMany(string disability, string grade, string division)
        {
            return _context.ChildCounts.
                Where(r => r.DIV_NAME.Contains(division) && r.GRADE_CODE == grade && r.SCH_NAME != string.Empty && r.PRIMARY_DISABILITY_TYPE == disability).
                Select(r => new School() { Name = r.SCH_NAME, Disability = r.PRIMARY_DISABILITY_TYPE, StudentsWithDisabilityCount = r.DEC1_CNT }).
                OrderByDescending(r => r.StudentsWithDisabilityCount).Distinct();
        }
    }
}