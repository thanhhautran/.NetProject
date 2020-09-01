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
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Email không đúng định dạng")]
        [Required(ErrorMessage = "Yêu cầu nhập email")]
        public string email { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",ErrorMessage = "Entered phone format is not valid.")]
        public string sdt { get; set; }
        public string diachi { get; set; }
        public string hoten { get; set; }
    }
}
