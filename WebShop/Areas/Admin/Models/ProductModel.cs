    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Http;

    namespace WebShop.Areas.Admin.Models
    {
    public class ProductModel
    {
        //San Pham

        
        public int khuyenmaiid { get; set; }
        [Required(ErrorMessage = "Please enter Product Name ")]
        public string tensanpham { get; set; }
        public string mausac { get; set; }
        [Required(ErrorMessage = "Please enter Price ")]
        public int gia { get; set; }
       
        public string uudai { get; set; }
      
        public IFormFile[] hinhanhsanpham { get; set; }
        [Required(ErrorMessage = "Please enter the amount of product ")]
        public int soluong { get; set; }
       [Required(ErrorMessage = "Please choose one ")]
        public string cosan { get; set; }
        
        public string noidungkhuyenmai { get; set; } 
      
        public int phanTramGiamGia { get; set; }
       

        //Thong so
        [Required(ErrorMessage = "Please enter the specification id ")]
        public int thongsoid { get; set; }
        public string hedieuhanh { get; set; }
        public string loaimanhinh { get; set; }
        public string dophangiai { get; set; }
        public string manhinhrong { get; set; }
        public string camerasau { get; set; }
        public string cameratruoc { get; set; }
        public string quayphim { get; set; }
        public string tocdocpu { get; set; }
        public string chipset { get; set; }
        public string ram { get; set; }
        public string chipdohoa { get; set; }
        public string rom { get; set; }
        public string theNhoNgoai { get; set; }
        public string trongluong { get; set; }
        public string dungluongpin { get; set; }
        public string bluetooth { get; set; }
        public string wifi { get; set; }
        public string gprs { get; set; }
        public string loaisim { get; set; }

        //Danhmuc
        [Required(ErrorMessage = "Please enter the Type ID of product ")]

        public int danhmucid { get; set; }
    }
}

