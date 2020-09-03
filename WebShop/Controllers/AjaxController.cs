using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Models.DAO;
using ProjectCore.Models;

namespace WebShop.Controllers
{
    [Route("api/Ajax")]
    public class AjaxController : Controller
    {

        [Produces("application/json")]
        [HttpGet("search")]
        public IActionResult Search()
        {
            using (var a = new ProjectContext())
            {
                try
                {
                    string term = HttpContext.Request.Query["term"].ToString();
                    var names = a.Sanpham.Where(p => p.tensanpham.Contains(term)).Select(p => p.tensanpham).ToList();
                    return Ok(names);
                }
                catch
                {
                    return BadRequest();
                }
            }
        }
        [Produces("application/json")]
        [HttpPost("addCMT")]

        public JsonResult addCMT(Review review)
        {

            khachhang kh = null;
            kh = Helpers.SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            if (kh == null)
            {
                String cmt = review.cmt;
                int spid = review.spid;
                return Json(new { success = "userrq" });
            }
            else
            {
                String cmt = review.cmt;
                int star = review.star;
                int spid = review.spid;
                //  sanpham sp = ProductDAO.getById(spid);
                DanhgiaDAO.adddanhGia(kh.id, cmt, star, spid);
                return Json(new { success = "suc", khname = kh.taikhoan, star = star, nd = cmt });
            }


        }
        public class Review
        {
            public string cmt { get; set; }
            public int star { get; set; }
            public int spid { get; set; }
        }
    }
}
