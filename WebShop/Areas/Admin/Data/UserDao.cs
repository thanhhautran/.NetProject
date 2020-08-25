using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;
using Microsoft.AspNetCore.Mvc;
using ProjectCore.Models;
using Project.Models.DAO;
using Microsoft.EntityFrameworkCore;

namespace WebShop.Areas.Admin.Data
{
    public class UserDao : Controller
    {
        ProjectContext pt = null;

        public UserDao()
        {
            this.pt = new ProjectContext();
        }

        public IActionResult Index()
        {
            return View();
        }

        public int totalUser()
        {
            return pt.Khachhang.Count();
        }

        public int totalProduct()
        {
            return Convert.ToInt32(pt.Sanpham.Sum(i => i.soluong));
        }

        public int totalProductThiMonth()
        {
            return pt.Khachhang.Count();
        }

        public int totalEarningThisMonth()
        {
            return pt.Khachhang.Count();
        }

    }
}
