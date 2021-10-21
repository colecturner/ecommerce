using System.Collections.Generic;
using System.Threading.Tasks;
using ecom.database.model;
using ecom.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ecom.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ItemController : ControllerBase
    {
        private IItemService _iItemService;

        public ItemController(IItemService iItemService)
        {
            _iItemService = iItemService;
        }
        [HttpPost]
        public async Task CreateItem([FromBody]Item createdItem)
        {
            await _iItemService.CreateItem(createdItem);
        }
        [HttpGet]
        public async Task<List<Item>> GetItems()
        {
            return await _iItemService.GetItems();
        }
    }
}