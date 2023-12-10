using FullTrailning.Model;
using FullTrailning.Prestence.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FullTrailning.Prestence;

public class Context : DbContext
{
    public Context (DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Person> PersonInfos { get; set; }
    public DbSet<Job> JobInfos { get; set; }
}
