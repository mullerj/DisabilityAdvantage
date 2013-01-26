using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DisabilityAdvantage.Models
{
    public class SchoolRepository : ISchoolRepository
    {
        private readonly DisabilityAdvantageContainer _context = new DisabilityAdvantageContainer();

        public IQueryable<SchoolResult> FetchMany(string disability, string grade, string division)
        {
            var disabilityName = _context.DisabilityTypes.SingleOrDefault(d => d.Code == disability).Name;

            return _context.Schools
                .Where(s => s.Division.Name == division
                    && s.Classes
                    .Any(c => c.Grade.Code == grade
                        && c.Disabilities.
                        Any(d => d.DisabilityType.Code == disability)))
                        .Select(s => new SchoolResult
                        {
                            Name = s.Name,
                            DisabilityCount = s.Classes
                                .FirstOrDefault(c => c.Grade.Code == grade).Disabilities
                                .FirstOrDefault(d => d.DisabilityType.Code == disability).StudentCount,
                            TotalCount = s.Classes
                                .FirstOrDefault(c => c.Grade.Code == grade).StudentCount,
                            DisabilityName = disabilityName
                        });
        }
    }
}