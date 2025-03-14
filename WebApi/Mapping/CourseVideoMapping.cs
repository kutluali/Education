using AutoMapper;
using DTO.DTOs.CourseVideoDtos;
using Entity.Entities;

namespace WebApi.Mapping
{
    public class CourseVideoMapping : Profile
    {
        public CourseVideoMapping()
        {
            CreateMap<CourseVideo, CreateCourseVideoDto>().ReverseMap();
            CreateMap<CourseVideo, UpdateCourseVideoDto>().ReverseMap();
            CreateMap<CourseVideo, ResultCourseVideoDto>().ReverseMap();
        }
    }
}
