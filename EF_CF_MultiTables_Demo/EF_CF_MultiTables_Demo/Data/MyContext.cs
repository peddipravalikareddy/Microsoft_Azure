using EF_CF_MultiTables_Demo.Models;
using Microsoft.EntityFrameworkCore;
namespace EF_CF_MuliTables_demo.Data
{ 
public class MyContext : DbContext
{
    public MyContext(DbContextOptions<MyContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
}

}