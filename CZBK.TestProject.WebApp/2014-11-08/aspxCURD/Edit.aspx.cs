using CZBK.TestProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.TestProject.WebApp._2014_11_8.aspxCURD
{
    public partial class Edit : System.Web.UI.Page
    {
        public UserInfo Users { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
            if (!IsPostBack)
            {
                //查询要修改的数据.
                int id;
                if (int.TryParse(Request.QueryString["id"], out id))
                {
                    Users = UserInfoService.GetModel(id);
                }
                else
                {
                    Response.Write("参数错误!!");
                }
            }
            else
            {
                //更新 修改的数据.
                UserInfo userInfo = new UserInfo();
                userInfo.UserName=Request.Form["txtName"];
                userInfo.UserPass = Request.Form["txtPwd"];
                userInfo.Email = Request.Form["txtEmail"];
                userInfo.RegTime =Convert.ToDateTime(Request.Form["txtRegTime"]);
                userInfo.ID =Convert.ToInt32(Request.Form["txtId"]);
                if (UserInfoService.UpdateEntity(userInfo))
                {
                    Response.Redirect("Index.aspx");
                }
                else
                {

                }

            }
        }
    }
}