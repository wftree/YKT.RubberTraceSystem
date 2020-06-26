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
    public class 胶料入库Controller : ApiController
    {
        private Entities db = new Entities();

        // GET: api/胶料入库
        public IQueryable<胶料入库> Get胶料入库()
        {
            return db.胶料入库;
        }

        // GET: api/胶料入库/5
        [ResponseType(typeof(胶料入库))]
        public IHttpActionResult Get胶料入库(Guid id)
        {
            胶料入库 胶料入库 = db.胶料入库.Find(id);
            if (胶料入库 == null)
            {
                return NotFound();
            }

            return Ok(胶料入库);
        }

        // PUT: api/胶料入库/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put胶料入库(Guid id, 胶料入库 胶料入库)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != 胶料入库.Id)
            {
                return BadRequest();
            }

            db.Entry(胶料入库).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!胶料入库Exists(id))
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

        // POST: api/胶料入库
        [ResponseType(typeof(胶料入库))]
        public IHttpActionResult Post胶料入库(胶料入库 胶料入库)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.胶料入库.Add(胶料入库);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (胶料入库Exists(胶料入库.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = 胶料入库.Id }, 胶料入库);
        }

        // DELETE: api/胶料入库/5
        //[ResponseType(typeof(胶料入库))]
        //public IHttpActionResult Delete胶料入库(Guid id)
        //{
        //    胶料入库 胶料入库 = db.胶料入库.Find(id);
        //    if (胶料入库 == null)
        //    {
        //        return NotFound();
        //    }

        //    db.胶料入库.Remove(胶料入库);
        //    db.SaveChanges();

        //    return Ok(胶料入库);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool 胶料入库Exists(Guid id)
        {
            return db.胶料入库.Count(e => e.Id == id) > 0;
        }
    }
}