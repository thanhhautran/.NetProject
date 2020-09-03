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
    public class FormController : Controller
    {
       
        public FormController()
        {
            
        }
        public IActionResult Index()
        {
            //Session
            khachhang user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("Form");
        }
    }
}
