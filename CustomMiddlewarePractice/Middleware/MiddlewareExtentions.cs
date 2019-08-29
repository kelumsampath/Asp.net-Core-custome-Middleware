using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomMiddlewarePractice.Middleware
{
    public static class MiddlewareExtentions
    {
        public static IApplicationBuilder UseCustomeMiddleware(this IApplicationBuilder builder)
        {

            return builder.UseMiddleware<CustomeDebugConsoleMiddleware>();
        }
    }
}
