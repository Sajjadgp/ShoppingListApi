using Microsoft.EntityFrameworkCore;

namespace ShoppingListApi.Models;

public class ShppingListContext : DbContext
{
    public ShppingListContext(DbContextOptions<ShppingListContext> options) :base(options)
    {
        
    }
    public DbSet<Grocery> Groceries { get; set; }
}