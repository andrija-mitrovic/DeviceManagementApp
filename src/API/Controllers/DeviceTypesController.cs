using Application.Common.DTOs;
using Application.DeviceTypes.Commands.CreateUpdateDeviceType;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public sealed class DeviceTypesController : ApiControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<int>> CreateUpdateDeviceType([FromBody] CreateUpdateDeviceTypeDTO createUpdateDeviceTypeDTO, CancellationToken cancellationToken)
        {
            var deviceType = await Mediator.Send(new CreateUpdateDeviceTypeCommand(createUpdateDeviceTypeDTO), cancellationToken);

            return CreatedAtRoute("GetDeviceType", new { id = deviceType }, deviceType);
        }
    }
}
