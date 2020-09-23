using CZBK.TestProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.IO;
namespace CZBK.TestProject.WebApp
{
    /// <summary>
    /// UserInfoList 的摘要说明
    /// </summary>
    public class UserInfoList : IHttpHandler
    {

        public void ProcessRequestAsync(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
           List<UserInfo>list= UserInfoService.GetEntityList();
           // List<UserInfo>list=UserInfoService.GetEntityList();
            StringBuilder sb = new StringBuilder();
            foreach (UserInfo userInfo in list)
            {
                sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td><a href='ShowDetail.ashx?id={5}'>详细</a></td><td>删除</td><td><a href='Edit.ashx?id={5}'>修改</a></td></tr>", userInfo.ID, userInfo.UserName, userInfo.UserPass, userInfo.RegTime.ToShortDateString(), userInfo.Email, userInfo.ID);
            }
            string filePath = context.Request.MapPath("UserInfoList.html");
            string fileContent = File.ReadAllText(filePath);
           fileContent= fileContent.Replace("$tbody",sb.ToString());
           context.Response.Write(fileContent);
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