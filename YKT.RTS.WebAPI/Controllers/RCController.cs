using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using YKT.RubberTraceSystem.Data;

namespace YKT.RubberTraceSystem.WebAPI.Controllers
{
    public class RCController : ApiController
    {
        private DataDataContext db = new DataDataContext();
        [ResponseType(typeof(橡胶薄片))]
        public IHttpActionResult GetRC(Guid id,Guid lb)
        {

            橡胶薄片 橡胶薄片 = db.橡胶薄片s.Single<橡胶薄片>(x => x.Id == id && x.删除 == false);


            if (橡胶薄片 == null)
            {
                return NotFound();
            }
            橡胶薄片.作业员 = lb;
            橡胶薄片.生产时间 = DateTime.Now;
            db.SubmitChanges();

            return Ok(橡胶薄片);
        }
    }
}
