using CZBK.TestProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZBK.TestProject.WebApp
{
    /// <summary>
    /// ProcessEdit 的摘要说明
    /// </summary>
    public class ProcessEdit : IHttpHandler
    {

        public void ProcessRequestAsync(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
          //  UserInfo userInfo = new UserInfo();
            //userInfo.UserName=context.Request.Form["txtName"];
            //userInfo.UserPass=context.Request.Form["txtPwd"];
            //userInfo.RegTime = Convert.ToDateTime(context.Request.Form["txtRegTime"]);
            //userInfo.Email=context.Request.Form["txtEmail"];
            int id=Convert.ToInt32(context.Request.Form["txtId"]);
            BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
            UserInfo userInfo=UserInfoService.GetModel(id);//查询一下，然后再修改,
            userInfo.UserName = context.Request.Form["txtName"];
            userInfo.UserPass = context.Request.Form["txtPwd"];
            if (UserInfoService.UpdateEntity(userInfo))
            {
                context.Response.Redirect("UserInfoList.ashx");
            }
            else
            {
                context.Response.Write("修改失败");
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