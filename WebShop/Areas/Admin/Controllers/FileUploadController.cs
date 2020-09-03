using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShop.Areas.Admin.Models;

namespace WebShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FileUploadController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("FileUpload")]
        public async Task<IActionResult> Index(IFormFile[] files, ImageClass ic)
        {
          if(files == null || files.Length == 0)
            {
                ViewBag.mess = "Select image...";
            }

          foreach (IFormFile file in files)
            {
                var text = Path.GetExtension(file.FileName);

                var save = Path.Combine("./Areas/Admin/", "Image", file.FileName);
                var stream = new FileStream(save, FileMode.Create);
                await file.CopyToAsync(stream);

                ic.imageName = file.FileName;
                ic.imageText = text;
                ic.imagePath = save;

                ViewBag.mess = "save";
            }
            return RedirectToAction("Index"); 
        }
    }
}
