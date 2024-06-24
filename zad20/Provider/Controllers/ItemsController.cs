using Microsoft.AspNetCore.Mvc;
using Provider;
using System.Collections.Generic;

namespace ProviderApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private static readonly List<Item> items = new List<Item>
        {
            new Item { Id = 1, Name = "Item 1", Description = "Description of Item 1" },
            new Item { Id = 2, Name = "Item 2", Description = "Description of Item 2" },
            new Item { Id = 3, Name = "Item 3", Description = "Description of Item 3" }
        };

        [HttpGet]
        public ActionResult<List<Item>> GetItems()
        {
            return items;
        }
    }
}