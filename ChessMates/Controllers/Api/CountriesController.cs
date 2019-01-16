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
using Newtonsoft.Json.Linq;

namespace ChessMates.Controllers.Api
{
    public class CountriesController : ApiController
    {
        private AppDatabase db = new AppDatabase();

        // GET: api/Countries
        public IQueryable<Country> GetCountries()
        {
            return db.Countries;
        }

        // GET: api/Countries/5
        [ResponseType(typeof(Country))]
        public IHttpActionResult GetCountry(string id)
        {
            Country country = db.Countries.Find(id);
            if (country == null)
            {
                return NotFound();
            }

            return Ok(country);
        }

        // PUT: api/Countries/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCountry(string id, Country country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != country.isoAlpha3)
            {
                return BadRequest();
            }

            db.Entry(country).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountryExists(id))
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

        // POST: api/Countries
        /*    [ResponseType(typeof(Country))]
            public IHttpActionResult PostCountry(Country country)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                db.Countries.Add(country);

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    if (CountryExists(country.isoAlpha3))
                    {
                        return Conflict();
                    }
                    else
                    {
                        throw;
                    }
                }

                return CreatedAtRoute("DefaultApi", new { id = country.isoAlpha3 }, country);
            }*/

        public IHttpActionResult Post(JArray objData)
        {
            List<Country> lstItemDetails = new List<Country>();

            foreach (var item in objData)
            {
                lstItemDetails.Add(item.ToObject<Country>());
            }

            foreach (Country itemDetail in lstItemDetails)
            {
                db.Countries.Add(itemDetail);
            }

            db.SaveChanges();

            return Ok();
        }       

        // DELETE: api/Countries/5
        [ResponseType(typeof(Country))]
        public IHttpActionResult DeleteCountry(string id)
        {
            Country country = db.Countries.Find(id);
            if (country == null)
            {
                return NotFound();
            }

            db.Countries.Remove(country);
            db.SaveChanges();

            return Ok(country);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CountryExists(string id)
        {
            return db.Countries.Count(e => e.isoAlpha3 == id) > 0;
        }
    }
}