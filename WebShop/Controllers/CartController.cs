using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using MySqlX.XDevAPI;
using Project.Models.DAO;
using ProjectCore.Models;
using ProjectCore.Models.DAO;
using WebShop.Helpers;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class CartController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<chitietdonhang>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            return View("Cart");
        }
        public IActionResult Add(String id)
        {
            ProductDAO pd = new ProductDAO();
            if (SessionHelper.GetObjectFromJson<List<chitietdonhang>>(HttpContext.Session, "cart") == null)
            {
                List<giohang> cart = new List<giohang>();
                sanpham sp = pd.findProductById(id);
                giohang gh = new giohang();
                gh.sanpham = sp;
                gh.soluong = 1;
                cart.Add(gh);
                SessionHelper.setObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<giohang> cart = SessionHelper.GetObjectFromJson<List<giohang>>(HttpContext.Session, "cart");
                int isExist = InShoppingCart(id);
                if (isExist != -1)
                {
                    cart[isExist].soluong++;
                }
                else
                {
                    sanpham sp = pd.findProductById(id);
                    giohang gh = new giohang();
                    gh.sanpham = sp;
                    gh.soluong = 1;
                    cart.Add(gh);
                }
                SessionHelper.setObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(String id)
        {
            List<giohang> cart = SessionHelper.GetObjectFromJson<List<giohang>>(HttpContext.Session, "cart");
            int index = InShoppingCart(id);
            cart.RemoveAt(index);
            SessionHelper.setObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeleteAll()
        {
            List<chitietdonhang> cart = SessionHelper.GetObjectFromJson<List<chitietdonhang>>(HttpContext.Session, "cart");
            cart.Clear();
            SessionHelper.setObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CheckOut()
        {
            if (HttpContext.Session.GetString("User_Session") == null)
            {
                return RedirectToPage("Login");
            }
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            var cart = SessionHelper.GetObjectFromJson<List<chitietdonhang>>(HttpContext.Session, "cart");
            ViewBag.user = user;
            ViewBag.cart = cart;
            return View("CheckOut");
        }
        [HttpPost]
        public IActionResult ComputeCheckOut(CheckOutModel com)
        {
            CartDAO pd = new CartDAO();
            var cart = SessionHelper.GetObjectFromJson<List<chitietdonhang>>(HttpContext.Session, "cart");
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            donhang dh = new donhang
            {
                khachhangid = user.id,
                ngaygiaodich = DateTime.Now,
                ngaygiaohang = DateTime.Now,
                diachigiaohang = com.diachigiaohang,
                emailLienLac = com.email,
                sdtlienlac = com.sdt,
                giatridon = computeCart(cart)
            };
            int idHoaDOn = pd.writeRecipt(dh);
            for(int i = 0;i< cart.Count; i++)
            {
                chitietdonhang ctdh = new chitietdonhang
                {
                    donhangid = dh.id,
                    sanphamid = cart[i].sanpham.id,
                    tensanpham = cart[i].sanpham.tensanpham,
                    soluong = cart[i].soluong,
                    gia = cart[i].sanpham.gia,
                    tonggia = Convert.ToInt32(cart[i].sanpham.gia * cart[i].soluong)
                };
                pd.writeDetailReceipt(ctdh);
            }
            new MailHelper().sendMail(user.email,"","");
            return View();
        }
        public int InShoppingCart(String id)
        {
           int idnum  =  Int32.Parse(id);
            List<giohang> cart = SessionHelper.GetObjectFromJson<List<giohang>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].sanpham.id == idnum)
                {
                    return i;
                }
            }

            return -1;
        }
        public double computeCart(List<chitietdonhang> listCTDH)
        {
            double total = 0;
            for (int i = 0; i < listCTDH.Count; i++)
            {
                total += (double) (listCTDH[i].sanpham.gia * listCTDH[i].soluong);
            }
            return total;
        }
    }
}