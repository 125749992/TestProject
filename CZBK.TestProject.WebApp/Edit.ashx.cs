using CZBK.TestProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
namespace CZBK.TestProject.WebApp
{
    /// <summary>
    /// Edit 的摘要说明
    /// </summary>
    public class Edit : IHttpHandler
    {

        public void ProcessRequestAsync(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            int id;
            if (int.TryParse(context.Request.QueryString["id"], out id))
            {
                BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
                UserInfo userInfo =UserInfoService.GetModel(id);
                string filePath = context.Request.MapPath("Edit.html");
                string fileContent = File.ReadAllText(filePath);
               fileContent= fileContent.Replace("$txtName",userInfo.UserName).Replace("$txtPwd",userInfo.UserPass).Replace("$txtEmail",userInfo.Email).Replace("$txtRegTime",userInfo.RegTime.ToString()).Replace("$txtId",userInfo.ID.ToString());
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