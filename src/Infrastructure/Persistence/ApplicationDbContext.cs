using CliDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CliDemo.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Person> Person { get; set; }

    public virtual DbSet<EstadoDelPedido> EstadoDelPedido { get; set; }
    public virtual DbSet<Pedidos> Pedidos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }
}
