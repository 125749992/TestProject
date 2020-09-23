using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZBK.TestProject.WebApp._2014_11_8.aspxCURD
{
    /// <summary>
    /// Delete 的摘要说明
    /// </summary>
    public class Delete : IHttpHandler
    {

        public void ProcessRequestAsync(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id;
            if (int.TryParse(context.Request.QueryString["id"],out id))
            {
                BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
                if (UserInfoService.DeleteEntity(id))
                {
                    context.Response.Redirect("Index.aspx");
                }
                else
                {
                    context.Response.Write("删除失败");
                }
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