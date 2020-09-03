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
        [Required(ErrorMessage = "Please enter Color ")]
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
        [Required(ErrorMessage = "Please enter product flatform ")]
        public string hedieuhanh { get; set; }
        [Required(ErrorMessage = "Please enter type of screen ")]
        public string loaimanhinh { get; set; }
        [Required(ErrorMessage = "Please enter this field ")]
        public string dophangiai { get; set; }
        [Required(ErrorMessage = "Please enter width ")]
        public string manhinhrong { get; set; }
        [Required(ErrorMessage = "Please enter back camera ")]
        public string camerasau { get; set; }
        [Required(ErrorMessage = "Please enter front camera ")]
        public string cameratruoc { get; set; }
        [Required(ErrorMessage = "Please enter this field ")]
        public string quayphim { get; set; }
        [Required(ErrorMessage = "Please enter  this field  ")]
        public string tocdocpu { get; set; }
        [Required(ErrorMessage = "Please enter  this field  ")]
        public string chipset { get; set; }
        [Required(ErrorMessage = "Please enter  this field  ")]
        public string ram { get; set; }
        [Required(ErrorMessage = "Please enter this field   ")]
        public string chipdohoa { get; set; }
        [Required(ErrorMessage = "Please enter  this field  ")]
        public string rom { get; set; }
        [Required(ErrorMessage = "Please enter  this field  ")]
        public string theNhoNgoai { get; set; }
        [Required(ErrorMessage = "Please enter this field   ")]
        public string trongluong { get; set; }
        [Required(ErrorMessage = "Please enter  this field  ")]
        public string dungluongpin { get; set; }
        [Required(ErrorMessage = "Please enter  this field  ")]
        public string bluetooth { get; set; }
        [Required(ErrorMessage = "Please enter this field   ")]
        public string wifi { get; set; }
        [Required(ErrorMessage = "Please enter  this field  ")]
        public string gprs { get; set; }
        [Required(ErrorMessage = "Please enter  this field  ")]
        public string loaisim { get; set; }
        [Required(ErrorMessage = "Please enter this field   ")]

        //Danhmuc
        
        public int danhmucid { get; set; }
    }
}

