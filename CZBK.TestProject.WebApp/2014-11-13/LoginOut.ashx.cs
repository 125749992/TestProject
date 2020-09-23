using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZBK.TestProject.WebApp._2014_11_13
{
    /// <summary>
    ///退出用户登录。如果有记住我这个功能，一定要清除Cookie.
    /// </summary>
    public class LoginOut : IHttpHandler,System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequestAsync(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Session["userInfo"] != null)
            {
                context.Session["userInfo"] = null;
                context.Response.Cookies["cp1"].Expires = DateTime.Now.AddDays(-1);
                context.Response.Cookies["cp2"].Expires = DateTime.Now.AddDays(-1);
                context.Response.Redirect("Login.aspx");
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