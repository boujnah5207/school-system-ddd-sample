using System.Web.Mvc;
using SchoolSystem.Service;

namespace SchoolSystem.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SchoolService schoolService = new SchoolService();
            var result = schoolService.GetSchools();
            return View();
        }
    }
}
