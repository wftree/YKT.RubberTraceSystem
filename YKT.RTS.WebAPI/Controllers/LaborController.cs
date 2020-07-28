using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using YKT.RubberTraceSystem.Data;

namespace YKT.RubberTraceSystem.WebAPI.Controllers
{
    public class LaborController : ApiController
    {
        //private Entities db = new Entities();
        DataDataContext ddc = new DataDataContext();
        // GET: api/员工
        //public IQueryable<员工> Get员工()
        //{
        //    //员工 temp = new 员工();
        //    //temp.Id = new Guid();
        //    //temp.姓名 = "Test";
        //    //ObjectQuery<员工> list = new ObjectQuery<员工>(;
        //    //list.Add(temp);
        //    //return list;
        //    return db.员工;
        //}

        // GET: api/员工/5
        [ResponseType(typeof(员工))]
        public IHttpActionResult Get员工(Guid id)
        {

            员工 员工 = ddc.员工s.Single<员工>(x => x.Id == id && x.删除 ==false);
            //员工 员工 = db.员工.Find(id);
            //员工 员工 = new 员工();
            //员工.Id = new Guid();
            //员工.姓名 = "Test";
            if (员工 == null)
            {
                return NotFound();
            }

            return Ok(员工);
        }

        //// PUT: api/员工/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult Put员工(Guid id, 员工 员工)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != 员工.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(员工).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!员工Exists(id))
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

        //// POST: api/员工
        //[ResponseType(typeof(员工))]
        //public IHttpActionResult Post员工(员工 员工)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.员工.Add(员工);

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (员工Exists(员工.Id))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtRoute("DefaultApi", new { id = 员工.Id }, 员工);
        //}

        // DELETE: api/员工/5
        //[ResponseType(typeof(员工))]
        //public IHttpActionResult Delete员工(Guid id)
        //{
        //    员工 员工 = db.员工.Find(id);
        //    if (员工 == null)
        //    {
        //        return NotFound();
        //    }

        //    db.员工.Remove(员工);
        //    db.SaveChanges();

        //    return Ok(员工);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
                ddc.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool 员工Exists(Guid id)
        {
            //return db.员工.Count(e => e.Id == id) > 0;
            return ddc.员工s.Count(e => e.Id == id) > 0;
        }
    }
}