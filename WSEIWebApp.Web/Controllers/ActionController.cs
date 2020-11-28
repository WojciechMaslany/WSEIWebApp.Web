using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WSEIWebApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using WSEIWebApp.Web.Database;
using WSEIWebApp.Web.Entities;

namespace WSEIWebApp.Web.Controllers
{
    [ApiController]
    [Route("api/ActionController")]
    public class ActionController : ControllerBase
    {
        private readonly ExchangesDbContext _dbContext;
        public ActionController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpPost]
        public AddNewItemResponseModel Post(ItemModel item)
        {
            var entity = new ItemEntity
            {
                Name = item.Name,
                Description = item.Description,
                IsVisible = item.IsVisible,

            };
            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();

            return new AddNewItemResponseModel
            {
                Message = $"{item.Name} was added",
                Success = true
            };
        }    
    }
}

