using Microsoft.EntityFrameworkCore;
using Project.Models.DAO;
using SshNet.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;

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
       public static List<usertable> getAllUser()
        {
            using(var context = new ProjectContext())
            {
                var users = context.usertable.Include(p => p.roletable);
                List < usertable > userslist = users.ToList();
                return userslist;    
            }    
        }
    }
}
