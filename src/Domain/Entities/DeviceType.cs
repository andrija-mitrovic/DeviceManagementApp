using Domain.Common;

namespace Domain.Entities
{
    public sealed class DeviceType : BaseEntity<int>
    {
        public string? Name { get; set; }
        public DeviceType? Parent { get; set; }
        public int? ParentId { get; set; }
        public ICollection<DeviceType>? Children { get; set; }
        public ICollection<Device>? Devices { get; set; }
        public ICollection<DeviceTypeProperty>? DeviceTypeProperties { get; set; }
    }
}
