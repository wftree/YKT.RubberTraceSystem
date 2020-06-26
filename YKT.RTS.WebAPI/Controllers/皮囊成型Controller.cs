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
using YKT.RubberTraceSystem.Data.Entity;

namespace YKT.RubberTraceSystem.WebAPI.Controllers
{
    public class 皮囊成型Controller : ApiController
    {
        private Entities db = new Entities();

        // GET: api/皮囊成型
        public IQueryable<皮囊成型> Get皮囊成型()
        {
            return db.皮囊成型;
        }

        // GET: api/皮囊成型/5
        [ResponseType(typeof(皮囊成型))]
        public IHttpActionResult Get皮囊成型(Guid id)
        {
            皮囊成型 皮囊成型 = db.皮囊成型.Find(id);
            if (皮囊成型 == null)
            {
                return NotFound();
            }

            return Ok(皮囊成型);
        }

        // PUT: api/皮囊成型/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put皮囊成型(Guid id, 皮囊成型 皮囊成型)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != 皮囊成型.Id)
            {
                return BadRequest();
            }

            db.Entry(皮囊成型).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!皮囊成型Exists(id))
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

        // POST: api/皮囊成型
        [ResponseType(typeof(皮囊成型))]
        public IHttpActionResult Post皮囊成型(皮囊成型 皮囊成型)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.皮囊成型.Add(皮囊成型);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (皮囊成型Exists(皮囊成型.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = 皮囊成型.Id }, 皮囊成型);
        }

        // DELETE: api/皮囊成型/5
        //[ResponseType(typeof(皮囊成型))]
        //public IHttpActionResult Delete皮囊成型(Guid id)
        //{
        //    皮囊成型 皮囊成型 = db.皮囊成型.Find(id);
        //    if (皮囊成型 == null)
        //    {
        //        return NotFound();
        //    }

        //    db.皮囊成型.Remove(皮囊成型);
        //    db.SaveChanges();

        //    return Ok(皮囊成型);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool 皮囊成型Exists(Guid id)
        {
            return db.皮囊成型.Count(e => e.Id == id) > 0;
        }
    }
}