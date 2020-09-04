using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Project.Models.DAO;
using ProjectCore.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Helpers;

namespace WebShop.authentication
{
    public class AuthenMiddle
    {
        private readonly RequestDelegate _next;
        public AuthenMiddle(RequestDelegate next)
        {
            _next = next;
        }
        public Task Invoke(HttpContext httpcontext)
        {
            var path = httpcontext.Request.Path;
            if(path.HasValue && (path.Value.StartsWith("/Admin") || path.Value.StartsWith("/admin")))
            {
                var text = httpcontext.Session.GetString("User_Session");
                
                if (text == null)
                {
                    httpcontext.Response.Redirect("/");
                }
                else  
                {
                    UserDAO ud = new UserDAO();
                    var user = JsonConvert.DeserializeObject<khachhang>(text);
                    String userRole = ud.getUserRole((int)user.roleTableid);
                    if (userRole.Equals("admin"))
                    {
                        httpcontext.Response.Redirect("");
                    }
                    else
                    {
                        httpcontext.Response.Redirect("/");
                    }
                }
            }
            return _next(httpcontext);
        }
    }
    public static class AuthenticationMiddlewareExtensions
    {
        public static IApplicationBuilder UseAuthenticationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthenMiddle>();
        }
    }
}
