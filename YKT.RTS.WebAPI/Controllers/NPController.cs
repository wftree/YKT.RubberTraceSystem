using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using YKT.RubberTraceSystem.Data;

namespace YKT.RubberTraceSystem.WebAPI.Controllers
{
    public class NPController : ApiController
    {
        private DataDataContext db = new DataDataContext();
        [ResponseType(typeof(皮囊成型))]
        public IHttpActionResult GetNP(Guid id, Guid lb,Guid machine)
        {

            皮囊成型 皮囊成型 = db.皮囊成型s.Single<皮囊成型>(x => x.Id == id && x.删除 == false);


            if (皮囊成型 == null)
            {
                return NotFound();
            }
            皮囊成型.作业员 = lb;
            皮囊成型.生产时间 = DateTime.Now;
            皮囊成型.生产机台 = machine;
            db.SubmitChanges();

            return Ok(皮囊成型);
        }
    }
}
