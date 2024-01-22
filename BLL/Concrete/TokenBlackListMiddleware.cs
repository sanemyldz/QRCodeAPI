using BLL.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TokenBlackListMiddleware
    {

        private readonly RequestDelegate _next;

        public TokenBlackListMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, ITokenBlacklistService blacklistService)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (blacklistService.IsTokenBlacklisted(token))
            {
                context.Response.StatusCode = 401; // Unauthorized
                await context.Response.WriteAsync("Unauthorized: Token is blacklisted");
            }
            else
            {
                await _next(context);
            }
        }

    }
}
