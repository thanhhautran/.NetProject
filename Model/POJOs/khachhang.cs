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
    using Model.POJOs;

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class khachhang
    {
       
        public int id { get; set; }
        public string taikhoan { get; set; }
        public string matkhau { get; set; }
        public string email { get; set; }
        public string sdt { get; set; }
        public string diachi { get; set; }
        public string hoten { get; set; }
        public int? roleTableid { get; set; }
        public roleTable roleTable { get; set; }
        public virtual ICollection<danhgia> Danhgias { get; set; }

        public virtual ICollection<donhang> donhangs { get; set; }
    }
}
