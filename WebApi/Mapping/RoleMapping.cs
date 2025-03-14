using AutoMapper;
using DTO.DTOs.RoleDtos;
using Entity.Entities;

namespace WebApi.Mapping
{
    public class RoleMapping : Profile
    {
        public RoleMapping()
        {
            CreateMap<AppRole, CreateRoleDto>().ReverseMap();
        }
    }
}
