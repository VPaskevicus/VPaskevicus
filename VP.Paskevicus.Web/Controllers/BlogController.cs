using Microsoft.AspNetCore.Mvc;

namespace VP.Paskevicus.Web.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}