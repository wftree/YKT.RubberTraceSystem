using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using YKT.RubberTraceSystem.Data;

namespace YKT.RubberTraceSystem.WebAPI.Controllers
{
    public class MTController : ApiController
    {
        private DataDataContext db = new DataDataContext();
        // GET: api/MT
        public List<string> GetMT()
        {
            var temp = (from m in db.处理方法s
                       where m.删除 == false
                       select m.处理方法1.Trim()).ToList<string>();
            return temp;
        }

        //// GET: api/MT/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/MT
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/MT/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/MT/5
        //public void Delete(int id)
        //{
        //}
    }
}
