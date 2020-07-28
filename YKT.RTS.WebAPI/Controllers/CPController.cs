using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using YKT.RubberTraceSystem.Data;

namespace YKT.RubberTraceSystem.WebAPI.Controllers
{
    public class CPController : ApiController
    {
        private DataDataContext db = new DataDataContext();
        [ResponseType(typeof(皮囊硫化))]
        public IHttpActionResult GetCP(Guid id, Guid lb, Guid machine,float temp, float time)
        {

            皮囊成型 皮囊成型 = db.皮囊成型s.Single<皮囊成型>(x => x.Id == id && x.删除 == false);
            try
            {
                var n = db.皮囊硫化s.Single(x => x.删除 == false && x.成型皮囊 == id);
                n.硫化时间 = time;
                n.硫化温度 = temp;
                n.作业员 = lb;
                n.生产机台 = machine;
                db.SubmitChanges();
                return Ok(n);
            }
            catch (Exception)
            {

                //throw;
            }
            
            if (皮囊成型 == null)
            {
                return NotFound();
            }
            皮囊硫化 皮囊硫化 = new 皮囊硫化();
            皮囊硫化.Id = Guid.NewGuid();
            皮囊硫化.硫化时间 = time;
            皮囊硫化.硫化温度 = temp;
            皮囊硫化.作业员 = lb;
            皮囊硫化.生产时间 = DateTime.Now;
            皮囊硫化.登记时间 = DateTime.Now;
            皮囊硫化.生产机台 = machine;
            皮囊硫化.成型皮囊 = id;
            皮囊硫化.产品型号 = 皮囊成型.产品型号;
            db.皮囊硫化s.InsertOnSubmit(皮囊硫化);
            db.SubmitChanges();

            return Ok(皮囊硫化);
        }
    }
}
