//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.Models.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class sanpham
    {
        
        public int id { get; set; }
        public string tensanpham { get; set; }
        public string mausac { get; set; }
        public int gia { get; set; }
        public thongso thongso { get; set; }
        public int? thongsoid { get; set; }
        public int? danhmucid { get; set; }
        public string uudai { get; set; }
        public danhmuc danhmuc { get; set; }
        public string hinhanhsanpham { get; set; }
        public Nullable<int> soluong { get; set; }
        public string cosan { get; set; }
        public Nullable<int> phanTramGiamGia { get; set; }
        public string noidungkhuyenmai { get; set; }
        public virtual ICollection<danhgia> Danhgias { get; set; }
        public int giaSauKhuyenMai => (int)(gia - gia*(phanTramGiamGia/100));

    }
}
