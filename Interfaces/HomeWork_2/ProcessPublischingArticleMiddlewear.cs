using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace HomeWork_2
{
    public class ProcessPublischingArticleMiddlewear
    {
        private readonly RequestDelegate _requestDelegate;
        private readonly string _processPublischingArticleMiddlewear;

        public CustomMiddleware(RequestDelegate requestDelegate, string processPublischingArticleMiddlewear)
        {
            _requestDelegate = requestDelegate;
            _processPublischingArticleMiddlewear = processPublischingArticleMiddlewear;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await context.Response.WriteAsync(processPublischingArticle.ProcessPublischingArticle());
        }
    }
}
