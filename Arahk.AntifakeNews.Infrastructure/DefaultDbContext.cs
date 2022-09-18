using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Arahk.AntifakeNews.Infrastructure;
public class DefaultDbContext : DbContext
{
    public DbSet<UserDbEntity> Users { get; set; } = null!;
    public DbSet<ContentDbEntity> Contents { get; set; } = null!;

    public DefaultDbContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseInMemoryDatabase("Default");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}