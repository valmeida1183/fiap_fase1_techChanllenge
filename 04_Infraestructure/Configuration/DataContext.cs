using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configuration;
public class DataContext : DbContext
{
    private readonly string? _connectionString;

    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Ddd> Ddds { get; set; }  

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);

        //Seed do banco de dados
        //modelBuilder.Seed();
    }
}
