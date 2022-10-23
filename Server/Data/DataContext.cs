using blazorsample02.Shared;
using Microsoft.EntityFrameworkCore;

namespace blazorsample02.Server.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
        
    public DbSet<Movies> Movie { get; set; }
}