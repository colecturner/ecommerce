using System.Collections.Generic;
using ecom.database.model;
using ecom.Repository;
using ecom.database.context;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

class ItemRepository : IItemRepository
{
    private readonly MySqlDbContext _mySqlDb;
    public ItemRepository(MySqlDbContext mySqlDbContext)
    {
        _mySqlDb = mySqlDbContext;
    }

    public async Task CreateItem(Item createdItem)
    {
        await _mySqlDb.Items.AddAsync(createdItem);
        await _mySqlDb.SaveChangesAsync();

    }

    public async Task<List<Item>> GetItems()
    {
        return await _mySqlDb.Items.ToListAsync();
    }
}