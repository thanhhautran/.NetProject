﻿
using Microsoft.AspNetCore.Mvc;

namespace WebShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CalendarController : Controller
    {
        public IActionResult Index()
        {
            return View("Calendar");
        }
    }
}
