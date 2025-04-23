using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents.LayOutViewComponents
{
    public class _LayoutNavBarComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            //buranın viewında list tanımlaması yapmışsın ama burada göndermemişsin veriyi
            var values = context.ToDoLists.ToList();
            return View(values);
        }
    }
}
