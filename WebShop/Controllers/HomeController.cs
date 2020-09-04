using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
            List<String> dsdm = DanhmucDAO.getCateList();
            List<sanpham> spm = ProductDAO.getNewArrivals();
            List<sanpham> spbc = ProductDAO.getBestSeller();
            ViewBag.sanphams = sanpham;
            ViewBag.onsale = khuyenmai;
            ViewBag.bestrated = danhgiacao;
            ViewBag.dsdm = dsdm;
            ViewBag.spm = spm;
            ViewBag.spbc = spbc;
            return View();
        }

        [HttpGet]
        public IActionResult Product()
        {
            int id = Convert.ToInt32(HttpContext.Request.Query["id"]);
            sanpham sanpham = ProductDAO.getById(id);
            ViewBag.sanpham = sanpham;
            List<sanpham> splq = ProductDAO.getByBranch(sanpham.danhmuc.tenhangsx);
            List<danhgia> cmtlist = DanhgiaDAO.getListDanhGia(id);
            String[] splitInfo = sanpham.hinhanhsanpham.Split("/");
            String path = Path.Combine("wwwroot",splitInfo[0],splitInfo[1]);
            List<string> listPath = new List<string>();
            if (Directory.Exists(path))
            {
                string[] fileEntries = Directory.GetFiles(path);
                listPath = new List<string>();
                foreach (var f in fileEntries)
                {
                    listPath.Add(Path.Combine(splitInfo[0], splitInfo[1], Path.GetFileName(f)));
                }
            }
            ViewBag.listPath = listPath;
            ViewBag.cmtlist = cmtlist;
            ViewBag.splq = splq;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
