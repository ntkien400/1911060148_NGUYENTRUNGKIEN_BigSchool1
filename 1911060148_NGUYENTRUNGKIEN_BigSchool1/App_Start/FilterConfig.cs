using System.Web;
using System.Web.Mvc;

namespace _1911060148_NGUYENTRUNGKIEN_BigSchool1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
