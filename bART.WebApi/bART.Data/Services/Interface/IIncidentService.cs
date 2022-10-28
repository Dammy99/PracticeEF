using bART.Data.Dto;
using bART.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bART.Data.Services.Interface
{
    public interface IIncidentService
    {
        Task<IReadOnlyList<Incident>> GetAllIncidentsAsync();
        Task CreateIncidentAsync (IncidentDTO incident);
        bool IsPossible (IncidentDTO incident);
    }
}
