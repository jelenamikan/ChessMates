using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ChessMates.Models;

namespace ChessMates.Controllers.Api
{
    public class ContinentsController : ApiController
    {
        private AppDatabase db = new AppDatabase();

        // GET: api/Continents
        public IQueryable<Continent> GetContinents()
        {
            return db.Continents;
        }

        // GET: api/Continents/5
        [ResponseType(typeof(Continent))]
        public IHttpActionResult GetContinent(string id)
        {
            Continent continent = db.Continents.Find(id);
            if (continent == null)
            {
                return NotFound();
            }

            return Ok(continent);
        }

        // PUT: api/Continents/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutContinent(string id, Continent continent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != continent.continent)
            {
                return BadRequest();
            }

            db.Entry(continent).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContinentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Continents
        [ResponseType(typeof(Continent))]
        public IHttpActionResult PostContinent(Continent continent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Continents.Add(continent);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ContinentExists(continent.continent))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = continent.continent }, continent);
        }

        // DELETE: api/Continents/5
        [ResponseType(typeof(Continent))]
        public IHttpActionResult DeleteContinent(string id)
        {
            Continent continent = db.Continents.Find(id);
            if (continent == null)
            {
                return NotFound();
            }

            db.Continents.Remove(continent);
            db.SaveChanges();

            return Ok(continent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ContinentExists(string id)
        {
            return db.Continents.Count(e => e.continent == id) > 0;
        }
    }
}