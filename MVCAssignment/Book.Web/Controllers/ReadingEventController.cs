using Book.BL;
using Book.BL.EventRepo;
using Book.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Book.Web.Controllers
{

    [Authorize]
    public class ReadingEventController : Controller
    {
        //private readonly ApplicationDbContext _context;
        private IEventOperation _BLL = null;
        private readonly ILogger<ReadingEventController> _logger;
        private readonly EventFacade _Facade;
        public ReadingEventController(BL.EventRepo.IEventOperation bll, ILogger<ReadingEventController> logger, EventFacade Facade)
        {
            _BLL = bll;
            _logger = logger;
            _Facade = Facade;
        }

        // GET: ReadingEvent
        public  IActionResult Index()
        {
            var id =User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var books =  _Facade.GetUserEventById(id);
            return View(books);
        }

        [Authorize(Policy = "RoleGroupPolicy")]
        public IActionResult AllEvents()
        {
            _logger.Log(LogLevel.Information, "Message of log for All events");
            var myevents = _Facade.GetAllEvents();
            // var myevents = _BLL.GetAllEvents();
            return View(myevents);
        }
        // GET: ReadingEvent/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            _logger.Log(LogLevel.Information, "Message of log for Details");

            //var registerEventModel = _BLL.GetEventById(id);
            var registerEventModel = _Facade.GetEventById(id);
            //var eventCmnt = _BLL.Comments(id);
            var eventCmnt = _Facade.Comments(id);
            ViewBag.Cmnt = eventCmnt;
            if (registerEventModel == null)
            {
                return NotFound();
            }
            return View(registerEventModel);
        }
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var readingEvent = await _context.ReadingEvent.FirstOrDefaultAsync(m => m.Id == id);

        //    var eventComnt = await _context.Comments.Where(m => m.EventId == id).ToListAsync();


        //    var registerEventModel = _BLL.GetEventById(id);

        //    var eventCmnt = _BLL.Comments(id);
        //    ViewBag.Cmnt = eventCmnt;

        //    return View(registerEventModel);
        //    //ViewBag.Cmnt = eventComnt;


        //    if (readingEvent == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(readingEvent);
        //}

        public IActionResult Create()
        {
            _logger.Log(LogLevel.Information, "Message of log for Create");
            return View();
        }
        public IActionResult InvitedTo()
        {
            List<ReadingEvent> Invited = new List<ReadingEvent>();
            //var readingEvent = _BLL.GetAllEvents(); 
            var readingEvent = _Facade.GetAllEvents();
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
        //public IActionResult Create()
        //{
        //    return View();
        //}

        // POST: ReadingEvent/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Title,Date,Location,StartTime,Type,Duration,Description,OtherDetails,Invites")] ReadingEvent readingEvent)
        {
            if (ModelState.IsValid)
            {
                readingEvent.CreatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                //_BLL.CreateEvent(readingEvent);
                _Facade.CreateEvent(readingEvent);
                return RedirectToAction(nameof(Index));
            }
            return View(readingEvent);
        }

        // GET: ReadingEvent/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //var readingEvent = _BLL.GetEventById(id);
            var readingEvent = _Facade.GetEventById(id);
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
        public IActionResult Edit(int id, [Bind("Id,Title,Date,Location,StartTime,Type,Duration,Description,OtherDetails,Invites")] ReadingEvent readingEvent)
        {
            if (id != readingEvent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                
                    readingEvent.CreatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    //_BLL.Edit(id, readingEvent);
                _Facade.Edit(id, readingEvent);
                return RedirectToAction(nameof(Index));
            }
            return View(readingEvent);
        }

        // GET: ReadingEvent/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var readingEvent = _BLL.GetEventById(id);
            var readingEvent = _Facade.GetEventById(id);
            if (readingEvent == null)
            {
                return NotFound();
            }

            return View(readingEvent);
        }

        // POST: ReadingEvent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            //_BLL.DeleteConfirmed(id);
            _Facade.DeleteConfirmed(id);
            return RedirectToAction(nameof(Index));
        }

        //private bool ReadingEventExists(int id)
        //{
        //    return _context.ReadingEvent.Any(e => e.Id == id);
        //}

        public ActionResult AddComment(CommentModel comments)
        {
            if (ModelState.IsValid)
            {
                comments.DateofCmnt = DateTime.Now;

                //_BLL.AddComment(comments);
                _Facade.AddComment(comments);

                return RedirectToAction("Details", "ReadingEvent", new { id = comments.EventId });
            }
            return View(comments);
        }
    }
}
