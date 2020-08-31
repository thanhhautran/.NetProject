using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Models.DAO;
using ProjectCore.Models;
using WebShop.Areas.Admin.Data;
using WebShop.Areas.Admin.Models;

namespace WebShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TableController : Controller
    {
        ProductDao adminProductDao;
        UserDao adminUserDao;
        ProjectContext pt;
        List<donhang> listOrder;
        List<khachhang> listUser;
        List<sanpham> listProduct;
        public TableController()
        {
            this.adminProductDao = new ProductDao();
            this.adminUserDao = new UserDao();
            this.pt = new ProjectContext();
            this.listOrder = adminProductDao.getOrder();
            this.listUser = adminUserDao.getUser(0);
            this.listProduct = adminProductDao.getAllProduct();
        }

        [HttpGet]
        public IActionResult Table()
        {
            ViewBag.listProduct = adminProductDao.getAllProduct();
            ViewBag.ListOrder = this.listOrder;
            ViewBag.listUser = this.listUser;
            return View("Table");
        }


        [HttpGet("/Table/DeleteItem")]
        public IActionResult DeleteItem([FromQuery] int id)
        {
            var item = pt.Sanpham.SingleOrDefault(s => s.id == id);
            var spec = pt.Thongso.SingleOrDefault(s => s.id == item.thongsoid);
            Directory.Delete(item.hinhanhsanpham,true);
            pt.Sanpham.Remove(item);
            pt.Thongso.Remove(spec);
            pt.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/EditOrder")]
        public IActionResult DisplayEditOrder([FromQuery] int id)
        {
            var order = pt.DonHang.SingleOrDefault(i => i.id == id);          
            ViewBag.Id = id;
            ViewBag.Order = order;
            return View("EditOrderForm");
        }

        [HttpPost("/Table/FilterOrder")]
        public IActionResult FilterOrder()
        {
            int filterType = Convert.ToInt32(HttpContext.Request.Form["orderFilter"]);
             
            if (filterType == 1)
            {
                this.listOrder = pt.DonHang.Where(d => d.ngaygiaodich.Value.Month == DateTime.Now.Month).ToList();
            }
            if(filterType == 3)
            {
                this.listOrder = pt.DonHang.Where(d => d.ngaygiaodich.Value.Month >= DateTime.Now.Month-3).ToList();
            }

            return this.Table();
        }
        [HttpPost("/Table/FilterUser")]
        public IActionResult FilterUser()
        {
            int filterType = Convert.ToInt32(HttpContext.Request.Form["userFilter"]);

           if(filterType != 0)
            {
                this.listUser = pt.Khachhang.Where(k => k.roleTableid == filterType).ToList();
            }

            return this.Table();
        }

        [HttpPost("/Table/FilterProduct")]
        public IActionResult FilterProduct()
        {
            var filterType = HttpContext.Request.Form["productFilter"].ToString();

            this.listProduct = pt.Sanpham.Where(s => s.danhmuc.loaiSanPham == filterType).ToList();

            

            return this.Table();
        }


        [HttpGet("/Edit")]
        public IActionResult DisplayEditITem([FromQuery] int id)
        {
            var item = pt.Sanpham.SingleOrDefault(i => i.id == id);

            var spec = pt.Thongso.SingleOrDefault(i => i.id == item.thongsoid);
            ViewBag.id = id;
            ViewBag.Item = item;
            ViewBag.Spec = spec;
            return View("EditItemForm");
        }

        [HttpPost("/Table/EditOrder")]
        [ValidateAntiForgeryToken]
        public IActionResult EditOrder(OrderModel model, [FromQuery] int id)
        {
            if (ModelState.IsValid)
            {
                var order = pt.DonHang.SingleOrDefault(i => i.id == id);

                order.ngaygiaohang = model.ngaygiaohang;
                order.sdtlienlac = model.sdtlienlac;
                order.giatridon = model.giatridon;
                order.trangthai = model.trangthai;

                pt.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return DisplayEditOrder(id);
            }
        }

        [HttpPost("/Table/EditItem")]
        [ValidateAntiForgeryToken]
        public IActionResult EditItem(ProductModel model, [FromQuery] int id)
        {
            if (ModelState.IsValid)
            {


                var product = pt.Sanpham.SingleOrDefault(i => i.id == id);

                string uniqueFileName = product.hinhanhsanpham;
                if (model.hinhanhsanpham != null) 
                { 
                uniqueFileName = UploadImage(model);
                 }

                product.tensanpham = model.tensanpham;
                product.cosan = model.cosan;      
                product.gia = model.gia;
                product.danhmucid = model.danhmucid;
                product.mausac = model.mausac;
                product.phanTramGiamGia = model.phanTramGiamGia;
                product.soluong = model.soluong;
                product.uudai = model.uudai;
                product.hinhanhsanpham = uniqueFileName;

                var spec = pt.Thongso.SingleOrDefault(i => i.id == product.thongsoid);

                spec.hedieuhanh = model.hedieuhanh;
                spec.dophangiai = model.dophangiai;
                spec.manhinhrong = model.manhinhrong;
                spec.camerasau = model.camerasau;
                spec.cameratruoc = model.cameratruoc;
                spec.quayphim = model.quayphim;
                spec.tocdocpu = model.tocdocpu;
                spec.chipset = model.chipset;
                spec.ram = model.ram;
                spec.chipdohoa = model.chipdohoa;
                spec.rom = model.rom;
                spec.theNhoNgoai = model.theNhoNgoai;
                spec.trongluong = model.trongluong;
                spec.dungluongpin = model.dungluongpin;
                spec.loaimanhinh = model.loaimanhinh;
                spec.bluetooth = model.bluetooth;
                spec.C5G = model.gprs;
                spec.wifi = model.wifi;
                spec.loaisim = model.loaisim;

                pt.SaveChanges(); 
                return RedirectToAction(nameof(Index));
            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                ViewBag.Mess = errors;
                return View("EditItemForm");
            }
        }
       
        [HttpPost("/Table/ChangeRole")]
        public IActionResult ChangeRole([FromQuery] int id)
        {
            var role =Convert.ToInt32(HttpContext.Request.Form["roleid"]);
              var user = pt.Khachhang.SingleOrDefault(u => u.id == id);

                user.roleTableid = role;
                pt.SaveChanges();
                return RedirectToAction(nameof(Index));
            
        }


        [HttpPost("/Table/AddItem")]
        [ValidateAntiForgeryToken]
        public IActionResult AddItem(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadImage(model);
                ViewBag.know = uniqueFileName;

                thongso spec = new thongso
                {
                    id = model.thongsoid,
                    hedieuhanh = model.hedieuhanh,
                    dophangiai = model.dophangiai,
                    manhinhrong = model.manhinhrong,
                    camerasau = model.camerasau,
                    cameratruoc = model.cameratruoc,
                    quayphim = model.quayphim,
                    tocdocpu = model.tocdocpu,
                    chipset = model.chipset,
                    ram = model.ram,
                    chipdohoa = model.chipdohoa,
                    rom = model.rom,
                    theNhoNgoai = model.theNhoNgoai,
                    trongluong = model.trongluong,
                    dungluongpin = model.dungluongpin,
                    loaimanhinh = model.loaimanhinh,
                    bluetooth = model.bluetooth,
                    C5G = model.gprs,
                    wifi = model.wifi,
                    loaisim = model.loaisim
                };


                spec.id = model.thongsoid;
                sanpham product = new sanpham
                {

                    tensanpham = model.tensanpham,
                    cosan = model.cosan,
                    thongsoid = model.thongsoid,
                    thongso = spec,
                    gia = model.gia,
                    danhmucid = model.danhmucid,
                    mausac = model.mausac,
                    phanTramGiamGia = model.phanTramGiamGia,
                    soluong = model.soluong,
                    uudai = model.uudai,
                    hinhanhsanpham = uniqueFileName,


                };
                pt.Add(product);

                spec.id = model.thongsoid;
                pt.Add(spec);
                //pt.Remove(type);

                pt.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                ViewBag.Mess = errors;
                return View("AddItemForm");
            }
        }


        public string UploadImage(ProductModel model)
        {
            string uniqueFileName = null;
            uniqueFileName = Path.Combine("./Areas/Admin/", "Image" + model.tensanpham+"/");

            if (Directory.Exists(uniqueFileName))
            {
                Directory.Delete(uniqueFileName,true);
            }
            Directory.CreateDirectory(uniqueFileName);


            var image = model.hinhanhsanpham;
            if(image != null)
            foreach (IFormFile file in image)
            {                                                   
                    string path = Path.Combine(uniqueFileName, file.FileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))

                    {
                        file.CopyTo(fileStream);
                    }

                }            
            return Path.Combine("./Areas/Admin/", "Image" + model.tensanpham);
        }
    }
}
