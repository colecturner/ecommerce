using System.Collections.Generic;
using System.Threading.Tasks;
using ecom.database.model;

namespace ecom.Repository 
{
public interface IItemService 
{
    Task CreateItem(Item createdItem);
    Task<List<Item>> GetItems();
    
}
}