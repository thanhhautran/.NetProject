using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebShop.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Yêu cầu nhập tên tài khoản")]
        public string taikhoan { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập tên tài khoản")]
        public string matkhau { get; set; }
    }
}
