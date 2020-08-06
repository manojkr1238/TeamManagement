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
            var prospects = await _dbContext.Prospects.Include("State").ToListAsync();
            return View(prospects);
        }

        public async Task<ViewResult> Prospect(int? id = null, bool IsSuccess = false)
        {
            var stateList = await _dbContext.States.OrderBy(s => s.Name).ToListAsync();
            stateList.Insert(0, new State { Id = 0, Name = "Select State Name" });
            ViewBag.StateList = stateList;

            ViewBag.IsEdit = id.HasValue;
            ViewBag.Title = ViewBag.IsEdit ? "Edit Prospect" : "Create New Prospect";
            ViewBag.IsSuccess = IsSuccess;

            if (id.HasValue)
            {
                var prospect = await _dbContext.Prospects.FirstOrDefaultAsync(i => i.Id == id.Value);
                return View(prospect);
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Prospect(Prospect model)
        {
            ApplicationUser usr = await _userManager.GetUserAsync(HttpContext.User);
            model.ApplicationUser = usr;

            var stateList = await _dbContext.States.OrderBy(s => s.Name).ToListAsync();
            stateList.Insert(0, new State { Id = 0, Name = "Select State Name" });
            ViewBag.StateList = stateList;

            ViewBag.IsEdit = model.Id != 0;
            ViewBag.Title = ViewBag.IsEdit ? "Edit Prospect" : "Create New Prospect";
            ViewBag.IsSuccess = false;

            if (ModelState.IsValid)
            {
                if (model.Id != 0)
                {
                    var prospect = await _dbContext.Prospects.FirstOrDefaultAsync(i => i.Id == model.Id);
                    prospect.Name = model.Name;
                    prospect.Age = model.Age;
                    prospect.City = model.City;
                    prospect.StateId = model.StateId;
                    prospect.Relation = model.Name;
                    prospect.DegreeOfRelation = model.DegreeOfRelation;
                    prospect.MaritalStatus = model.MaritalStatus;
                    prospect.Mobile = model.Mobile;
                    prospect.Ocuupation = model.Ocuupation;
                    prospect.Profile = model.Profile;
                    prospect.ProspectType = model.ProspectType;
                    prospect.Remarks = model.Remarks;
                    prospect.ProspectStatus = model.ProspectStatus;
                    _dbContext.SaveChanges();

                    return RedirectToAction("List");
                }
                else
                {
                    model.ProspectStatus = ProspectStatus.New;
                    _dbContext.Prospects.Add(model);
                    _dbContext.SaveChanges();

                    if(model.Id > 0)
                    {
                        return RedirectToAction(nameof(Prospect), new { IsSuccess = true });
                    }
                }
            }

            return View();
        }
    }
}