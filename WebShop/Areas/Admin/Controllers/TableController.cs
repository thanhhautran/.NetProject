using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShop.Areas.Admin.Data;

namespace WebShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TableController : Controller
    {
        ProductDao adminProductDao;

        public TableController()
        {
            this.adminProductDao = new ProductDao(); ;
        }

        [HttpGet]
        public IActionResult Table()
        {
            ViewBag.listProduct = adminProductDao.getAllProduct();
            return View("Table");
        }

        [HttpGet]
        public IActionResult AddItem()
        {
            return View();
        }
    }
}
