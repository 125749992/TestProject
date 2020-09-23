using System;

namespace CZBK.TestProject.WebApp._2014_11_10.Server
{
    public partial class HtmlEncode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Response.Write(Server.HtmlEncode(Request.Form["txtContent"]));
            }
        }
    }
}