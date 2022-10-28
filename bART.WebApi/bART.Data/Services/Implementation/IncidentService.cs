using AutoMapper;
using bART.Data.Context;
using bART.Data.Dto;
using bART.Data.Entities;
using bART.Data.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bART.Data.Services.Implementation
{
    public class IncidentService: IIncidentService
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
                .Include(x => x.Accounts);
                //.Select(y => new Account
                //{
                //    AccountName = y.Accounts[0].AccountName,
                //    IncidentName = y.Accounts[0].IncidentName,
                //});
            return await allNotes.ToListAsync();
        }

        public async Task CreateIncidentAsync(IncidentDTO incident)
        {
            var incidentInfo = _mapper.Map<Incident>(incident);
            await _context.Incidents.AddAsync(incidentInfo);
        }
    }
}
