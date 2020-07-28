using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using YKT.RubberTraceSystem.Data;

namespace YKT.RubberTraceSystem.WebAPI.Controllers
{
    public class CCController : ApiController
    {
        private DataDataContext db = new DataDataContext();
        [ResponseType(typeof(检验修边))]
        public IHttpActionResult GetCC(Guid id, Guid lb, bool pass, string mt)
        {

            皮囊硫化 皮囊硫化 = null;

            处理方法 处理方法 = null;
            try
            {
                皮囊硫化 = db.皮囊硫化s.Single<皮囊硫化>(x => x.成型皮囊 == id && x.删除 == false);
                处理方法 = db.处理方法s.FirstOrDefault(x => x.处理方法1.Contains(mt.Trim()) && x.删除 == false);
            }
            catch (Exception)
            {

                //throw;
            }


            if (皮囊硫化 == null)
            {
                return NotFound();
            }
            检验修边 检验修边 = new 检验修边();
            检验修边.Id = Guid.NewGuid();
            检验修边.检验员 = lb;
            检验修边.登记时间 = DateTime.Now;
            检验修边.结果 = pass;
            检验修边.硫化皮囊 = 皮囊硫化.Id;
            if (处理方法 != null)
                检验修边.处理方法 = 处理方法.Id;
            else
                检验修边.处理方法 = null;
            db.检验修边s.InsertOnSubmit(检验修边);
            db.SubmitChanges();

            return Ok(检验修边);
        }
    }
}
