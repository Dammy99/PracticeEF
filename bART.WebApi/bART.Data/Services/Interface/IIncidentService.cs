using bART.Data.Dto;
using bART.Data.Entities;

namespace bART.Data.Services.Interface
{
    public interface IIncidentService
    {
        Task<IReadOnlyList<Incident>> GetAllIncidentsAsync();
        Task CreateIncidentAsync(IncidentDTO incident);
        bool IsPossible(IncidentDTO incident);
    }
}
