using ASP.NET_Core_Testing.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_Testing.Data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
    {

    }

    public DbSet<Category> Categories { get; set;  }
  }
}
