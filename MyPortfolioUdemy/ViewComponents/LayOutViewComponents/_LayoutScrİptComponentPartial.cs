using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.ViewComponents.LayOutViewComponents
{
    public class _LayoutScrİptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
                    return View();
        }
    }
}
