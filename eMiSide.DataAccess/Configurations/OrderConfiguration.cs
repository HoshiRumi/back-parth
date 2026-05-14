using eDomain.mEntities.mOrder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eMiSide.DataAccess.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<OrderData>
    {
        public void Configure(EntityTypeBuilder<OrderData> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.TotalPrice).HasColumnType("decimal(18,2)");
            builder.HasMany(o => o.Items)
                .WithOne()
                .HasForeignKey(i => i.OrderId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}