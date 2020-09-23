using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace WebApplication1
{
    /// <summary>
    /// ClientWeb 的摘要说明
    /// </summary>
    public class ClientWeb : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            HttpClient hc = new HttpClient();
            HttpRequestMessage hrm = new HttpRequestMessage();
            hrm.RequestUri = new Uri("http://localhost:14687/ServerWeb.ashx");
            hrm.Method = HttpMethod.Post;
            Dictionary<string, string> param = new Dictionary<string, string>() { { "Name", "MrLi" }, { "Birthday",DateTime.Now.ToLongDateString()} };
            hrm.Content=new FormUrlEncodedContent(param);
           var res= hc.SendAsync(hrm).Result;
            if (res.IsSuccessStatusCode)
            {
                var str = res.Content.ReadAsByteArrayAsync().Result;
                context.Response.Clear();
                context.Response.ContentType = "image/jpeg";
                context.Response.BinaryWrite(str);
            }
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