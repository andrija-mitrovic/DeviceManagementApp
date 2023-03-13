using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    internal sealed class DeviceConfiguration : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.ToTable("Devices");

            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);

            builder.HasOne(x => x.DeviceType)
                .WithMany(x => x.Devices)
                .HasForeignKey(x => x.DeviceTypeId)
                .HasConstraintName("FK_Devices_DeviceTypes_DeviceTypeId");
        }
    }
}
