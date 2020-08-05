using InnoplixTeamMgmt.Data;
using InnoplixTeamMgmt.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace InnoplixTeamMgmt.Controllers
{
    [Authorize]
    public class ProspectController : Controller
    {
        private readonly ILogger<ProspectController> _logger;
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProspectController(ILogger<ProspectController> logger, ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public async Task<ViewResult> List()
        {
            ViewBag.Title = "Prospect List"; 
            var prospects = await _dbContext.Prospects.ToListAsync();
            return View(prospects);
        }

        public async Task<ViewResult> Prospect(int? id = null)
        {
            var stateList = await _dbContext.States.ToListAsync();
            stateList.Insert(0, new State { Id = 0, Name = "Select State Name" });
            ViewBag.StateList = stateList;
           if (id.HasValue)
            {
                ViewBag.IsEdit = true;
                var prospect = await _dbContext.Prospects.FirstOrDefaultAsync(i => i.Id == id.Value);
                return View(prospect);
            }
           else
            {
                ViewBag.IsEdit = false;
            }

            return View();
        }

        [HttpPost]
        public async Task<ViewResult> Prospect(Prospect model)
        {
            ApplicationUser usr = await _userManager.GetUserAsync(HttpContext.User);
            model.ApplicationUser = usr;

            var stateList = await _dbContext.States.ToListAsync();
            stateList.Insert(0, new State { Id = 0, Name = "Select State Name" });
            ViewBag.StateList = stateList;

            if (ModelState.IsValid)
            {
                if (model.Id != 0)
                {
                    ViewBag.IsEdit = true;
                    var prospect = await _dbContext.Prospects.FirstOrDefaultAsync(i => i.Id == model.Id);
                    prospect.Name = model.Name;
                    _dbContext.SaveChanges();
                }
                else
                {
                    ViewBag.IsEdit = false;
                    model.ProspectStatus = ProspectStatus.New;
                    _dbContext.Prospects.Add(model);
                    _dbContext.SaveChanges();
                }
            }

            return View();
        }
    }
}