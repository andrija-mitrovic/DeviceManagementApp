using Application.Common.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Common.Mappings
{
    public sealed class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // DeviceType mapping
            CreateMap<DeviceType, CreateUpdateDeviceTypeDTO>();
            
            // DeviceTypeProperty mapping
            CreateMap<DeviceTypeProperty, CreateUpdateDeviceTypePropertyDTO>();
        }
    }
}
