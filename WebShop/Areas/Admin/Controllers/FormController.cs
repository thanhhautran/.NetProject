using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FormController : Controller
    {
        public IActionResult Index()
        {   
            return View("Form");
        }
        [HttpGet("/Send")]
        public IActionResult Send([FromQuery] int id)
        {
           
            return View("Send");
        }
    }
}
