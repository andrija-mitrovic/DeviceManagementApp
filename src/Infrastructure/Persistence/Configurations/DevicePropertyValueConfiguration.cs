using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    internal sealed class DevicePropertyValueConfiguration : IEntityTypeConfiguration<DevicePropertyValue>
    {
        public void Configure(EntityTypeBuilder<DevicePropertyValue> builder)
        {
            builder.ToTable("DevicePropertyValues");

            builder.Property(x => x.Value).IsRequired();

            builder.HasOne(x => x.Device)
                .WithMany(x => x.DevicePropertyValues)
                .HasForeignKey(x => x.DeviceId)
                .HasConstraintName("FK_DevicePropertyValues_Devices_DeviceId");

            builder.HasOne(x => x.DeviceTypeProperty)
                .WithOne(x => x.DevicePropertyValue)
                .HasForeignKey<DevicePropertyValue>(x => x.DeviceTypePropertyId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_DevicePropertyValues_DeviceTypeProperties_DeviceTypePropertyId");
        }
    }
}
