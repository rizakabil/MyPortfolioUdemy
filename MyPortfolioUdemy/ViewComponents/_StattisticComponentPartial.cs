﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _StattisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
        return View();
        }

    }
}
