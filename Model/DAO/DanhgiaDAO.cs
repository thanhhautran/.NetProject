using System;
using System.Collections.Generic;
using System.Text;
using Project.Models.DAO;
using ProjectCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ProjectCore.Models
{
    public class DanhgiaDAO
    {
        public static void adddanhGia(int? khid, string noidung, int rate, int? spid)
        {
            using (var context = new ProjectContext())
            {
                danhgia dg = new danhgia();

                dg.khachhangid = khid;
                dg.noiDungDanhGia = noidung;
                dg.rate = rate;
                dg.sanphamid = spid;
                context.Danhgia.Add(dg);
                context.SaveChanges();
            }
        }
        public static List<danhgia> getListDanhGia(int productID)
        {
            using (var context = new ProjectContext())
            {
                List<danhgia> cmtlist = new List<danhgia>();
                var danhgias = context.Danhgia.Include(d => d.sanpham).Include(d => d.khachhang).Where(d => d.sanpham.id == productID);
                cmtlist = danhgias.ToList();
                return cmtlist;
            }
        }
    }
}
