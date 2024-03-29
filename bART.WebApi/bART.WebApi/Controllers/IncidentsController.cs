﻿using bART.Data.Context;
using bART.Data.Dto;
using bART.Data.Services.Interface;
using Microsoft.AspNetCore.Mvc;

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
        [HttpPost("createIncident(StepByStep)")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CreateIncident(IncidentDTO incident)
        {

            if (_incidentService.IsPossible(incident) == false)
            {
                return NotFound();
            }
            else
            {
                await _incidentService.CreateIncidentAsync(incident);
                await _context.SaveChangesAsync();
                return Ok();
            }
        }
    }
}
