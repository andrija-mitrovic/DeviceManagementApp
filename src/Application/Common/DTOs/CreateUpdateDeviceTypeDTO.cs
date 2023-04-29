using MediatR;

namespace Application.Common.DTOs
{
    public sealed record CreateUpdateDeviceTypeDTO(
        int Id, 
        string Name, 
        int ParentId, 
        CreateUpdateDeviceTypePropertyDTO DeviceTypeProperty) : IRequest<int>;
}
