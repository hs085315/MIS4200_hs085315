using System.Web;
using System.Web.Mvc;

namespace MIS4200_hs085315
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
