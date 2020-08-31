using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
    }
}
