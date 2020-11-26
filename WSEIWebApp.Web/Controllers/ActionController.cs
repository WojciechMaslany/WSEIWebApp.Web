using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WSEIWebApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace WSEIWebApp.Web.Controllers
{
    [ApiController]
    [Route("api/ActionController")]
    public class ActionController : ControllerBase
    {

        [HttpPost]
        public AddNewItemResponseModel Post(ItemModel item)
        {
            return new AddNewItemResponseModel
            {
                Message = $"{item.Name} was added",
                Success = true
            };
        }    
    }
}

