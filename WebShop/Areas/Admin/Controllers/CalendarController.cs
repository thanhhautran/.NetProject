
using Microsoft.AspNetCore.Mvc;
using Project.Models.DAO;
using WebShop.Helpers;

namespace WebShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CalendarController : Controller
    {
        [HttpGet("/Admin/Calendar/Index")]
        public IActionResult Index()
        {
            //Session
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("Calendar");
        }
    }
}
