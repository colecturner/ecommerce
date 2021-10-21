using System.Collections.Generic;
using ecom.database.model;
using ecom.Repository;
using ecom.database.context;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

class ItemService : IItemService
{
    private IItemRepository _iItemRepository;
    public ItemService(IItemRepository iItemRepository)
    {
        _iItemRepository = iItemRepository;
    }

    public async Task CreateItem(Item createdItem)
    {
        await _iItemRepository.CreateItem(createdItem);
    }

    public async Task<List<Item>> GetItems()
    {
        return await _iItemRepository.GetItems();
    }
}