using System.Web;
using System.Web.Mvc;

namespace Aptech.MVC.FirstLesson
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
