using AutoMapper;
using DTO.DTOs.AboutDtos;
using Entity.Entities;

namespace WebApi.Mapping
{
    public class AboutMapping : Profile
    {

        public AboutMapping()
        {
            CreateMap<CreateAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
        }
    }
}
