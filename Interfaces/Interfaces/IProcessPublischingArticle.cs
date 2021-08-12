using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
namespace Interfaces
{
   public class ProcessPublischingArticleMiddlewear
    {
       
        public ProcessPublischingArticleMiddlewear(RequestDelegate next)
        {

        }
        public async Task InvokeAsync(HttpContext context, IProcessPublischingArticle processPublischingArticle)
        {
            await context.Response.WriteAsync(processPublischingArticle.ProcessPublischingArticle());
        }


    }
   public interface IProcessPublischingArticle
    {
        void ProcessPublischingArticle();
    }
}
