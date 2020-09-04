using Microsoft.AspNetCore.Mvc;
using ProjectCore.Models;
using Project.Models.DAO;
using Microsoft.EntityFrameworkCore;
using WebShop.Areas.Admin.Data;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;
using System.Collections.Generic;
using System.Linq;
using WebShop.Helpers;

namespace WebShop.Areas.Admin.Controllers

{
    [Area("Admin")]
    public class HomeController : Controller
    {
        UserDao adminUserDAO;
        ProductDao adminProductDao;
        ChartDao chart;
        List<sanpham> listProduct;
        ProjectContext context;
        
        public HomeController()
        {
            this.adminUserDAO = new UserDao();
            this.adminProductDao = new ProductDao();
            this.chart = new ChartDao();
            this.context = new ProjectContext();
            this.listProduct = adminProductDao.getAllProduct();
            
        }

        public IActionResult Index()
        {

            ViewBag.TotalUser = adminUserDAO.totalUser();
            ViewBag.TotalProduct = adminProductDao.totalProduct();
            ViewBag.totalProductThisMonth = adminProductDao.totalProductThisMonth();
            ViewBag.totalEarningThisMonth = adminProductDao.totalEarningThisMonth();

            ViewBag.listProduct = this.listProduct;

            //kpi thang hien tai vs trc do
            ViewBag.MixDataPhone = chart.getProductSoldForHome("Điện thoại");
            ViewBag.MixDataOthers = chart.getProductSoldForHome("Others");

            //trang thai don trong thang
            string[] statusLabel = {"Preparing", "Prepared", "Packaged", "Moving", "Sent", "Canceled" };
            ViewBag.StatusLabel = statusLabel;
            ViewBag.ProductStatus = chart.getStatusOfOrder(statusLabel);

            //Session
            khachhang user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;

            return View("Index");
        }

        public IActionResult Admin()
        {
            //Session
            khachhang user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return this.Index();
        }


        public IActionResult AddItem()
        {
            //Session
            khachhang user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("../Table/AddItemForm");
        }

        [HttpPost("/Home/FilterProduct")]
        public IActionResult FilterProduct()
        {
            var filterType = HttpContext.Request.Form["productFilter"].ToString();

            this.listProduct = context.Sanpham.Where(s => s.danhmuc.loaiSanPham == filterType).ToList();

            return this.Index();
        }
    }
}
