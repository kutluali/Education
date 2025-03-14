using AutoMapper;
using DTO.DTOs.SubscriberDtos;
using Entity.Entities;

namespace WebApi.Mapping
{
    public class SubscriberMapping : Profile
    {
        public SubscriberMapping()
        {
            CreateMap<CreateSubscriberDto, Subscriber>().ReverseMap();
            CreateMap<UpdateSubscriberDto, Subscriber>().ReverseMap();
        }
    }
}
