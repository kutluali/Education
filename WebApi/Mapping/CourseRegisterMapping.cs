using AutoMapper;
using DTO.DTOs.CourseRegisterDtos;
using Entity.Entities;

namespace WebApi.Mapping
{
    public class CourseRegisterMapping : Profile
    {
        public CourseRegisterMapping()
        {
            CreateMap<CourseRegister, ResultCourseRegisterDto>().ReverseMap();
            CreateMap<CourseRegister, CreateCourseRegisterDto>().ReverseMap();
            CreateMap<CourseRegister, UpdateCourseRegisterDto>().ReverseMap();
        }
    }
}
