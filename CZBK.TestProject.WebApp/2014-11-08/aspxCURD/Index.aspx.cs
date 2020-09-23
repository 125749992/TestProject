using CZBK.TestProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.TestProject.WebApp._2014_11_8.aspxCURD
{
    public partial class Index : System.Web.UI.Page
    {
        
       // public string StrHtml { get; set; }
        public List<UserInfo> UserInfoList { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
           List<UserInfo>list= UserInfoService.GetEntityList();
           UserInfoList = list;
         //  StringBuilder sb = new StringBuilder();
           //foreach (UserInfo userInfo in list)
           //{
           //    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td><a href='ShowDetail.ashx?id={5}'>详细</a></td><td>删除</td><td><a href='Edit.ashx?id={5}'>修改</a></td></tr>", userInfo.ID, userInfo.UserName, userInfo.UserPass, userInfo.RegTime.ToShortDateString(), userInfo.Email, userInfo.ID);
           //}
           //StrHtml = sb.ToString();
        }
    }
}