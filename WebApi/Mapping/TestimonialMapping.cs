using AutoMapper;
using DTO.DTOs.TestimonialDtos;
using Entity.Entities;

namespace WebApi.Mapping
{
    public class TestimonialMapping : Profile
    {
        public TestimonialMapping()
        {
            CreateMap<CreateTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<UpdateTestimonialDto, Testimonial>().ReverseMap();
        }
    }
}
