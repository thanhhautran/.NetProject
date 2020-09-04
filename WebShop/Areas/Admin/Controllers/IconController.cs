using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Models.DAO;
using WebShop.Helpers;

namespace WebShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class IconController : Controller
    {
      
        
        [HttpGet("/Admin/Icon/Button")]
        public IActionResult Button()
        {
            //Session
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("Button");
        }

        [HttpGet("/Admin/Icon/Badges")]
        public IActionResult Badges()
        {
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("Badges");
        }


        [HttpGet("/Admin/Icon/Tabs")]
        public IActionResult Tabs()
        {
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("Tabs");
        }


        public IActionResult Cards()
        {
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("Cards");
        }


        [HttpGet("/Admin/Icon/Alerts")]
        public IActionResult Alerts()
        {
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("Alerts");
        }


        [HttpGet("/Admin/Icon/ProgressBars")]
        public IActionResult ProgressBars()
        {
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("ProgressBars");
        }


        [HttpGet("/Admin/Icon/Modals")]
        public IActionResult Modals()
        {
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("Modals");
        }


        [HttpGet("/Admin/Icon/Switchs")]
        public IActionResult Switchs()
        {
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("Switchs");
        }


        [HttpGet("/Admin/Icon/Grids")]
        public IActionResult Grids()
        {
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("Grids");
        }


        [HttpGet("/Admin/Icon/FontawesomeIcon")]
        public IActionResult FontawesomeIcon()
        {
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("FontawesomeIcon");
        }

       
    }
}
