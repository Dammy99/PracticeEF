using AutoMapper;
using bART.Data.Context;
using bART.Data.Dto;
using bART.Data.Entities;
using bART.Data.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace bART.Data.Services.Implementation
{
    public class IncidentService : IIncidentService
    {
        private readonly IBartContext _context;
        private readonly IMapper _mapper;

        public IncidentService(IBartContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<Incident>> GetAllIncidentsAsync()
        {
            var allNotes = _context.Incidents
                .Include(x => x.Accounts).ThenInclude(y => y.Contacts);
            return await allNotes.ToListAsync();
        }

        public async Task CreateIncidentAsync(IncidentDTO incident)
        {
            var incidentInfo = _mapper.Map<Incident>(incident);
            incidentInfo.IncidentName = string.Join('_', incidentInfo.Accounts.Select(x => x.AccountName));
            await _context.Incidents.AddAsync(incidentInfo);
        }
        public bool IsPossible(IncidentDTO incident)
        {
            var incidentInfo = _mapper.Map<Incident>(incident);

            var storedAccounts = _context.Accounts.Select(y => y.AccountName).AsEnumerable();
            var enteredAccounts = incidentInfo.Accounts.Select(x => x.AccountName).AsEnumerable();

            if (enteredAccounts.Except(storedAccounts).Any() == true)
            {
                return false;
            }
            else
            {
                foreach (var t in enteredAccounts)
                {
                    var acInfo = new Account { AccountName = t };
                    _context.Accounts.Remove(acInfo);
                }
                return true;
            }
        }

    }
}
