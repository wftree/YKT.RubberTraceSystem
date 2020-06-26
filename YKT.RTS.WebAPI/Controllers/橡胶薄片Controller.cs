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
    public class 橡胶薄片Controller : ApiController
    {
        private Entities db = new Entities();

        // GET: api/橡胶薄片
        public IQueryable<橡胶薄片> Get橡胶薄片()
        {
            return db.橡胶薄片;
        }

        // GET: api/橡胶薄片/5
        [ResponseType(typeof(橡胶薄片))]
        public IHttpActionResult Get橡胶薄片(Guid id)
        {
            橡胶薄片 橡胶薄片 = db.橡胶薄片.Find(id);
            if (橡胶薄片 == null)
            {
                return NotFound();
            }

            return Ok(橡胶薄片);
        }

        // PUT: api/橡胶薄片/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put橡胶薄片(Guid id, 橡胶薄片 橡胶薄片)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != 橡胶薄片.Id)
            {
                return BadRequest();
            }

            db.Entry(橡胶薄片).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!橡胶薄片Exists(id))
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

        // POST: api/橡胶薄片
        [ResponseType(typeof(橡胶薄片))]
        public IHttpActionResult Post橡胶薄片(橡胶薄片 橡胶薄片)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.橡胶薄片.Add(橡胶薄片);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (橡胶薄片Exists(橡胶薄片.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = 橡胶薄片.Id }, 橡胶薄片);
        }

        // DELETE: api/橡胶薄片/5
        //[ResponseType(typeof(橡胶薄片))]
        //public IHttpActionResult Delete橡胶薄片(Guid id)
        //{
        //    橡胶薄片 橡胶薄片 = db.橡胶薄片.Find(id);
        //    if (橡胶薄片 == null)
        //    {
        //        return NotFound();
        //    }

        //    db.橡胶薄片.Remove(橡胶薄片);
        //    db.SaveChanges();

        //    return Ok(橡胶薄片);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool 橡胶薄片Exists(Guid id)
        {
            return db.橡胶薄片.Count(e => e.Id == id) > 0;
        }
    }
}