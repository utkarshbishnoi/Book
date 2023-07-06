using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Book.BL;
using Book.DAL;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Book.Web.Controllers
{


    [Authorize]
    public class ReadingEventController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReadingEventController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ReadingEvent
        public async Task<IActionResult> Index()
        {
            var book = await _context.ReadingEvent.Where(x => x.CreatedBy == User.FindFirst(ClaimTypes.NameIdentifier).Value).ToListAsync();
            if (User.IsInRole("Admin"))
            {
                book = await _context.ReadingEvent.ToListAsync();
            }
            return View(book);
        }

        // GET: ReadingEvent/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var readingEvent = await _context.ReadingEvent
                .FirstOrDefaultAsync(m => m.Id == id);
            var eventCmnt = await _context.Comments.Where(m => m.EventId == id).ToListAsync();
            ViewBag.Cmnt = eventCmnt;

            if (readingEvent == null)
            {
                return NotFound();
            }

            return View(readingEvent);
        }
        public async Task<IActionResult> InvitedTo()
        {
            List<ReadingEvent> Invited = new List<ReadingEvent>();
            var readingEvent = await _context.ReadingEvent.ToListAsync();

            foreach (var item in readingEvent)
            {
                if (item.Invites != null)
                {
                    string[] emails = item.Invites.Split(',');

                    foreach (var email in emails)
                    {
                        if (email.Equals(User.Identity.Name))
                        {
                            Invited.Add(item);
                        }
                    }
                }
            }
            return View(Invited);
        }

        // GET: ReadingEvent/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReadingEvent/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Date,Location,StartTime,Type,Duration,Description,OtherDetails,Invites")] ReadingEvent readingEvent)
        {
            if (ModelState.IsValid)
            {
                readingEvent.CreatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                _context.Add(readingEvent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(readingEvent);
        }

        // GET: ReadingEvent/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var readingEvent = await _context.ReadingEvent.FindAsync(id);
            if (readingEvent == null)
            {
                return NotFound();
            }
            return View(readingEvent);
        }

        // POST: ReadingEvent/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Date,Location,StartTime,Type,Duration,Description,OtherDetails,Invites")] ReadingEvent readingEvent)
        {
            if (id != readingEvent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    readingEvent.CreatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    _context.Update(readingEvent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReadingEventExists(readingEvent.Id))
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
            return View(readingEvent);
        }

        // GET: ReadingEvent/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var readingEvent = await _context.ReadingEvent
                .FirstOrDefaultAsync(m => m.Id == id);
            if (readingEvent == null)
            {
                return NotFound();
            }

            return View(readingEvent);
        }

        // POST: ReadingEvent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var readingEvent = await _context.ReadingEvent.FindAsync(id);
            _context.ReadingEvent.Remove(readingEvent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReadingEventExists(int id)
        {
            return _context.ReadingEvent.Any(e => e.Id == id);
        }
        public async Task<IActionResult> AddComment(CommentModel comments)
        {
            if (ModelState.IsValid)
            {
                comments.DateofCmnt = DateTime.Now;
                _context.Comments.Add(comments);
                await _context.SaveChangesAsync();

                return RedirectToAction("Details", "ReadingEvent", new { id = comments.EventId });
            }
            return View(comments);
        }
    }

}
