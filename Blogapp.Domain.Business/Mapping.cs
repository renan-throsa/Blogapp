using AutoMapper;
using Blogapp.Domain.Entities.Entiti;
using Blogapp.Domain.Entities.Entiti.DTOs;
using MongoDB.Bson;

namespace Blogapp.Domain.Services
{
    public class Mapping: Profile
    {
        public Mapping()
        {
            CreateMap<User, UserDTO>()
               .ForMember(dto => dto.Id, x => x.MapFrom(y => y.Id.ToString()))
               .ReverseMap();

            CreateMap<UserDTO, User>()
                .ForMember(user => user.Id, x => x.MapFrom(y => y.Id == null ? ObjectId.Empty : new ObjectId(y.Id)))
                .ReverseMap();

            CreateMap<Location, LocationDTO>().ReverseMap();

            
        }
    }
}
