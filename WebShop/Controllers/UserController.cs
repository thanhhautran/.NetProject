using Microsoft.AspNetCore.Mvc;
using Project.Models.DAO;
using ProjectCore.Models.DAO;
using WebShop.Models;
using System;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Facebook;
using Microsoft.AspNetCore.Session;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using WebShop.Helpers;
using System.Security.Cryptography;
using System.Text;
using ASPSnippets.GoogleAPI;
using System.Net;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.Extensions;

namespace ProjectCore.Controllers
{
    public class UserController : Controller
    {
        private Uri RedirectUri
        {
            get
            {
                var uriBuilder = new UriBuilder(Request.GetEncodedUrl());
                uriBuilder.Query = null;
                uriBuilder.Fragment = null;
                uriBuilder.Path = Url.Action("FacebookCallback");
                return uriBuilder.Uri;
            }
        }
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
                    kh.diachi = model.diachi;
                    kh.roleTableid = 1;
                    var stringUser = JsonConvert.SerializeObject(kh);
                    string ranString = createRandomString();
                    string body = "ma xac thuc cua ban la" + ranString;
                    ViewBag.stringUser = stringUser;
                    ViewBag.ranString = ranString;
                    new MailHelper().sendMail(model.email,"xac thuc email",body);
                    return View("ConfirmMail");
                }
            }
            return View(model);
        }
       
        [HttpGet]
        public ActionResult LoginFacebook()
        {
            var fb = new FacebookClient();
            var loginUrl = fb.GetLoginUrl(new
            {
                client_id = "1209214939431822",
                client_secret = "13d54191c846d58191b93b25ee295daa",
                redirect_uri = RedirectUri.AbsoluteUri,
                response_type = "code",
                scope = "email",
            });

            return Redirect(loginUrl.AbsoluteUri);
        }
        public ActionResult FacebookCallback(string code)
        {
            var fb = new FacebookClient();
            dynamic result = fb.Post("oauth/access_token", new
            {
                client_id = "1209214939431822",
                client_secret = "13d54191c846d58191b93b25ee295daa",
                redirect_uri = RedirectUri.AbsoluteUri,
                code
            });


            var accessToken = result.access_token;
            if (!string.IsNullOrEmpty(accessToken))
            {
                fb.AccessToken = accessToken;
                // Get the user's information, like email, first name, middle name etc
                dynamic me = fb.Get("me?fields=first_name,last_name,id,email");
                string email = me.email;

                var kh = new khachhang();
                kh.taikhoan = email;
                kh.email = email;
                string pass = encryption(email);
                kh.matkhau = pass;
                UserDAO ud =  new UserDAO();
                ud.insertUser(kh);
                SessionHelper.setObjectAsJson(HttpContext.Session, "User_Session", kh);

            }
            return Redirect("/");
        }
        [HttpPost]
        public void LoginWithGooglePlus()
        {
            GoogleConnect.ClientId = "831581208531-6rl0srsg18if16a6mcij9uhau2g90nsc.apps.googleusercontent.com";
            GoogleConnect.ClientSecret = "bctO56iTrnMnumggjBnA3S2D";
           // GoogleConnect.RedirectUri = Request.Url.AbsoluteUri.Split('?')[0];
            GoogleConnect.Authorize("profile", "email");
        }
        public IActionResult InsertUser(string mailConfirm,string khachhangInfor,string ranString)
        {
            if (mailConfirm.Equals(ranString))
            {
                khachhang kh =JsonConvert.DeserializeObject<khachhang>(khachhangInfor);
                var dao = new UserDAO();
                dao.insertUser(kh);
                return Redirect("Login");
            }
            String errors = "ten dang nhap khong chinh xac";
            ViewBag.errors = errors;
            return Redirect("ConfirmMail");
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
            String newPass = createRandomString();
            ud.updatePassword(user.taikhoan, encryption(newPass));
            
            string body = "mat khau moi cua ban la: " + newPass + " hoac truy cap vao duong link sau de lay lai mat khau:"+ "https://localhost:44334/User/Login";
            var emailString = user.email;
            new MailHelper().sendMail(emailString,"Quen mat khau",body);
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
        public string createRandomString()
        {
            var data = new byte[6];
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            rng.GetBytes(data);
            String ranString = "";
            for (int i = 0; i < 6; i++)
            {
                ranString += data[i];
            }
            return ranString;
        }
    }
}