using Microsoft.EntityFrameworkCore;
using ecom.database.model;

namespace ecom.database.context 
{
    public class MySqlDbContext : DbContext 
    {
        public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Item> Items {get; set; }
    }
}