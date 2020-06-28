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
using YKT.RubberTraceSystem.Data;

namespace YKT.RubberTraceSystem.WebAPI.Controllers
{
    public class ClassTypeController : ApiController
    {
        private DataDataContext db = new DataDataContext();
        // GET: api/班别
        public IQueryable<班别> Get班别()
        {
            var temp = from m in db.班别s
                       where m.删除 == false
                       select m;
            return temp;
            
        }

        // GET: api/班别/5
        [ResponseType(typeof(班别))]
        public IHttpActionResult Get班别(Guid id)
        {
            班别 班别 = db.班别s.Single<班别>(x => x.删除 == false & x.Id == id);
            if (班别 == null)
            {
                return NotFound();
            }

            return Ok(班别);
        }

        //// PUT: api/班别/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult Put班别(Guid id, 班别 班别)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != 班别.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(班别).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!班别Exists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        // POST: api/班别
        //[ResponseType(typeof(班别))]
        //public IHttpActionResult Post班别(班别 班别)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.班别.Add(班别);

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (班别Exists(班别.Id))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtRoute("DefaultApi", new { id = 班别.Id }, 班别);
        //}

        // DELETE: api/班别/5
        //[ResponseType(typeof(班别))]
        //public IHttpActionResult Delete班别(Guid id)
        //{
        //    班别 班别 = db.班别.Find(id);
        //    if (班别 == null)
        //    {
        //        return NotFound();
        //    }

        //    db.班别.Remove(班别);
        //    db.SaveChanges();

        //    return Ok(班别);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool 班别Exists(Guid id)
        {
            return db.班别s.Count(e => e.Id == id) > 0;
        }
    }
}