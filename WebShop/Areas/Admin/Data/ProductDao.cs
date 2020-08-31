using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Models.DAO;
using ProjectCore.Models;

namespace WebShop.Areas.Admin.Data
{
    public class ProductDao : Controller
    {
        ProjectContext pt = null;

        public ProductDao()
        {
            this.pt = new ProjectContext();
        }

        public int totalProduct()
        {
            return Convert.ToInt32(pt.Sanpham.Sum(i => i.soluong));
        }

        public int totalProductThisMonth()
        {
            var date = DateTime.Now;

            var a = pt.Chitietdonhang.Where(c => c.donhang.ngaygiaodich.Value.Year == date.Year
                                                     && c.donhang.ngaygiaodich.Value.Month == date.Month);
            return (int)a.AsQueryable().Sum(a => a.soluong);
        }

        public int totalEarningThisMonth()
        {
            var date = DateTime.Now;
            return Convert.ToInt32(pt.Chitietdonhang.Where(c => c.donhang.ngaygiaodich.Value.Year == date.Year
                                                    && c.donhang.ngaygiaodich.Value.Month == date.Month).Sum(c => c.tonggia));

        }   

        public List<sanpham> getAllProduct()
        {
            
            return pt.Sanpham.ToList();
        }
    }
}
