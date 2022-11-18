using System.Web;
using System.Web.Mvc;

namespace NewsPortal_MVC_AppLayer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
