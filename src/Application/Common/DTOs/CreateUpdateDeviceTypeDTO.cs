using MediatR;

namespace Application.Common.DTOs
{
    public sealed record CreateUpdateDeviceTypeDTO(
        int Id, 
        string Name, 
        int ParentId,
        List<CreateUpdateDeviceTypePropertyDTO> DeviceTypeProperties);
}
