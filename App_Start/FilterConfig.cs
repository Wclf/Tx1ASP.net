using System.Web;
using System.Web.Mvc;

namespace KT1_BuiQuangThang_2021600262
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
