using lawyer.api.appointments.datastore.mssql.Model;
using lawyer.api.appointments.datastore.mssql.Model.Common;
using Microsoft.EntityFrameworkCore;

namespace lawyer.api.appointments.datastore.mssql.DatabaseContext;

public class LawyersContext : DbContext
{
    public LawyersContext(DbContextOptions<LawyersContext> options) : base(options)
    {
    }

    public DbSet<ExampleEntity> Examples { get; set; }
    public DbSet<MeetingEntity> Meetings { get; set; }
    public DbSet<PaymentEntity> Payments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(LawyersContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in ChangeTracker.Entries<EFEntity>()
                     .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
        {
            entry.Entity.DateModified = DateTime.Now;
            if (entry.State == EntityState.Added) entry.Entity.DateCreated = DateTime.Now;
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}