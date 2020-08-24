using System;
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
            var a = context.Sanpham.Include(s => s.Danhgias).Where(s => s.danhmuc.tenhangsx == branch);
            return a.ToList();
        }
        public static List<sanpham> getByCategory(string Cat)
        {
            var a = context.Sanpham.Include(s => s.Danhgias).Where(s => s.danhmuc.loaiSanPham == Cat);
            return a.ToList();
        }
        public static List<sanpham> getByColor (string color)
        {
            var a = context.Sanpham.Include(s => s.Danhgias).Where(s => s.mausac == color);
            return a.ToList();
        }


    }
}
