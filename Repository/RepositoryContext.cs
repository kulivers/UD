using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class RepositoryContext : DbContext
{
 
    //Add this later
    // public DbSet<Company> Companies { get; set; }
    // public DbSet<Customer> Customers { get; set; }
    // public DbSet<Item> Items { get; set; }
    // public DbSet<Order> Orders { get; set; }


    public DbSet<MockCompany>? Companies { get; set; }
    public DbSet<MockEmployee>? Employees { get; set; }

    public RepositoryContext()
    {
    }

    public RepositoryContext(DbContextOptions options) : base(options)
    {
    }
}
