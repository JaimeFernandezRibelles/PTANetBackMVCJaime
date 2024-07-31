using Alicunde.Domain.Abstractions;
using Alicunde.Domain.Entities.Fees;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace Alicunde.Infraestructure;

public sealed class AlicundeDbContext : DbContext, IUnitOfWork
{
    public DbSet<Fee> Fees { get; set; }

    public AlicundeDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(AlicundeDbContext).Assembly);

        base.OnModelCreating(builder);
    }
}