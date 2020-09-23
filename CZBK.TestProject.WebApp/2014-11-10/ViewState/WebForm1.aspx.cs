using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.TestProject.WebApp._2014_11_10.ViewState
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
                this.GridView1.DataSource = UserInfoService.GetEntityList();
                this.GridView1.DataBind();
            }
        }
    }
}