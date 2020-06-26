using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace YKT.RubberTraceSystem.WebService.Controllers
{
    public class WorkFieldController : ApiController
    {
        // GET: api/WorkField
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/WorkField/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/WorkField
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/WorkField/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/WorkField/5
        public void Delete(int id)
        {
        }
    }
}
