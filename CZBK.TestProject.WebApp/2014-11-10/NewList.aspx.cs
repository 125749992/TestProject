using CZBK.TestProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.TestProject.WebApp._2014_11_10
{
    public partial class NewList : System.Web.UI.Page
    {
        public string StrHtml { get; set; }
        public int PageCount { get; set; }
        public int PageIndex { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.UserInfoService UserInfoService = new BLL.UserInfoService();

            int pageIndex;
            if(!int.TryParse(Request.QueryString["pageIndex"],out pageIndex))//获取当前页码
            {
                pageIndex=1;
            }
            int pageSize=5;//每页显示记录数。
            int pageCount = UserInfoService.GetPageCount(pageSize);//获取总页数
            PageCount = pageCount;
            //确定pageIndex的取值范围.
            pageIndex = pageIndex < 1 ? 1 : pageIndex;
            pageIndex = pageIndex > pageCount ? pageCount : pageIndex;
            PageIndex = pageIndex;
            List<UserInfo> list = UserInfoService.GetPageEntityList(pageIndex,pageSize);//获取分页数据

            StringBuilder sb = new StringBuilder();
            foreach (UserInfo userInfo in list)
            {
                sb.AppendFormat(" <li><span>{0}</span><a href='#' target='_blank'>{1}</a></li>",userInfo.RegTime.ToShortDateString(),userInfo.UserName);
            }
            StrHtml = sb.ToString();
        }
    }
}