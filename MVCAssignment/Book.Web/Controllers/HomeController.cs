﻿using Book.DAL;
using Book.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly ApplicationDbContext _context;
        private BL.EventRepo.IEventOperation _BLL = null;


        public HomeController(ILogger<HomeController> logger, BL.EventRepo.IEventOperation bll)
        {
            _logger = logger;
            _BLL = bll;
        }
        public IActionResult Index()
        {
            var myevents = _BLL.GetAllEvents();
            return View(myevents);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Details(int? id)
        {

            var registerEventModel = _BLL.GetEventById(id);

            var eventCmnt = _BLL.Comments(id);
            ViewBag.Cmnt = eventCmnt;

            return View(registerEventModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //public async Task<IActionResult> IndexAsync()
        //{
        //    return View(await _context.ReadingEvent.ToListAsync());
        //}
        ////public IActionResult Index()
        ////{
        ////    return View();
        ////}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var readingEvent = await _context.ReadingEvent
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (readingEvent == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(readingEvent);
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}