﻿using InnoplixTeamMgmt.Data.Model;
using InnoplixTeamMgmt.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace InnoplixTeamMgmt.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin", "*", "*")]
    public class StateController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public StateController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStates()
        {
            var states = await _unitOfWork.GetRepository<State>().GetAllAsync();
            return Ok(states);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> FindStateById(int id)
        {
            var state = await _unitOfWork.GetRepository<State>().FindAsync(s => s.Id == id);
            if(state == null)
            {
                return NotFound();
            }
            return Ok(state);
        }
    }
}
