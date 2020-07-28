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
    public class FCController : ApiController
    {
        private DataDataContext db = new DataDataContext();
        [ResponseType(typeof(帘布流转))]
        public IHttpActionResult GetFC(Guid id, Guid lb)
        {

            帘布流转 帘布流转 = db.帘布流转s.Single<帘布流转>(x => x.Id == id && x.删除 == false);


            if (帘布流转 == null)
            {
                return NotFound();
            }
            帘布流转.作业员 = lb;
            帘布流转.生产时间 = DateTime.Now;
            db.SubmitChanges();

            return Ok(帘布流转);
        }
    }
}
