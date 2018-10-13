using AutoMapper;
using sepbackend.Controllers.Resources;
using sepbackend.Core.Models;

namespace sepbackend.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {   
            //Domain to API resources
            CreateMap<Client, ClientResource>();
            CreateMap<Event, EventResource>();
            CreateMap<Preference, PreferenceResource>();
            CreateMap<User, UserResource>();
            CreateMap<Request, RequestResource>();

            //API resources to domain
            CreateMap<CreateClientResource, Client>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<CreateEventResource, Event>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<CreatePreferenceResource, Preference>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<CreateUserResource, User>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<CreateRequestResource, Request>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}