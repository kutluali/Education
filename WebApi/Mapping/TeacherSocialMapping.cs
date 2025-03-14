using AutoMapper;
using DTO.DTOs.TeacherSocialDtos;
using Entity.Entities;

namespace WebApi.Mapping
{
    public class TeacherSocialMapping : Profile
    {
        public TeacherSocialMapping()
        {
            CreateMap<TeacherSocial, ResultTeacherSocialDto>().ReverseMap();
            CreateMap<TeacherSocial, CreateTeacherSocialDto>().ReverseMap();
            CreateMap<TeacherSocial, UpdateTeacherSocialDto>().ReverseMap();
        }
    }
}
