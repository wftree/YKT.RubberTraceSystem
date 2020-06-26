using System.Web;
using System.Web.Mvc;

namespace YKT.RubberTraceSystem.WebAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
