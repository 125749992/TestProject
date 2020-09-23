using CZBK.TestProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.TestProject.WebApp._2014_11_8.aspxCURD
{
    public partial class AddUserInfo : System.Web.UI.Page
    {
        public string ErrorMsg { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //当前用户通过Index.aspx页面中“添加用户”链接跳转到该页面时，这是一次get请求，所以不会提交表单，拿不到隐藏域的值。当前页面显示完成，用户在表单中输入数据以后单击提交，这是一次post请求，那么这次请求会将表单中的隐藏提交到服务端。
            //if (!string.IsNullOrEmpty(Request.Form["isPostBack"]))
            if(IsPostBack)//如果你是get过来的那么这个值为false,如果是post过来的该为true.通过判断名称为__VIEWSTATE这个隐藏域，能否获取到该隐藏域的值，来判断。
            {
                UserInfo userInfo = new UserInfo();
                userInfo.UserName = Request.Form["txtName"];
                userInfo.UserPass=Request.Form["txtPwd"];
                userInfo.Email=Request.Form["txtEmail"];
                userInfo.RegTime = DateTime.Now;
                BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
                if (UserInfoService.InsertEntity(userInfo))
                {
                    Response.Redirect("Index.aspx");
                }
                else
                {
                    ErrorMsg = "添加失败";
                }

            }
          
        }
    }
}