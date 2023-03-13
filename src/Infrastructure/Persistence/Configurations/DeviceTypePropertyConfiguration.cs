using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    internal sealed class DeviceTypePropertyConfiguration : IEntityTypeConfiguration<DeviceTypeProperty>
    {
        public void Configure(EntityTypeBuilder<DeviceTypeProperty> builder)
        {
            builder.ToTable("DeviceTypeProperties");

            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);

            builder.HasOne(x => x.DeviceType)
                .WithMany(x => x.DeviceTypeProperties)
                .HasForeignKey(x => x.DeviceTypeId)
                .HasConstraintName("FK_DeviceTypeProperties_DeviceTypes_DeviceTypeId");

            builder.HasIndex(x => new { x.DeviceTypeId, x.Name })
                .IsUnique()
                .HasDatabaseName("IX_DeviceTypeProperties_DeviceTypeId_Name");
        }
    }
}
