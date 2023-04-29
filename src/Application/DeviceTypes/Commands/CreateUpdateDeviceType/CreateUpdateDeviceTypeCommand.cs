using Application.Common.DTOs;
using MediatR;

namespace Application.DeviceTypes.Commands.CreateUpdateDeviceType
{
    public sealed record CreateUpdateDeviceTypeCommand(CreateUpdateDeviceTypeDTO DeviceType) : IRequest<int>;
}
