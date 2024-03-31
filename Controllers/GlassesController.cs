﻿
using do_an_ltweb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace do_an.Controllers
{
    public class GlassesController : Controller
    {
        private readonly ILogger<GlassesController> _logger;

        public GlassesController(ILogger<GlassesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}