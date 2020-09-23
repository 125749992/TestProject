using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.TestProject.WebApp._2014_11_11
{
    public partial class Cookie_Demo2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["cp1"] != null)//判断Cookie中的是否有值。
            {
                string value = Request.Cookies["cp1"].Value;//获取Cookie的值.
                Response.Write(value);
            }
        }
    }
}