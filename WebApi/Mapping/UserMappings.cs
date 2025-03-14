using AutoMapper;
using DTO.DTOs.RoleDtos;
using DTO.DTOs.UserDtos;
using Entity.Entities;

namespace WebApi.Mapping
{
    public class UserMappings : Profile
    {
        public UserMappings()
        {
            CreateMap<AppUser, RegisterDto>().ReverseMap();

            CreateMap<AppRole, CreateRoleDto>().ReverseMap();
            CreateMap<AppRole, UpdateRoleDto>().ReverseMap();
            CreateMap<AppUser, ResultUserDto>().ReverseMap();

        }
    }
}
