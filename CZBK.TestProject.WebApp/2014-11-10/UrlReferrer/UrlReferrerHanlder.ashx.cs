using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZBK.TestProject.WebApp._2014_11_10.UrlReferrer
{
    /// <summary>
    /// UrlReferrerHanlder 的摘要说明
    /// </summary>
    public class UrlReferrerHanlder : IHttpHandler
    {

        public void ProcessRequestAsync(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            context.Response.Write(context.Request.UrlReferrer.ToString());
            context.Response.Write("<hr/>");
            context.Response.Write(context.Request.Url.ToString());
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