using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;
using Microsoft.AspNetCore.Mvc;
using ProjectCore.Models;
using Project.Models.DAO;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.SqlServer;

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

       // public int totalProductThisMonth()
       // {
       //     var date = DateTime.Now;

       //    var a  =pt.Chitietdonhang.Where(c => c.donhang.ngaygiaodich.Value.Year == date.Year
         //                                           && c.donhang.ngaygiaodich.Value.Month == date.Month);
       //     return (int)a.AsQueryable().Sum(a => a.soluong);
      //  }

      //  public int totalEarningThisMonth()
      //  {
       //     var date = DateTime.Now;
       //     return Convert.ToInt32(pt.Chitietdonhang.Where(c => c.donhang.ngaygiaodich.Value.Year == date.Year
      //                                              && c.donhang.ngaygiaodich.Value.Month == date.Month).Sum(c => c.tonggia));
          
      //  }

    }
}
