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
    
    public partial class chitietdonhang
    {
        public int id { get; set; }
        public int? donhangid { get; set; }
        public int? sanphamid { get; set; }
        public donhang donhang { get; set; }
        public sanpham sanpham { get; set; }
        public string tensanpham { get; set; }
        public Nullable<int> soluong { get; set; }
        public Nullable<double> gia { get; set; }
        public Nullable<double> tonggia { get; set; }
    }
}
