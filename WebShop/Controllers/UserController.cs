using Microsoft.AspNetCore.Mvc;
using Project.Models.DAO;
using ProjectCore.Models.DAO;
using WebShop.Models;
using System;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Session;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using WebShop.Helpers;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace ProjectCore.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var user = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.user = user;
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDAO();
                if (dao.isExistsUser(model.taikhoan))
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại");
                }
                else
                {
                    var kh = new khachhang();
                    kh.taikhoan = model.taikhoan;
                    kh.matkhau = encryption(model.matkhau);
                    kh.email = model.email;
                    kh.sdt = model.sdt;
                    kh.hoten = model.hoten;
                    var result = dao.insertUser(kh);
                    if (result > 0)
                    {
                        ViewBag.Success = "Đăng ký thành công";
                        return Redirect("Login");

                    }
                    else
                    {
                        ModelState.AddModelError("", "đăng ký thất bại");
                    }
                }
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {

            if (ModelState.IsValid)
            {
                var dao = new UserDAO();
                var result = dao.checkUser(model.taikhoan, encryption(model.matkhau));
                if (result == 1)
                {
                    var user = dao.GetById(model.taikhoan);
                    var userSession = new khachhang();
                    userSession.id = user.id;
                    userSession.taikhoan = user.taikhoan;
                    userSession.email = user.email;
                    userSession.hoten = user.hoten;
                    userSession.diachi = user.diachi;
                    userSession.sdt = user.sdt;
                    //String objectAsString = JsonConvert.SerializeObject(userSession);
                    //HttpContext.Session.SetString("User_Session", objectAsString);
                    SessionHelper.setObjectAsJson(HttpContext.Session, "User_Session", userSession);
                    return Redirect("/");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Mật khẩu không chính xác.");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại.");
                }

            }
            var userSess = SessionHelper.GetObjectFromJson<khachhang>(HttpContext.Session, "User_Session");
            ViewBag.userSess = userSess;
            return View(model);
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("User_Session");
            return Redirect("/");
        }
        [HttpGet]
        public IActionResult viewForgotPassword()
        {
            return View("ForgotPassword");
        }
        [HttpPost]
        public IActionResult forgotPassword(string username)
        {
            UserDAO ud = new UserDAO();
            var user = ud.GetById(username);
            var data = new byte[6];
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            rng.GetBytes(data);
            string body = "mat khau moi cua ban la:" + data.ToString() + "hoac truy cap vao duong link sau de lay lai mat khau:";
            var emailString = user.email;
            new MailHelper().sendMail(emailString,"Quen mat khau",body);
            ud.updatePassword(user.taikhoan, data.ToString());
            return View("Login");
        }
        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            StringBuilder encryptdata = new StringBuilder();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }
    }
}