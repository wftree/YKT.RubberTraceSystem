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
    public class 帘布入库Controller : ApiController
    {
        private Entities db = new Entities();

        // GET: api/帘布入库
        public IQueryable<帘布入库> Get帘布入库()
        {
            return db.帘布入库;
        }

        // GET: api/帘布入库/5
        [ResponseType(typeof(帘布入库))]
        public IHttpActionResult Get帘布入库(Guid id)
        {
            帘布入库 帘布入库 = db.帘布入库.Find(id);
            if (帘布入库 == null)
            {
                return NotFound();
            }

            return Ok(帘布入库);
        }

        // PUT: api/帘布入库/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put帘布入库(Guid id, 帘布入库 帘布入库)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != 帘布入库.Id)
            {
                return BadRequest();
            }

            db.Entry(帘布入库).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!帘布入库Exists(id))
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

        // POST: api/帘布入库
        [ResponseType(typeof(帘布入库))]
        public IHttpActionResult Post帘布入库(帘布入库 帘布入库)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.帘布入库.Add(帘布入库);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (帘布入库Exists(帘布入库.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = 帘布入库.Id }, 帘布入库);
        }

        // DELETE: api/帘布入库/5
        //[ResponseType(typeof(帘布入库))]
        //public IHttpActionResult Delete帘布入库(Guid id)
        //{
        //    帘布入库 帘布入库 = db.帘布入库.Find(id);
        //    if (帘布入库 == null)
        //    {
        //        return NotFound();
        //    }

        //    db.帘布入库.Remove(帘布入库);
        //    db.SaveChanges();

        //    return Ok(帘布入库);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool 帘布入库Exists(Guid id)
        {
            return db.帘布入库.Count(e => e.Id == id) > 0;
        }
    }
}