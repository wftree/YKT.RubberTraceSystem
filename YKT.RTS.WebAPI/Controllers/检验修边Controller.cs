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
    public class 检验修边Controller : ApiController
    {
        private Entities db = new Entities();

        // GET: api/检验修边
        public IQueryable<检验修边> Get检验修边()
        {
            return db.检验修边;
        }

        // GET: api/检验修边/5
        [ResponseType(typeof(检验修边))]
        public IHttpActionResult Get检验修边(Guid id)
        {
            检验修边 检验修边 = db.检验修边.Find(id);
            if (检验修边 == null)
            {
                return NotFound();
            }

            return Ok(检验修边);
        }

        // PUT: api/检验修边/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put检验修边(Guid id, 检验修边 检验修边)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != 检验修边.Id)
            {
                return BadRequest();
            }

            db.Entry(检验修边).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!检验修边Exists(id))
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

        // POST: api/检验修边
        [ResponseType(typeof(检验修边))]
        public IHttpActionResult Post检验修边(检验修边 检验修边)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.检验修边.Add(检验修边);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (检验修边Exists(检验修边.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = 检验修边.Id }, 检验修边);
        }

        // DELETE: api/检验修边/5
        //[ResponseType(typeof(检验修边))]
        //public IHttpActionResult Delete检验修边(Guid id)
        //{
        //    检验修边 检验修边 = db.检验修边.Find(id);
        //    if (检验修边 == null)
        //    {
        //        return NotFound();
        //    }

        //    db.检验修边.Remove(检验修边);
        //    db.SaveChanges();

        //    return Ok(检验修边);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool 检验修边Exists(Guid id)
        {
            return db.检验修边.Count(e => e.Id == id) > 0;
        }
    }
}