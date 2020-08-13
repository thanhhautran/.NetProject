using Microsoft.EntityFrameworkCore;
using Project.Models.DAO;
using SshNet.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;

using System.Text;

namespace ProjectCore.Models.DAO
{
    public class UserDAO
    {
        public static usertable checkUser(string username, string password)
        {
            var p = MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(password));
            string encodedPassWord = Encoding.ASCII.GetString(p);
            using (var context = new ProjectContext())
            {
                var user = context.usertable
                  .Include(p => p.roletable).Where(p => p.username == username).
                  Where(p => p.password == encodedPassWord).FirstOrDefault();
                return user;
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
