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
    public class 帘布流转Controller : ApiController
    {
        private Entities db = new Entities();

        // GET: api/帘布流转
        public IQueryable<帘布流转> Get帘布流转()
        {
            return db.帘布流转;
        }

        // GET: api/帘布流转/5
        [ResponseType(typeof(帘布流转))]
        public IHttpActionResult Get帘布流转(Guid id)
        {
            帘布流转 帘布流转 = db.帘布流转.Find(id);
            if (帘布流转 == null)
            {
                return NotFound();
            }

            return Ok(帘布流转);
        }

        // PUT: api/帘布流转/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put帘布流转(Guid id, 帘布流转 帘布流转)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != 帘布流转.Id)
            {
                return BadRequest();
            }

            db.Entry(帘布流转).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!帘布流转Exists(id))
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

        // POST: api/帘布流转
        [ResponseType(typeof(帘布流转))]
        public IHttpActionResult Post帘布流转(帘布流转 帘布流转)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.帘布流转.Add(帘布流转);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (帘布流转Exists(帘布流转.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = 帘布流转.Id }, 帘布流转);
        }

        // DELETE: api/帘布流转/5
        //[ResponseType(typeof(帘布流转))]
        //public IHttpActionResult Delete帘布流转(Guid id)
        //{
        //    帘布流转 帘布流转 = db.帘布流转.Find(id);
        //    if (帘布流转 == null)
        //    {
        //        return NotFound();
        //    }

        //    db.帘布流转.Remove(帘布流转);
        //    db.SaveChanges();

        //    return Ok(帘布流转);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool 帘布流转Exists(Guid id)
        {
            return db.帘布流转.Count(e => e.Id == id) > 0;
        }
    }
}