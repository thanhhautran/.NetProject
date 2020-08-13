using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Project.Models.DAO;

namespace ProjectCore.Models
{
    public class ProductUtil
    {
        public static List<sanpham> GetListSanPham()
        {
            // Gets and prints all books in database
            using (var context = new ProjectContext())
            {
                var sanphams = context.Sanpham
                  .Include(p => p);
                List<sanpham> sanphamList = sanphams.ToList();
                return sanphamList;
            }
        }
    }
}
