using System.Collections.Generic;
using System.Threading.Tasks;
using ecom.database.model;

namespace ecom.Repository 
{
public interface IItemRepository 
{
    Task<List<Item>> GetItems();
    Task CreateItem(Item createdItem);
}
}