﻿using Microsoft.EntityFrameworkCore;
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
            return pt.Khachhang.Include(k =>k.roleTable).SingleOrDefault(x => x.taikhoan == userName);
        }
        public khachhang getUser(int id)
        {
            return pt.Khachhang.SingleOrDefault(x => x.id == id);
        }
        public Boolean isExistsUser(String userName)
        {
            return pt.Khachhang.Count(x => x.taikhoan == userName) > 0;
        }
        public void updatePassword(string username,string password)
        {
            var kh = pt.Khachhang.SingleOrDefault(x => x.taikhoan == username);
            if (kh != null)
            {
                kh.matkhau = password;
                pt.SaveChanges();
            }
        }
        public void updatePersonalInfor(int id,string sdt,string email,string diachi,string hoten)
        {
            var kh = pt.Khachhang.SingleOrDefault(x => x.id == id);
            if (kh != null)
            {
                kh.email = email;
                kh.sdt = sdt;
                kh.diachi = diachi;
                kh.hoten = hoten;
                pt.SaveChanges();
            }
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
