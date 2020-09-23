using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZBK.TestProject.WebApp._2014_11_10.UrlReferrer
{
    /// <summary>
    /// ShowImage 的摘要说明
    /// </summary>
    public class ShowImage : IHttpHandler
    {

        public void ProcessRequestAsync(HttpContext context)
        {
            context.Response.ContentType = "image/jpeg";
          //  context.Request.UrlReferrer.Host
            context.Response.WriteFile(context.Request.MapPath("/ImagePath/mm.jpg"));
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