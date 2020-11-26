using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WSEIWebApp.Web.Models;

namespace WSEIWebApp.Web.Controllers
{
    public class AddItemController : Controller
    {
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
