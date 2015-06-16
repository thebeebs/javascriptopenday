using Microsoft.AspNet.Mvc;

namespace JavaScriptOpenDay.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
