using AutoMapper;
using DTO.DTOs.CourseCategoryDtos;
using Entity.Entities;

namespace WebApi.Mapping
{
    public class CourseCategoryMapping : Profile
    {
        public CourseCategoryMapping()
        {
            CreateMap<CreateCourseCategoryDto, CourseCategory>().ReverseMap();
            CreateMap<UpdateCourseCategoryDto, CourseCategory>().ReverseMap();
            CreateMap<ResultCourseCategoryDto, CourseCategory>().ReverseMap();
        }
    }
}
