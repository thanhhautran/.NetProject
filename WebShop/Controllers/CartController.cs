using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using MySqlX.XDevAPI;
using Project.Models.DAO;
using WebShop.Helpers;

namespace WebShop.Controllers
{
    public class CartController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<chitietdonhang>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            //ViewBag.total = cart.Sum(item => item.gia * item.soluong);
            return View("Cart");
        }
        public IActionResult Add(String id)
        {
            if (SessionHelper.GetObjectFromJson<List<chitietdonhang>>(HttpContext.Session, "cart") == null)
            {
                List<chitietdonhang> cart = new List<chitietdonhang>();
                cart.Add(new chitietdonhang { });
                SessionHelper.setObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<chitietdonhang> cart = SessionHelper.GetObjectFromJson<List<chitietdonhang>>(HttpContext.Session, "cart");
                int isExist = InShoppingCart(id);
                if (isExist != -1)
                {
                    cart[isExist].soluong++;
                }
                else
                {
                    cart.Add(new chitietdonhang { });
                }
                SessionHelper.setObjectAsJson(HttpContext.Session, "cart", cart);
            }

            return RedirectToAction("Index");
        }
        public IActionResult Delete(String id)
        {
            List<chitietdonhang> cart = SessionHelper.GetObjectFromJson<List<chitietdonhang>>(HttpContext.Session, "cart");
            int index = InShoppingCart(id);
            cart.RemoveAt(index);
            SessionHelper.setObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
        public int InShoppingCart(String id)
        {
            List<chitietdonhang> cart = SessionHelper.GetObjectFromJson<List<chitietdonhang>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].sanpham.id.Equals(id))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}