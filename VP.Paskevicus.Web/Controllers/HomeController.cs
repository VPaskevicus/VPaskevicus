using Microsoft.AspNetCore.Mvc;

namespace VP.Paskevicus.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Resume()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Feedback()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
