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

    public partial class danhgia
    {
        [Key]
        public int id { get; set; }
        public virtual khachhang khachhang { get; set; }
        public virtual sanpham sanpham { get; set; }
        public string noiDungDanhGia { get; set; }
        public Nullable<int> rate { get; set; }
    }
}
