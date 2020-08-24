using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.Models.DAO;
using ProjectCore.Models;
using ProjectCore.Models.DAO;
using WebShop.Models;

namespace ProjectCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<sanpham> sanpham = ProductDAO.GetListSanPham();
            List<sanpham> khuyenmai = ProductDAO.getOnSale();
            List<sanpham> danhgiacao = ProductDAO.GetBestRated();
            
            
            ViewBag.sanphams = sanpham;
            ViewBag.onsale = khuyenmai;
            ViewBag.bestrated = danhgiacao;
            return View();
        }
        public IActionResult Shop()
        {
            if(Request.Query != null)
            {
                List<sanpham> sanpham = ProductDAO.GetListSanPham();
                ViewBag.dssp = sanpham;
                return View();
            }
            else
            {
                return View();
            }
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
