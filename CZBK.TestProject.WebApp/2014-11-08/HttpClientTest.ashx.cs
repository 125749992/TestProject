using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZBK.TestProject.WebApp
{
    /// <summary>
    /// HttpClientTest 的摘要说明
    /// </summary>
    public class HttpClientTest : IHttpHandler
    {

        public void ProcessRequestAsync(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World2323");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}