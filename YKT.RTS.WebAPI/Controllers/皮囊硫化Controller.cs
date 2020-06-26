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
    public class 皮囊硫化Controller : ApiController
    {
        private Entities db = new Entities();

        // GET: api/皮囊硫化
        public IQueryable<皮囊硫化> Get皮囊硫化()
        {
            return db.皮囊硫化;
        }

        // GET: api/皮囊硫化/5
        [ResponseType(typeof(皮囊硫化))]
        public IHttpActionResult Get皮囊硫化(Guid id)
        {
            皮囊硫化 皮囊硫化 = db.皮囊硫化.Find(id);
            if (皮囊硫化 == null)
            {
                return NotFound();
            }

            return Ok(皮囊硫化);
        }

        // PUT: api/皮囊硫化/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put皮囊硫化(Guid id, 皮囊硫化 皮囊硫化)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != 皮囊硫化.Id)
            {
                return BadRequest();
            }

            db.Entry(皮囊硫化).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!皮囊硫化Exists(id))
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

        // POST: api/皮囊硫化
        [ResponseType(typeof(皮囊硫化))]
        public IHttpActionResult Post皮囊硫化(皮囊硫化 皮囊硫化)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.皮囊硫化.Add(皮囊硫化);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (皮囊硫化Exists(皮囊硫化.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = 皮囊硫化.Id }, 皮囊硫化);
        }

        // DELETE: api/皮囊硫化/5
        //[ResponseType(typeof(皮囊硫化))]
        //public IHttpActionResult Delete皮囊硫化(Guid id)
        //{
        //    皮囊硫化 皮囊硫化 = db.皮囊硫化.Find(id);
        //    if (皮囊硫化 == null)
        //    {
        //        return NotFound();
        //    }

        //    db.皮囊硫化.Remove(皮囊硫化);
        //    db.SaveChanges();

        //    return Ok(皮囊硫化);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool 皮囊硫化Exists(Guid id)
        {
            return db.皮囊硫化.Count(e => e.Id == id) > 0;
        }
    }
}