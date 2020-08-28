using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebShop.Areas.Admin.Models
{
    public class ProductModel : Controller
    {
        public int id { get; set; }
        public int khuyenmaiid { get; set; }
        public string tensanpham { get; set; }
        public string mausac { get; set; }
        public int gia { get; set; }
        public int thongsoid { get; set; }
        public string uudai { get; set; }
        public int danhmucid { get; set; }
        public string hinhanhsanpham { get; set; }
        public Nullable<int> soluong { get; set; }
        public string cosan { get; set; }
        public string noidungkhuyenmai { get; set; }
        public Nullable<int> phanTramGiamGia { get; set; }
    }
}
