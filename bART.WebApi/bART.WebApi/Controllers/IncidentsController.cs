using bART.Data.Context;
using bART.Data.Dto;
using bART.Data.Entities;
using bART.Data.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bART.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentsController : ControllerBase
    {
        private readonly BartContext _context;
        private readonly IIncidentService _incidentService;

        public IncidentsController(BartContext context, IIncidentService incidentService)
        {
            _context = context;
            _incidentService = incidentService;
        }
        [HttpGet]
        public async Task<IActionResult> GetIncidents()
        {
            var incidents = await _incidentService.GetAllIncidentsAsync();
            return Ok(incidents);
        }
        [HttpPost]
        public async Task<IActionResult> CreateIncident(IncidentDTO incident)
        {
            await _incidentService.CreateIncidentAsync(incident);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
