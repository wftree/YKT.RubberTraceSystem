using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebGrease;
using YKT.RubberTraceSystem.Data;

namespace YKT.RubberTraceSystem.WebAPI.Controllers
{
    public class SummaryController : ApiController
    {

        private DataDataContext db = new DataDataContext();
        // GET: api/Summary/5
        public List<string[]> GetAll(Guid id)
        {
            var rc = from m in db.橡胶薄片s where m.删除 == false && m.作业员== id && m.生产时间.Value.Date == DateTime.Now.Date select m;
            var fc = from m in db.帘布流转s where m.删除 == false && m.作业员 == id && m.生产时间.Date == DateTime.Now.Date select m; 
            var np = from m in db.皮囊成型s where m.删除 == false && m.作业员 == id && m.生产时间.Value.Date == DateTime.Now.Date select m; 
            var cp = from m in db.皮囊硫化s where m.删除 == false && m.作业员 == id && m.生产时间.Value.Date == DateTime.Now.Date select m; 

            List<string[]> temp = new List<string[]>();
            foreach (var item in rc)
            {
                temp.Add(new string[] { "胶片：" + db.胶料入库s.Single(x=>x.Id ==item.胶料批号 && x.删除 == false).胶料牌号, "厚：" + item.厚度 + " 宽：" + item.宽度 });
            }
            foreach (var item in fc)
            {
                temp.Add(new string[] { "帘布：" + item.产品编号, "厚：" + item.厚度 + " 宽：" + item.宽度+" 角度："+ item.角度 });
            }
            foreach (var item in np)
            {
                temp.Add(new string[] { "成型：" + item.产品型号, "生产时间：" + item.生产时间.Value.ToShortDateString()});
            }
            foreach (var item in cp)
            {
                temp.Add(new string[] { "硫化：" + item.产品型号, "生产时间：" + item.生产时间.Value.ToShortDateString() });
            }
            return temp;
        }

        
    }
}
