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
        UserDao adminUserDAO;
        ProductDao adminProductDao;
      
        public HomeController()
        {
            this.adminUserDAO = new UserDao();
            this.adminProductDao = new ProductDao();
        }

        public IActionResult Index()
        {

            ViewBag.TotalUser = adminUserDAO.totalUser();
            ViewBag.TotalProduct = adminProductDao.totalProduct();
            ViewBag.totalProductThisMonth = adminProductDao.totalProductThisMonth();
            ViewBag.totalEarningThisMonth = adminProductDao.totalEarningThisMonth();
            ViewBag.listProduct = adminProductDao.getAllProduct();

            return View("Index");
        }

        public IActionResult Admin()
        {
            return this.Index();
        }
    }
}
