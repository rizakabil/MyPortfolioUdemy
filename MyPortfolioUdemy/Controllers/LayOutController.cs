using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.Controllers
{
    public class LayOutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
