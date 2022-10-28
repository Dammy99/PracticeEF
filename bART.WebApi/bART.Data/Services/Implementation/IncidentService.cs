using AutoMapper;
using bART.Data.Context;
using bART.Data.Dto;
using bART.Data.Entities;
using bART.Data.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            return await allNotes.ToListAsync();
        }

        public async Task CreateIncidentAsync(IncidentDTO incident)
        {
            var incidentInfo = _mapper.Map<Incident>(incident);

            ////var temp = _context.Accounts.Find(oo => incidentInfo.Accounts))
            ////if (_context.Accounts.First(us => incidentInfo!.Accounts.Any(x => x.AccountName == us.AccountName)))
            ////{
            ////    incidentInfo = null;
            ////} 
            //var www = _context.Accounts.All(x => x.AccountName == incidentInfo.Accounts.Select(a => a.AccountName).ToString());
            ////var kkk = _context.Accounts.Where(x => x.AccountName == incidentInfo.Accounts.Where(a => a.AccountName));
            ////var ttt = _context.Accounts.Where(x => x.AccountName == incidentInfo.Accounts.Where(y => y.AccountName);
            //if (_context.Accounts.All(x => x.AccountName == incidentInfo.Accounts.Select(a => a.AccountName).ToString()) == false)
            //{
            //    incidentInfo = null;
            //}
            //else
            //{
            //await _context.Incidents.AddRangeAsync(incidentInfo);
            //await _context.Accounts.Remove(x=> incidentInfo.Accounts.Where());
            
            await _context.Incidents.AddAsync(incidentInfo);
            //}
        }
        public bool IsPossible(IncidentDTO incident)
        {
            var incidentInfo = _mapper.Map<Incident>(incident);

            var pp = _context.Accounts.Select(y => y.AccountName).AsEnumerable();
            var tt = incidentInfo.Accounts.Select(x => x.AccountName).AsEnumerable();

            //var status = serial_list.Except(serial_list_printed).Any();
            //var status = !tt.Except(pp).Any();

            if (tt.Except(pp).Any() == true)
            {
                return  false;
            }
            else
            {
                foreach (var t in tt)
                {
                    var acInfo = new Account { AccountName = t };
                    _context.Accounts.Remove(acInfo);
                }
                return true;
            }
        }

    }
}
