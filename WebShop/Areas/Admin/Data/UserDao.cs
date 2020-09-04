using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;
using Microsoft.AspNetCore.Mvc;
using ProjectCore.Models;
using Project.Models.DAO;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.SqlServer;
using System.Security.Principal;

namespace WebShop.Areas.Admin.Data
{
    public class UserDao : Controller
    {
        ProjectContext dbContext = null;

        public UserDao()
        {
            this.dbContext = new ProjectContext();
        }

        public int totalUser()
        {
            return dbContext.Khachhang.Count();
        }

        public int totalProduct()
        {
            return Convert.ToInt32(dbContext.Sanpham.Sum(i => i.soluong));
        }

        public List<khachhang> getUser(int role)
        {
            if (role == 0)
            {
                return dbContext.Khachhang.ToList();
            }
            else
            {
                return dbContext.Khachhang.Where(i => i.roleTable.id == role).ToList();
            }
        }
    }
}
