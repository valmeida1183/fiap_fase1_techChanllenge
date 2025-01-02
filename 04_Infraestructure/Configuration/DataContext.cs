using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Persistence.Configuration.Extension;

namespace Persistence.Configuration;
public class DataContext : DbContext
{
    private readonly string? _connectionString;

    public DbSet<Contact> Contacts { get; set; }
    public DbSet<DirectDistanceDialing> DirectDistanceDialings { get; set; }  

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
                
        modelBuilder.Seed();
    }
}
