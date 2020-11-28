using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WSEIWebApp.Web.Models;
using WSEIWebApp.Web.Entities;
using WSEIWebApp.Web.Database;

namespace WSEIWebApp.Web.Controllers
{
    public class AddItemController : Controller
    {
        private readonly ExchangesDbContext _dbContext;
        public AddItemController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult ShowItems()
        {
            var items = _dbContext.Items.ToArray<ItemEntity>();

            return View("~/Views/Items/ShowItems.cshtml", items);
        }
        [HttpGet]
        public IActionResult AddItem()
        {
            return View("~/Views/Items/AddItem.cshtml");
        }

        [HttpPost]
        public IActionResult AddItem(ItemModel item)
        {
            return RedirectToAction("AddConfirmation");
        }

        [HttpGet]
        public IActionResult AddConfirmation()
        {
            return View("~/Views/Items/AddConfirmation.cshtml");
        }
    }
}
