﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Models.DAO;
using ProjectCore.Models;
using WebShop.Areas.Admin.Data;
using WebShop.Areas.Admin.Models;
using WebShop.Helpers;

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
        
        readonly IWebHostEnvironment webHostEnvironment;
        public TableController(IWebHostEnvironment hostEnvironment)
        {
            this.adminProductDao = new ProductDao();
            this.adminUserDao = new UserDao();
            this.pt = new ProjectContext();
            this.listOrder = adminProductDao.getOrder();
            this.listUser = adminUserDao.getUser(0);
            this.listProduct = adminProductDao.getAllProduct();
            
            this.webHostEnvironment = hostEnvironment;
        }

        [HttpGet("/Admin/Table/Index")]
        public IActionResult Index()
        {
            ViewBag.listProduct = adminProductDao.getAllProduct();
            ViewBag.ListOrder = this.listOrder;
            ViewBag.listUser = this.listUser;
            //Session
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("Table");
        }


        [HttpGet("/Admin/Table/DeleteItem")]
        public IActionResult DeleteItem([FromQuery] int id)
        {
            var item = pt.Sanpham.SingleOrDefault(s => s.id == id);
            var spec = pt.Thongso.SingleOrDefault(s => s.id == item.id);
            String[] splitInfo = item.hinhanhsanpham.Split("/");
            if (splitInfo.Length == 3) { 
            String path = Path.Combine("wwwroot", splitInfo[0], splitInfo[1]);
            Directory.Delete(path, true);
        }
            pt.Sanpham.Remove(item);
            pt.Thongso.Remove(spec);
            pt.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/Admin/Table/EditOrder")]
        public IActionResult DisplayEditOrder([FromQuery] int id)
        {
            var order = pt.DonHang.SingleOrDefault(i => i.id == id);
            ViewBag.Id = id;
            ViewBag.Order = order;
            //Session
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("EditOrderForm");
        }

        [HttpPost("/Admin/Table/FilterOrder")]
        public IActionResult FilterOrder()
        {
            int filterType = Convert.ToInt32(HttpContext.Request.Form["orderFilter"]);

            if (filterType == 1)
            {
                this.listOrder = pt.DonHang.Where(d => d.ngaygiaodich.Value.Month == DateTime.Now.Month && d.ngaygiaodich.Value.Year == DateTime.Now.Year).ToList();
            }
            if (filterType == 3)
            {
                this.listOrder = pt.DonHang.Where(d => d.ngaygiaodich.Value.Month >= DateTime.Now.Month - 3 && d.ngaygiaodich.Value.Year == DateTime.Now.Year).ToList();
            }
            //Session
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return this.Index();
        }
        [HttpPost("/Admin/Table/FilterUser")]
        public IActionResult FilterUser()
        {
            int filterType = Convert.ToInt32(HttpContext.Request.Form["userFilter"]);

            if (filterType != 0)
            {
                this.listUser = pt.Khachhang.Where(k => k.roleTableid == filterType).ToList();
            }
            //Session
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return this.Index();
        }

        [HttpPost("/Admin/Table/FilterProduct")]
        public IActionResult FilterProduct()
        {
            var filterType = HttpContext.Request.Form["productFilter"].ToString();

            this.listProduct = pt.Sanpham.Where(s => s.danhmuc.loaiSanPham == filterType).ToList();

            //Session
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;

            return this.Index();
        }


        [HttpGet("/Admin/Edit")]
        public IActionResult DisplayEditITem([FromQuery] int id)
        {
            var item = pt.Sanpham.SingleOrDefault(i => i.id == id);

            var spec = pt.Thongso.SingleOrDefault(i => i.id == item.thongsoid);
            ViewBag.id = id;
            ViewBag.Item = item;
            ViewBag.Spec = spec;
            //Session
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View("EditItemForm");
        }

        [HttpPost("/Admin/Table/EditOrder")]
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



                if (model.trangthai == "Canceled")
                {
                    var ctdh = pt.Chitietdonhang.Where(c => c.donhangid == id).ToList();
                    foreach(var i in ctdh) {
                        ProductDAO.changeAmount((int)i.sanphamid, (int)i.soluong, true);
                     }
                } 
                    pt.SaveChanges();
                //Session
                var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
                ViewBag.user = user;
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return DisplayEditOrder(id);
            }
        }

        [HttpPost("/Admin/Table/EditItem")]
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
                if(uniqueFileName!=null)
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
                //Session
                var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
                ViewBag.user = user;
                return RedirectToAction(nameof(Index));
            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                ViewBag.Mess = errors;
                //Session
                var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
                ViewBag.user = user;
                return View("EditItemForm");
            }
        }

        [HttpPost("/Admin/Table/ChangeRole")]
        public IActionResult ChangeRole([FromQuery] int id)
        {
            var role = Convert.ToInt32(HttpContext.Request.Form["roleid"]);
            var user = pt.Khachhang.SingleOrDefault(u => u.id == id);

            user.roleTableid = role;
            pt.SaveChanges();

            return RedirectToAction(nameof(Index));

        }


        [HttpPost("/Admin/Table/AddItem")]
        [ValidateAntiForgeryToken]
        public IActionResult AddItem(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadImage(model);
                ViewBag.know = uniqueFileName;

                thongso spec = new thongso
                {
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


                sanpham product = new sanpham
                {

                    tensanpham = model.tensanpham,
                    cosan = model.cosan,
                    thongso = spec,
                    gia = model.gia,
                    danhmucid = model.danhmucid,
                    mausac = model.mausac,
                    phanTramGiamGia = model.phanTramGiamGia,
                    soluong = model.soluong,
                    uudai = model.uudai,
                    ngayNhapHang = DateTime.Now


                };
                if (uniqueFileName != null)
                    product.hinhanhsanpham = uniqueFileName;
                pt.Add(product);
                pt.Add(spec);
 
                pt.SaveChanges();

                changeSpecID();
               

                return RedirectToAction(nameof(Index));
            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                ViewBag.Mess = errors;
                //Session
                var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
                ViewBag.user = user;
                return View("AddItemForm");
            }
        }

        private void changeSpecID()
        {
            var ts = pt.Thongso.ToList();
            var id = ts[ts.Count() - 1].id;
            var tmpspec = pt.Thongso.SingleOrDefault(Ts => Ts.id == id);
            var tmpitem = pt.Sanpham.SingleOrDefault(Ts => Ts.id == id);
            tmpitem.thongsoid = tmpspec.id;
            pt.SaveChanges();
        }

        public string UploadImage(ProductModel model)
        {
            if ( null == model.hinhanhsanpham || model.hinhanhsanpham.Length != 0)
            {
                string uniqueFileName = null;
                uniqueFileName = Path.Combine(webHostEnvironment.WebRootPath, "ProductImages/" + model.tensanpham + "/");

                if (Directory.Exists(uniqueFileName))
                {
                    Directory.Delete(uniqueFileName, true);
                }
                Directory.CreateDirectory(uniqueFileName);
                String result = "";

                var image = model.hinhanhsanpham;
                if (image != null)
                {
                    int i = 1;
                    foreach (IFormFile file in image)
                    {
                        string path = Path.Combine(uniqueFileName, i + Path.GetExtension(file.FileName));
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        { 
                            if (i == 1)
                            {
                                result = Path.Combine("ProductImages/", model.tensanpham +"/", i + Path.GetExtension(file.FileName));
                            }
                        
                            file.CopyTo(fileStream);
                        }
                        i++;
                    }
                }

                return result;
            }
            else return null;
        }
    }
}
