using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CustomMiddlewarePractice.Middleware
{
    public class CustomeDebugConsoleMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomeDebugConsoleMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            Debug.WriteLine($"++++Request ask for : {httpContext.Request.Path}");
            //call next middleware delegate in the pipeline
            await _next.Invoke(httpContext);
        }

    }
}
