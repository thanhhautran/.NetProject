using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebShop.Models
{
    public class ChangePasswordModel
    {
        [Required]
        public string matkhau { get; set; }


        [Compare("matkhau", ErrorMessage = "Xác nhận mật khẩu không đúng.")]
        public string re_matkhau { get; set; }
       
    }
}
