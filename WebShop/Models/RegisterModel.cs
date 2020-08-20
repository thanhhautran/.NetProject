using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebShop.Models
{
    public class RegisterModel
    {
      
        [Required(ErrorMessage = "Yêu cầu nhập tên tài khoản")]
        public string taikhoan { get; set; }

        
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Độ dài mật khẩu ít nhất 6 ký tự.")]
        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
        public string matkhau { get; set; }

       
        [Compare("matkhau", ErrorMessage = "Xác nhận mật khẩu không đúng.")]
        public string re_matkhau { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập email")]
        public string email { get; set; }
        public string sdt { get; set; }
        public string diachi { get; set; }
        public string hoten { get; set; }
    }
}
