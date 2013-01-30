using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using DisabilityAdvantage.Models;

namespace DisabilityAdvantage.Controllers
{
    public class DivisionsController : ApiController
    {
        private DisabilityAdvantageContainer db = new DisabilityAdvantageContainer();

        // GET api/Divisions
        public IEnumerable<Division> GetDivisions()
        {
            return db.Divisions.AsEnumerable();
        }

        // GET api/Divisions/5
        public Division GetDivision(int id)
        {
            Division division = db.Divisions.Find(id);
            if (division == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return division;
        }

        // PUT api/Divisions/5
        public HttpResponseMessage PutDivision(int id, Division division)
        {
            if (ModelState.IsValid && id == division.Number)
            {
                db.Entry(division).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // POST api/Divisions
        public HttpResponseMessage PostDivision(Division division)
        {
            if (ModelState.IsValid)
            {
                db.Divisions.Add(division);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, division);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = division.Number }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Divisions/5
        public HttpResponseMessage DeleteDivision(int id)
        {
            Division division = db.Divisions.Find(id);
            if (division == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Divisions.Remove(division);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, division);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}