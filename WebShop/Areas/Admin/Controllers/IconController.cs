using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebShop.Areas.Admin.Controllers
{
    public class IconController : Controller
    {
        [Area("Admin")]
        public IActionResult Button()
        {
            return View("Button");
        }
        [Area("Admin")]
        public IActionResult Badges()
        {
            return View("Badges");
        }
        [Area("Admin")]
        public IActionResult Tabs()
        {
            return View("Tabs");
        }
        [Area("Admin")]
        public IActionResult Cards()
        {
            return View("Cards");
        }
        [Area("Admin")]
        public IActionResult Alerts()
        {
            return View("Alerts");
        }
        [Area("Admin")]
        public IActionResult ProgressBars()
        {
            return View("ProgressBars");
        }
        [Area("Admin")]
        public IActionResult Modals()
        {
            return View("Modals");
        }
        [Area("Admin")]
        public IActionResult Switchs()
        {
            return View("Switchs");
        }
        [Area("Admin")]
        public IActionResult Grids()
        {
            return View("Grids");
        }
        [Area("Admin")]
        public IActionResult FontawesomeIcon()
        {
            return View("FontawesomeIcon");
        }

       
    }
}
