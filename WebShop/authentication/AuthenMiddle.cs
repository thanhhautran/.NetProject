using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            if(path.HasValue && path.Value.StartsWith("/admin"))
            {
                if (httpcontext.Session.GetString("") == null)
                {
                    httpcontext.Response.Redirect("");
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
