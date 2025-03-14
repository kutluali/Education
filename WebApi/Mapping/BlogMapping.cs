using AutoMapper;
using DTO.DTOs.BlogDtos;
using Entity.Entities;

namespace WebApi.Mapping
{
    public class BlogMapping : Profile
    {
        public BlogMapping()
        {
            CreateMap<CreateBlogDto, Blog>().ReverseMap();
            CreateMap<UpdateBlogDto, Blog>().ReverseMap();
            CreateMap<Blog, ResultBlogDto>().ReverseMap();
        }
    }
}
