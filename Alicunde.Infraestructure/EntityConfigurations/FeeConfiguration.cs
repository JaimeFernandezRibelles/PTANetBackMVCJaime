using Alicunde.Domain.Entities.Fees;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alicunde.Infraestructure.EntityConfigurations
{
    internal class FeeConfiguration : IEntityTypeConfiguration<Fee>
    {
        public void Configure(EntityTypeBuilder<Fee> builder)
        {
            builder.ToTable("Fees");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Country);

            builder.Property(x => x.HourlyImbalanceFee);

            builder.Property(x => x.ImbalanceFee);

            builder.Property(x => x.PeakLoadFee);

            builder.Property(x => x.Timestamp);

            builder.Property(x => x.TimestampUTC);

            builder.Property(x => x.VolumeFee);

            builder.Property(x => x.WeeklyFee);
        }
    }
}