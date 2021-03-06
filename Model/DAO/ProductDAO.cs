﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Project.Models.DAO;


namespace ProjectCore.Models
{
    public class ProductDAO
    {
        static ProjectContext context = new ProjectContext();

        public ProductDAO()
        {
            context = new ProjectContext();
        }
        public static List<sanpham> GetListSanPham()
        {            
                var sanphams = context.Sanpham
                  .Include(p => p);
                List<sanpham> sanphamList = sanphams.ToList();
                return sanphamList;
        }
        public static List<sanpham> getOnSale()
        {
            var sanphams = context.Sanpham.Where(c => c.phanTramGiamGia != 0);
            return sanphams.ToList();
        }
        public static List<sanpham> GetBestRated()
        {
            List<sanpham> result = new List<sanpham>();
            /*var a = context.Sanpham.Join(
                context.Danhgia,
                sanpham => sanpham.idsanpham,
                danhgia => danhgia.sanpham.idsanpham,
                (sanpham, danhgia) => new
                {
                    danhgiaid = danhgia.iddanhgia,
                    rate = danhgia.rate,
                    sanphamid = sanpham.idsanpham
                }).OrderBy(o => o.rate).ToList();
            foreach (var item in a)
            {
                Console.WriteLine(item.rate);
            }*/
            var a = context.Sanpham.Include(s => s.Danhgias).OrderBy(s => s.Danhgias.AsQueryable().Average(d => d.rate));
            return a.ToList();
            
        }
        public static List<sanpham> getByBranch(string branch)
        {
            var a = context.Sanpham.Include(s => s.danhmuc).Where(s => s.danhmuc.tenhangsx == branch);
            return a.ToList();
        }
        public static List<sanpham> getByCategory(string Cat)
        {
            var a = context.Sanpham.Include(s => s.danhmuc).Where(s => s.danhmuc.loaiSanPham == Cat);
            return a.ToList();
        }
        public static List<sanpham> getByColor (string color)
        {
            var a = context.Sanpham.Include(s => s.danhmuc).Where(s => s.mausac == color);
            return a.ToList();
        }
        public static sanpham getById(int id)
        {
            var a = context.Sanpham.Include(s => s.thongso).Where(s => s.id == id);
            return a.ToList().First();
        }
        public static List<sanpham> getByName(string term, String cat)
        {

            if (cat != "All")
            {
                return context.Sanpham.Include(s => s).Where(s => s.tensanpham.Contains(term) &&
                   s.danhmuc.loaiSanPham.Equals(cat)).ToList();
            }
            if (cat.Equals("All"))
            {
                return context.Sanpham.Include(s => s).Where(s => s.tensanpham.Contains(term)).ToList();
            }
            return null;

        }
        public static List<sanpham> getShopList(string category, string brand, int pageIndex, out int pageSize)
        {
            var sp = context.Sanpham.Include(s => s).AsQueryable();
            

            if (!category.Equals("all"))
            {
               
                sp = sp.AsQueryable().Where(s=> s.danhmuc.loaiSanPham.Equals(category));
                
            }
            if (!brand.Equals("all"))
            {
                sp = sp.AsQueryable().Where(s => s.danhmuc.tenhangsx.Equals(brand));
            }
            pageSize = caculatePageSize(sp.Count());
            if (pageIndex != 1)
            {
                sp = sp.AsQueryable().Skip(20 * (pageIndex - 1)).Take(20);
            }
            else
            {
                sp = sp.AsQueryable().Take(20);
            }
            return sp.ToList();
        }
        public static int caculatePageSize(int count)
        {
            int in1 = 20;
            if (count % in1 != 0)
            {
                return count / in1 + 1;
            }
            else
            {
                return count / in1;
            }
        }
        public sanpham findProductById(string id)
        {
            int idnum = Int32.Parse(id);
            return context.Sanpham.SingleOrDefault(x => x.id == idnum);
        }
        public static List<sanpham> getNewArrivals()
        {
            var sp = context.Sanpham.Include(s => s.danhmuc).OrderBy(s => s.ngayNhapHang).Take(8);
            return sp.ToList();
        }
        public static List<sanpham> getBestSeller()
        {
            var sp = context.Sanpham.Include(s => s.danhmuc).Include(s => s.Chitietdonhangs).OrderBy(d => d.Chitietdonhangs.AsQueryable().Count()).Take(20);
            return sp.ToList();
        }
        public static void changeAmount(int id, int num, bool option)
        {
            if (option)
            {
                context.Sanpham.SingleOrDefault(s => s.id == id).soluong += num;
            }
            else
                context.Sanpham.SingleOrDefault(s => s.id == id).soluong -= num;
            context.SaveChanges();
        }


    }
}
