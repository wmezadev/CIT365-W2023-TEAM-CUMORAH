using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Controllers
{
    public class PlannersController : Controller
    {
        private readonly SacramentMeetingPlannerContext _context;

        public PlannersController(SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        // GET: Planners
        public async Task<IActionResult> Index(string searchString)
        {
            if (_context.Planner == null)
            {
                return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
            }

            var planners = from m in _context.Planner
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                planners = planners.Where(s => s.SpeakerSubject!.Contains(searchString));
            }

            return View(await planners.ToListAsync());
        }

        // GET: Planners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Planner == null)
            {
                return NotFound();
            }

            var planner = await _context.Planner
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planner == null)
            {
                return NotFound();
            }

            return View(planner);
        }

        // GET: Planners/Create
        public IActionResult Create()
        {
            ViewBag.Speakers = _context.Speaker.ToList();
            ViewBag.SpeachTopics = _context.SpeachTopic.ToList();
            return View();
        }

        // POST: Planners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MeetingDate,PresideLeader,ConductingLeader,OpeningSong,OpeningPray,SacramentHymn,SpeakerSubject,ClosingSong,ClosingPray")] Planner planner, IFormCollection formData)
        {
            ViewBag.Speakers = _context.Speaker.ToList();
            ViewBag.SpeachTopics = _context.SpeachTopic.ToList();
            if (ModelState.IsValid)
            {
                _context.Add(planner);
                await _context.SaveChangesAsync();
                var speechesData = formData.Where(x => x.Key.StartsWith("Speeches"));
                var speeches = new List<Speach>();

                for (int i = 0; i < speechesData.Count() / 2; i++)
                {
                    string speakerIdKey = $"Speeches[{i}].SpeakerId";
                    string speachTopicIdKey = $"Speeches[{i}].SpeachTopicId";

                    if (formData.TryGetValue(speakerIdKey, out var speakerIdValue) && formData.TryGetValue(speachTopicIdKey, out var speachTopicIdValue))
                    {
                        int.TryParse(speakerIdValue, out int speakerId);
                        int.TryParse(speachTopicIdValue, out int speachTopicId);

                        var speech = new Speach
                        {
                            SpeakerId = speakerId,
                            SpeachTopicId = speachTopicId,
                            PlannerId = planner.Id
                        };
                        speeches.Add(speech);
                    }
                }

                foreach (var speech in speeches)
                {
                    _context.Add(speech);
                }

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(planner);
        }

        // GET: Planners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Planner == null)
            {
                return NotFound();
            }

            var planner = await _context.Planner.FindAsync(id);
            if (planner == null)
            {
                return NotFound();
            }
            ViewBag.Speakers = _context.Speaker.ToList();
            ViewBag.SpeachTopics = _context.SpeachTopic.ToList();
            return View(planner);
        }

        // POST: Planners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MeetingDate,PresideLeader,ConductingLeader,OpeningSong,OpeningPray,SacramentHymn,SpeakerSubject,ClosingSong,ClosingPray")] Planner planner)
        {
            if (id != planner.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlannerExists(planner.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Speakers = _context.Speaker.ToList();
            ViewBag.SpeachTopics = _context.SpeachTopic.ToList();
            return View(planner);
        }

        // GET: Planners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Planner == null)
            {
                return NotFound();
            }

            var planner = await _context.Planner
                .FirstOrDefaultAsync(m => m.Id == id);
            ViewBag.Speakers = _context.Speaker.ToList();
            ViewBag.SpeachTopics = _context.SpeachTopic.ToList();
            if (planner == null)
            {
                return NotFound();
            }

            return View(planner);
        }

        // POST: Planners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Planner == null)
            {
                return Problem("Entity set 'SacramentMeetingPlannerContext.Planner'  is null.");
            }
            var planner = await _context.Planner.FindAsync(id);
            ViewBag.Speakers = _context.Speaker.ToList();
            ViewBag.SpeachTopics = _context.SpeachTopic.ToList();
            if (planner != null)
            {
                _context.Planner.Remove(planner);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlannerExists(int id)
        {
          return (_context.Planner?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
