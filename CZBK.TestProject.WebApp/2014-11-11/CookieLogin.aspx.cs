using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.TestProject.WebApp._2014_11_11
{
    public partial class CookieLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                CheckUserLogin();
            }
            else
            {
                CheckCookieInfo();
            }
        }
        /// <summary>
        /// 对Cookie中存储的信息进行校验
        /// </summary>
        public void CheckCookieInfo()
        {
            if (Request.Cookies["cp1"] != null && Request.Cookies["cp2"] != null)
            {
                string userName = Request.Cookies["cp1"].Value;
                string userPwd = Request.Cookies["cp2"].Value;
                //判断Cookie中存储的用户名是否正确.
                if (userName == "itcast")
                {
                    if (userPwd == Common.WebCommon.GetMd5String(Common.WebCommon.GetMd5String("123")))
                    {
                        //给Session赋值.
                        Response.Redirect("Test.aspx");
                    }
                }
                Response.Cookies["cp1"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["cp2"].Expires = DateTime.Now.AddDays(-1);
              
            }
        }

        /// <summary>
        /// 判断用户名密码是否正确，用户登录
        /// </summary>
        public void CheckUserLogin()
        {
            string userName=Request.Form["txtName"];
            string userPwd=Request.Form["txtPwd"];
            if (userName == "itcast" && userPwd == "123")
            {
                //给Session赋值.
                if (!string.IsNullOrEmpty(Request.Form["checkMe"]))//表示用户选择了复选框.只会将选中的复选框的值提交到服务端
                {
                    HttpCookie cookie1 = new HttpCookie("cp1",userName);
                    HttpCookie cookie2 = new HttpCookie("cp2", Common.WebCommon.GetMd5String(Common.WebCommon.GetMd5String(userPwd)));
                    cookie1.Expires = DateTime.Now.AddDays(3);
                    cookie2.Expires = DateTime.Now.AddDays(3);
                    Response.Cookies.Add(cookie1);
                    Response.Cookies.Add(cookie2);
                }
                Response.Redirect("Test.aspx");
            }
        }
    }
 
}