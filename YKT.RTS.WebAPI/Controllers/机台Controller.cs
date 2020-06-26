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
    public class 机台Controller : ApiController
    {
        private Entities db = new Entities();

        // GET: api/机台
        public IQueryable<机台> Get机台()
        {
            return db.机台;
        }

        // GET: api/机台/5
        [ResponseType(typeof(机台))]
        public IHttpActionResult Get机台(Guid id)
        {
            机台 机台 = db.机台.Find(id);
            if (机台 == null)
            {
                return NotFound();
            }

            return Ok(机台);
        }

        // PUT: api/机台/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put机台(Guid id, 机台 机台)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != 机台.Id)
            {
                return BadRequest();
            }

            db.Entry(机台).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!机台Exists(id))
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

        // POST: api/机台
        [ResponseType(typeof(机台))]
        public IHttpActionResult Post机台(机台 机台)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.机台.Add(机台);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (机台Exists(机台.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = 机台.Id }, 机台);
        }

        // DELETE: api/机台/5
        //[ResponseType(typeof(机台))]
        //public IHttpActionResult Delete机台(Guid id)
        //{
        //    机台 机台 = db.机台.Find(id);
        //    if (机台 == null)
        //    {
        //        return NotFound();
        //    }

        //    db.机台.Remove(机台);
        //    db.SaveChanges();

        //    return Ok(机台);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool 机台Exists(Guid id)
        {
            return db.机台.Count(e => e.Id == id) > 0;
        }
    }
}