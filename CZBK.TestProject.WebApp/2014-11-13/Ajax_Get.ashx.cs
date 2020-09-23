using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZBK.TestProject.WebApp._2014_11_13
{
    /// <summary>
    /// Ajax_Get 的摘要说明
    /// </summary>
    public class Ajax_Get : IHttpHandler
    {

        public void ProcessRequestAsync(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
           
           // context.Response.Write(DateTime.Now.ToString());

            //context.Request.HttpMethod;判断请求方式。
           string name= context.Request["name"];
            string pwd=context.Request["pwd"];
           context.Response.Write(name+":"+pwd);
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