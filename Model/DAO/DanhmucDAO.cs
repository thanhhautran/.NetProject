using Project.Models.DAO;
using ProjectCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCore.Models
{
    public class DanhmucDAO
    {
        public static List<danhmuc> getDanhMucList()
        {
            using (var context = new ProjectContext())
            {
                var listDanhMuc = context.Danhmuc.ToList();
                return listDanhMuc;
            }
        }
        public static List<string> getCateList()
        {
            using (var context = new ProjectContext())
            {
                var listDanhMuc = context.Danhmuc.Select(s => s.loaiSanPham).Distinct();
                return listDanhMuc.ToList();
            }
        }
        public static List<string> getBrandList()
        {
            using (var context = new ProjectContext())
            {
                var listNhasx = context.Danhmuc.Select(s => s.tenhangsx).Distinct();
                return listNhasx.ToList();
            }
        }

    }
}
