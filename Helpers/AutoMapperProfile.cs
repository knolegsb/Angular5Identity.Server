using Angular5Identity.Server.Dtos;
using Angular5Identity.Server.Entities;
using AutoMapper;

namespace Angular5Identity.Server.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}