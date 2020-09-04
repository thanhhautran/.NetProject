using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Models.DAO;
using WebShop.Areas.Admin.Data;
using WebShop.Helpers;

namespace WebShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        ChartDao chart;
        public ChartController()
        {
            this.chart = new ChartDao();
            
        }

        public IActionResult Index()
        {
            //kpi theo quy
            ViewBag.PieChart = chart.earningByQuarter().ToList(); ;
            ViewBag.YearNow = DateTime.Now.Year;

            string[] productLabel = chart.getProductStatisticsLabel(); ;
           

            //phan loai san pham
            ViewBag.productLabel = productLabel;
            ViewBag.RadarData = chart.getProductStatisticsType(productLabel);
            
            //so luong ban theo thang      


            ViewBag.LineDataPhone = chart.getProductSoldByMonth("Điện thoại");
            ViewBag.LineDataTablet = chart.getProductSoldByMonth("Tablet");
            ViewBag.LineDataHeadphone = chart.getProductSoldByMonth("Tai Nghe");

            //Session
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;


            return View("Chart");

        }
    }
}
