using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CZBK.TestProject.Model;
using System.IO;
namespace CZBK.TestProject.WebApp
{
    /// <summary>
    /// ShowDetail 的摘要说明
    /// </summary>
    public class ShowDetail : IHttpHandler
    {

        public void ProcessRequestAsync(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            int id;
            if (int.TryParse(context.Request.QueryString["id"], out id))
            {
                BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
                UserInfo userInfo=UserInfoService.GetModel(id);
                string filePath = context.Request.MapPath("ShowDetail.html");
                string fileContent = File.ReadAllText(filePath);
                fileContent = fileContent.Replace("$name", userInfo.UserName).Replace("$pwd",userInfo.UserPass);
                context.Response.Write(fileContent);
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