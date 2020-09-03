using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Models.DAO;
using WebShop.Helpers;

namespace WebShop.Areas.Admin.Controllers
{
    public class IconController : Controller
    {
      
        [Area("Admin")]
        public IActionResult Button()
        {
            //Session
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("Button");
        }
        [Area("Admin")]
        public IActionResult Badges()
        {
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("Badges");
        }
        [Area("Admin")]
        public IActionResult Tabs()
        {
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("Tabs");
        }
        [Area("Admin")]
        public IActionResult Cards()
        {
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("Cards");
        }
        [Area("Admin")]
        public IActionResult Alerts()
        {
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("Alerts");
        }
        [Area("Admin")]
        public IActionResult ProgressBars()
        {
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("ProgressBars");
        }
        [Area("Admin")]
        public IActionResult Modals()
        {
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("Modals");
        }
        [Area("Admin")]
        public IActionResult Switchs()
        {
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("Switchs");
        }
        [Area("Admin")]
        public IActionResult Grids()
        {
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("Grids");
        }
        [Area("Admin")]
        public IActionResult FontawesomeIcon()
        {
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("FontawesomeIcon");
        }

       
    }
}
