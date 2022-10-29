using AutoMapper;
using bART.Data.Dto;
using bART.Data.Entities;

namespace bART.Data.MappingProfiles
{
    public class IncidentProfile: Profile
    {
        public IncidentProfile()
        {
            CreateMap<Incident, IncidentDTO>();
            CreateMap<Incident, IncidentDTO>().ReverseMap();

            CreateMap<Account, AccountDTO>();
            CreateMap<Account, AccountDTO>().ReverseMap();

            CreateMap<Account, Incident>();
            CreateMap<Account, Incident>().ReverseMap();

            CreateMap<Contact, ContactDTO>();
            CreateMap<Contact, ContactDTO>().ReverseMap();

            CreateMap<Account, AccountForIncidentDTO>();
            CreateMap<Account, AccountForIncidentDTO>().ReverseMap();
        }
    }
}
