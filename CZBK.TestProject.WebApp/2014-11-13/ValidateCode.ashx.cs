using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZBK.TestProject.WebApp._2014_11_13
{
    /// <summary>
    /// ValidateCode 的摘要说明
    /// </summary>
    
    public class ValidateCode : IHttpHandler,System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequestAsync(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            Common.ValidateCode validateCode = new Common.ValidateCode();
           string code=validateCode.CreateValidateCode(4);
           context.Session["code"] = code;
           validateCode.CreateValidateGraphic(code, context);

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