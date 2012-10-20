using DisabilityAdvantage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DisabilityAdvantage.Controllers
{
    public class SchoolsController : ApiController
    {
        // GET api/values
        public IEnumerable<School> Get(string disability, string grade, string division)
        {
            return new School[] { 
                new School { Name = "School 1", StudentsWithDisabilityCount = 2, TotalStudentCount = 4, Disability = disability }, 
                new School { Name = "School 2", StudentsWithDisabilityCount = 1, TotalStudentCount = 5, Disability = disability }
            };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}