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
    public class TournamentsController : ApiController
    {
        private AppDatabase db = new AppDatabase();

        // GET: api/Tournaments
        public IQueryable<Tournament> GetTournaments()
        {
            return db.Tournaments;
        }

        // GET: api/Tournaments/5
        [ResponseType(typeof(Tournament))]
        public IHttpActionResult GetTournament(long id)
        {
            Tournament tournament = db.Tournaments.Find(id);
            if (tournament == null)
            {
                return NotFound();
            }

            return Ok(tournament);
        }

        // PUT: api/Tournaments/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTournament(long id, Tournament tournament)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tournament.Id)
            {
                return BadRequest();
            }

            db.Entry(tournament).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TournamentExists(id))
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

        /* // POST: api/Tournaments
         [ResponseType(typeof(Tournament))]
         public IHttpActionResult PostTournament(Tournament tournament)
         {
             if (!ModelState.IsValid)
             {
                 return BadRequest(ModelState);
             }

             db.Tournaments.Add(tournament);
             db.SaveChanges();

             return CreatedAtRoute("DefaultApi", new { id = tournament.Id }, tournament);
         }*/

        public IHttpActionResult Post(JArray objData)
        {
            List<Tournament> lstItemDetails = new List<Tournament>();

            foreach (var item in objData)
            {
                lstItemDetails.Add(item.ToObject<Tournament>());
            }

            foreach (Tournament itemDetail in lstItemDetails)
            {
                db.Tournaments.Add(itemDetail);
            }

            db.SaveChanges();

            return Ok();
        }

        // DELETE: api/Tournaments/5
        [ResponseType(typeof(Tournament))]
        public IHttpActionResult DeleteTournament(long id)
        {
            Tournament tournament = db.Tournaments.Find(id);
            if (tournament == null)
            {
                return NotFound();
            }

            db.Tournaments.Remove(tournament);
            db.SaveChanges();

            return Ok(tournament);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TournamentExists(long id)
        {
            return db.Tournaments.Count(e => e.Id == id) > 0;
        }
    }
}