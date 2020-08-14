
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;
using Project.Models.DAO;
using ProjectCore.Models.DAO;
using Renci.SshNet;
using WebShop.Models;

namespace ProjectCore.Controllers
{
    public class UserController : Controller
    {
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
        public IActionResult Register(LoginModel model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDAO();
                var result = dao.checkUser(model.taikhoan, model.matkhau);
                if (result == 1)
                {
                    var user = dao.GetById(model.taikhoan);
                    var userSession = new khachhang();
                    userSession.idkhachhang = user.idkhachhang;
                    userSession.taikhoan = user.taikhoan;
                    //Session.Add("User_Session", userSession);
                    return Redirect("/");
                }
                
            }
            return View(model);
        }
    }
}