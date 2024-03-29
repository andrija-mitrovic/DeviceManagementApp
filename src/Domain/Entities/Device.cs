﻿using Domain.Common;

namespace Domain.Entities
{
    public sealed class Device : BaseEntity<int>
    {
        public string? Name { get; set; }
        public DeviceType? DeviceType { get; set; }
        public int DeviceTypeId { get; set; }
        public ICollection<DevicePropertyValue>? DevicePropertyValues { get; set; }
    }
}
