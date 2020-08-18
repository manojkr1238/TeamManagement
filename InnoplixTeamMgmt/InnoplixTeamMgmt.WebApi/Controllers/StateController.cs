using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InnoplixTeamMgmt.Data.Model;
using InnoplixTeamMgmt.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InnoplixTeamMgmt.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public StateController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult GetAllStates()
        {
            var states = _unitOfWork.GetRepository<State>().GetAll();
            return Ok(states);
        }
    }
}
