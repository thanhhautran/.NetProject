using Microsoft.EntityFrameworkCore;
using Model.POJOs;
using Project.Models.DAO;
using SshNet.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace ProjectCore.Models.DAO
{
    public class UserDAO
    {
        ProjectContext pt = null;
        public UserDAO()
        {
            pt = new ProjectContext();
        }
        public khachhang GetById(string userName)
        {
            return pt.Khachhang.SingleOrDefault(x => x.taikhoan == userName);
        }
        public Boolean isExistsUser(String userName)
        {
            return pt.Khachhang.Count(x => x.taikhoan == userName) >0;
        }
        public int insertUser(khachhang kh)
        {
            pt.Khachhang.Add(kh);
            pt.SaveChanges();
            return kh.id;
        }
        public int checkUser(string username, string password)
        {
            var result = pt.Khachhang.SingleOrDefault(x => x.taikhoan == username);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (result.matkhau == password)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        public String getUserRole(int iduser)
        {
            var userRole = pt.RoleTable.SingleOrDefault(x => x.id == iduser);
            string result = userRole.role_name;
            return result;
        }
    }
}
