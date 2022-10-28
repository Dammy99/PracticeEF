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
        }
    }
}
