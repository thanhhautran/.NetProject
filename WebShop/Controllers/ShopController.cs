using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Models;
using Microsoft.AspNetCore.Mvc;
using Project.Models.DAO;
using ProjectCore.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace WebShop.Controllers
{
    public class ShopController : Controller
    {
        [HttpGet]
        public IActionResult Shop()
        {
            if (HttpContext.Request.Query["category"].ToString() == "")
            {
                List<sanpham> sanpham = ProductDAO.GetListSanPham();
                List<string> danhmucs = DanhmucDAO.getCateList();
                List<string> nhasx = DanhmucDAO.getBrandList();
                ViewBag.dssp = sanpham;
                ViewBag.dsdm = danhmucs;
                ViewBag.dsnsx = nhasx;
                ViewBag.category = "all";
                ViewBag.brand = "all";
              //  ViewBag.color = "all";
                ViewBag.PageIndex = 1;
                ViewBag.PageSize = ProductDAO.caculatePageSize(sanpham.Count);
                return View();
            }
            else
            {
                String category = HttpContext.Request.Query["category"].ToString();
                String brand = HttpContext.Request.Query["brand"].ToString();
                int pageIndex = Convert.ToInt32(HttpContext.Request.Query["pageIndex"]);
                int pageSize = 1;
                List<sanpham> sanpham = ProductDAO.getShopList(category,brand,pageIndex,out pageSize);
                List<string> danhmucs = DanhmucDAO.getCateList();
                List<string> nhasx = DanhmucDAO.getBrandList();
                ViewBag.dssp = sanpham;
                ViewBag.dsdm = danhmucs;
                ViewBag.dsnsx = nhasx;
                ViewBag.category = category;
                ViewBag.brand = brand;
                ViewBag.PageIndex = pageIndex;
                ViewBag.PageSize = pageSize;
                return View();
            }

        }
        [HttpPost]
        public IActionResult Search()
        {
            List<sanpham> sanpham = ProductDAO.getByName(Request.Form["search-input"], Request.Form["search-select"]);
            ViewBag.dssp = sanpham;
            List<string> danhmucs = DanhmucDAO.getCateList();
            List<string> nhasx = DanhmucDAO.getBrandList();
            ViewBag.dssp = sanpham;
            ViewBag.dsdm = danhmucs;
            ViewBag.dsnsx = nhasx;
            ViewBag.category = "all";
            ViewBag.brand = "all";
            //  ViewBag.color = "all";
            ViewBag.PageIndex = 1;
            ViewBag.PageSize = ProductDAO.caculatePageSize(sanpham.Count);
            return View("Shop");
        }
    }
}
