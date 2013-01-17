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
            return _context.Schools.Where(s =>
                s.Division.Name == division && s.Classes.Any(c => 
                    c.Grade.Code == grade && c.Disabilities.Any(d => 
                        d.DisabilityType.Name == disability)));
        }
    }
}