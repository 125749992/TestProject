using CZBK.TestProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.TestProject.WebApp._2014_11_13
{
    public partial class Login : System.Web.UI.Page
    {
        BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
        public string ErrorMsg { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //服务端也要校验.(与客户端校验自己完成)
            //1.判断验证码是否正确
            if (IsPostBack)//表示用户单击了登录按钮
            {
                if (CheckValidateCode())
                {
                    UserLoginIn();
                }
                else
                {
                    ErrorMsg = "验证码错误!!";
                }
            }
            else//表示GET请求
            {
                CheckCookieInfo();//校验Cookie信息
            }
            
        }
        protected void CheckCookieInfo()
        {
            //判断Cookie中是否有值
            if (Request.Cookies["cp1"] != null && Request.Cookies["cp2"] != null)
            {
                string userName = Request.Cookies["cp1"].Value;
                string userPwd = Request.Cookies["cp2"].Value;
                //判断Cookie中存储的用户名是否正确
                UserInfo userInfo=UserInfoService.GetModel(userName);
                if (userInfo != null)
                {
                    //判断密码是否正确.
                    if (userPwd == Common.WebCommon.GetMd5String(Common.WebCommon.GetMd5String(userInfo.UserPass)))
                    {
                        Session["userInfo"] = userInfo;
                        Response.Redirect("AdminIndex.aspx");
                    }
                }
                Response.Cookies["cp1"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["cp2"].Expires = DateTime.Now.AddDays(-1);
            }
        }
        protected void UserLoginIn()
        {
            string userName = Request.Form["txtClientID"];
            string userPwd = Request.Form["txtPassword"];
            string msg = string.Empty;
            UserInfo userInfo=null;
           bool b= UserInfoService.CheckUserInfo(userName, userPwd,out msg,out userInfo);
           if (b)
           {
               Session["userInfo"] = userInfo;
               //判断用户是否选择了记住我
               if (!string.IsNullOrEmpty(Request.Form["CheckMe"]))
               {
                   HttpCookie cookie1 = new HttpCookie("cp1",userName);
                   HttpCookie cookie2 = new HttpCookie("cp2", Common.WebCommon.GetMd5String(Common.WebCommon.GetMd5String(userPwd)));
                   cookie1.Expires = DateTime.Now.AddDays(3);
                   cookie2.Expires = DateTime.Now.AddDays(3);
                   Response.Cookies.Add(cookie1);
                   Response.Cookies.Add(cookie2);
               }
               Response.Redirect("AdminIndex.aspx");
           }
           else
           {
               ErrorMsg = msg;
           }
        }
        /// <summary>
        /// 对验证码进行校验
        /// </summary>
        /// <returns></returns>
        protected bool CheckValidateCode()
        {
            bool isSuccess = false;
            if (Session["code"] != null)
            {
                string sysCode = Session["code"].ToString();
                string txtCode = Request.Form["txtCode"];
                if (sysCode.Equals(txtCode, StringComparison.InvariantCultureIgnoreCase))
                {
                    Session["code"] = null;
                   // Session.Remove("code");
                    isSuccess = true;
                }
            }
            return isSuccess;
            
        }
    }
  
}