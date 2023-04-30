using FluentValidation;

namespace Application.DeviceTypes.Commands.CreateUpdateDeviceType
{
    internal sealed class CreateUpdateDeviceTypeCommandValidator : AbstractValidator<CreateUpdateDeviceTypeCommand>
    {
        public CreateUpdateDeviceTypeCommandValidator()
        {
            RuleFor(x => x.DeviceType.Name).NotEmpty();
            RuleFor(x => x.DeviceType.DeviceTypeProperties).NotNull();
        }
    }
}
