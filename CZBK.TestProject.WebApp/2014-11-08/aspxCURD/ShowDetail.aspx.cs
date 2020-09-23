using CZBK.TestProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.TestProject.WebApp._2014_11_8.aspxCURD
{
    public partial class ShowDetail : System.Web.UI.Page
    {
        public UserInfo Users { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(Request.QueryString["id"], out id))
            {
                BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
                UserInfo userInfo=UserInfoService.GetModel(id);
                Users = userInfo;
            }
        }
    }
}