using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Areas.Admin.Models
{
    public class OrderModel
    {
        
        public int khachhangid { get; set; }
        public string temp { get; set; }
        
        public System.DateTime ngaygiaodich { get; set; }

        [Required(ErrorMessage = "Please enter this field ")]
        public System.DateTime ngaygiaohang { get; set; }

         [Required(ErrorMessage = "Please enter this field ")]
        public string diachigiaohang { get; set; }

        // [Required(ErrorMessage = "Please enter this field ")]
        public string sdtlienlac { get; set; }

        //[Required(ErrorMessage = "Please enter this field ")]
        public string emailLienLac { get; set; }

        //[Required(ErrorMessage = "Please enter this field")]
        public Nullable<double> giatridon { get; set; }

        //[Required(ErrorMessage = "Please enter this field")]
        public string trangthai { get; set; }

        
     
    }
}
