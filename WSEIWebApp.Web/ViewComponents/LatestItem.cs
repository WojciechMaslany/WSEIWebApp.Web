using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WSEIWebApp.Web.Database;

namespace WSEIWebApp.Web.ViewComponents
{
    public class LatestItem : ViewComponent
    {
        private readonly ExchangesDbContext _dbContext;

        public LatestItem(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            var latestItem = _dbContext.Items
                .OrderByDescending(x => x.Id).First();

            return View(latestItem);
        }
    }
}

// WHY IS IT NOT LOADING????
