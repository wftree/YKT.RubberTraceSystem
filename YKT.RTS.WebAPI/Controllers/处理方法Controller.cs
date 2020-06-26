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
    public class 处理方法Controller : ApiController
    {
        private Entities db = new Entities();

        // GET: api/处理方法
        public IQueryable<处理方法> Get处理方法()
        {
            return db.处理方法;
        }

        // GET: api/处理方法/5
        [ResponseType(typeof(处理方法))]
        public IHttpActionResult Get处理方法(Guid id)
        {
            处理方法 处理方法 = db.处理方法.Find(id);
            if (处理方法 == null)
            {
                return NotFound();
            }

            return Ok(处理方法);
        }

        // PUT: api/处理方法/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put处理方法(Guid id, 处理方法 处理方法)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != 处理方法.Id)
            {
                return BadRequest();
            }

            db.Entry(处理方法).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!处理方法Exists(id))
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

        // POST: api/处理方法
        [ResponseType(typeof(处理方法))]
        public IHttpActionResult Post处理方法(处理方法 处理方法)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.处理方法.Add(处理方法);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (处理方法Exists(处理方法.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = 处理方法.Id }, 处理方法);
        }

        // DELETE: api/处理方法/5
        //[ResponseType(typeof(处理方法))]
        //public IHttpActionResult Delete处理方法(Guid id)
        //{
        //    处理方法 处理方法 = db.处理方法.Find(id);
        //    if (处理方法 == null)
        //    {
        //        return NotFound();
        //    }

        //    db.处理方法.Remove(处理方法);
        //    db.SaveChanges();

        //    return Ok(处理方法);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool 处理方法Exists(Guid id)
        {
            return db.处理方法.Count(e => e.Id == id) > 0;
        }
    }
}