using System.Web;
using System.Web.Mvc;

namespace ZCSS_SDvpt_Orientation_Test
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
