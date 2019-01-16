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
    public class PlayersController : ApiController
    {
        private AppDatabase db = new AppDatabase();

        // GET: api/Players
        public IQueryable<Player> GetPlayers()
        {
            return db.Players;
        }

        // GET: api/Players/5
        [ResponseType(typeof(Player))]
        public IHttpActionResult GetPlayer(string id)
        {
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return NotFound();
            }

            return Ok(player);
        }

        // PUT: api/Players/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPlayer(string id, Player player)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != player.fideid)
            {
                return BadRequest();
            }

            db.Entry(player).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerExists(id))
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

        /*  // POST: api/Players
          [ResponseType(typeof(Player))]
          public IHttpActionResult PostPlayer(Player player)
          {
              if (!ModelState.IsValid)
              {
                  return BadRequest(ModelState);
              }

              db.Players.Add(player);
              db.SaveChanges();

              return CreatedAtRoute("DefaultApi", new { id = player.fideid }, player);
          }*/


            public IHttpActionResult PostPlayer(JArray objData)
            {
                List<Player> lstItemDetails = new List<Player>();

                foreach (var item in objData)
                {
                    lstItemDetails.Add(item.ToObject<Player>());
                }

                foreach (Player itemDetail in lstItemDetails)
                {
                    db.Players.Add(itemDetail);
                }

                db.SaveChanges();

                return Ok();
            }

        // DELETE: api/Players/5
        [ResponseType(typeof(Player))]
        public IHttpActionResult DeletePlayer(string id)
        {
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return NotFound();
            }

            db.Players.Remove(player);
            db.SaveChanges();

            return Ok(player);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PlayerExists(string id)
        {
            return db.Players.Count(e => e.fideid == id) > 0;
        }
    }
}