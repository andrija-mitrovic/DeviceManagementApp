using Application.Common.Interfaces;
using Domain.Entities;

namespace Infrastructure.Persistence.Repositories
{
    internal sealed class DeviceTypePropertyRepository : GenericRepository<DeviceTypeProperty>, IDeviceTypePropertyRepository
    {
        public DeviceTypePropertyRepository(ApplicationDbContext context) : base(context) { }
    }
}
