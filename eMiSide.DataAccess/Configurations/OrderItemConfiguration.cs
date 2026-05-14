using eDomain.mEntities.mOrder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eMiSide.DataAccess.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItemData>
    {
        public void Configure(EntityTypeBuilder<OrderItemData> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.UnitPrice).HasColumnType("decimal(18,2)");
        }
    }
}