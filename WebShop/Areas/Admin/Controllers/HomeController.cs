using Microsoft.AspNetCore.Mvc;
using ProjectCore.Models;
using Project.Models.DAO;
using Microsoft.EntityFrameworkCore;
using WebShop.Areas.Admin.Data;

namespace WebShop.Areas.Admin.Controllers

{
    [Area("Admin")]
    public class HomeController : Controller
    {
        UserDao adminDAO;
        
        public HomeController()
        {
            this.adminDAO = new UserDao();
        }

        public IActionResult Index()
        {
            ViewBag.TotalUser = adminDAO.totalUser();
            ViewBag.TotalProduct = adminDAO.totalProduct();
            ViewBag.totalProductThisMonth = adminDAO.totalProductThisMonth();
            ViewBag.totalEarningThisMonth = adminDAO.totalEarningThisMonth();
            return View("Index");
        }

        public IActionResult Admin()
        {
            return this.Index();
        }
    }
}
