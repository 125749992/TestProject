using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace CZBK.TestProject.WebApp._2014_11_08
{
    /// <summary>
    /// Login 的摘要说明
    /// </summary>
    public class Login : IHttpHandler
    {

        public async System.Threading.Tasks.Task ProcessRequestAsync(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            HttpClient hc = new HttpClient();
            //hc.BaseAddress = new Uri("http://localhost:6074/2014-11-08/index.html");
            var param = new Dictionary<string, string> { { "Id", "10" }, { "Name", "Tom Post" }, { "Age", "10" }, { "Birthday", DateTime.Now.ToString("yyyyMMdd") } };
            var test =hc.PostAsync("http://localhost:6074/2014-11-08/HttpClientTest.ashx", new FormUrlEncodedContent(param)).Result;

            string str = await test.Content.ReadAsStringAsync();
            context.Response.Write(str);
            // context.Response.Write("Hello Word");
        }

        public void ProcessRequest(HttpContext context)
        {
            throw new NotImplementedException();
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