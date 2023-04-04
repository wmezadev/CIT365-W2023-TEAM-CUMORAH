using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Controllers
{
    public class SpeechesController : Controller
    {
        private readonly SacramentMeetingPlannerContext _context;

        public SpeechesController(SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        // GET: Speeches
        public async Task<IActionResult> Index(string speakerSubject)
        {

            if (_context.Planner == null)
            {
                return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
            }

            var speaches = from m in _context.Speach.Include(s => s.Planner).Include(s => s.SpeachTopic).Include(s => s.Speaker)
                           select m;

            if (!String.IsNullOrEmpty(speakerSubject))
            {
                speaches = speaches.Where(s => s.Speaker.FullName.Contains(speakerSubject));
            }

            return View(await speaches.ToListAsync());
        }

        // GET: Speeches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Speach == null)
            {
                return NotFound();
            }

            var speach = await _context.Speach
                .Include(s => s.Planner)
                .Include(s => s.SpeachTopic)
                .Include(s => s.Speaker)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (speach == null)
            {
                return NotFound();
            }

            return View(speach);
        }

    }
}
