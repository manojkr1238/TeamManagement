using InnoplixTeamMgmt.Data.Model;
using InnoplixTeamMgmt.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace InnoplixTeamMgmt.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin", "*", "*")]
    public class ListBookController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ListBookController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProspects()
        {
            var prospects = await _unitOfWork.GetRepository<Prospect>().GetAllAsync();
            return Ok(prospects);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> FindStateById(int id)
        {
            var prospect = await _unitOfWork.GetRepository<Prospect>().FindAsync(s => s.Id == id);
            if (prospect == null)
            {
                return NotFound();
            }
            return Ok(prospect);
        }
    }
}
