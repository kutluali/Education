using AutoMapper;
using DTO.DTOs.BlogCategoryDtos;
using Entity.Entities;

namespace WebApi.Mapping
{
    public class BlogCategoryMapping : Profile
    {
        public BlogCategoryMapping()
        {
            CreateMap<CreateBlogCategoryDto, BlogCategory>().ReverseMap();
            CreateMap<UpdateBlogCategoryDto, BlogCategory>().ReverseMap();
            CreateMap<ResultBlogCategoryDto, BlogCategory>().ReverseMap();
        }
    }
}
