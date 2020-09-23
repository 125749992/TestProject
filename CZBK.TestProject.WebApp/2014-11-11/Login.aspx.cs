using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.TestProject.WebApp._2014_11_11
{
    public partial class Login : System.Web.UI.Page
    {
        public string UserName;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["userName"] != null)
            {
                string name = Request.Cookies["userName"].Value;
                UserName = name;
                Response.Cookies["userName"].Value = name;
                Response.Cookies["userName"].Expires = DateTime.Now.AddDays(3);
            }
            else
            {
                if (IsPostBack)
                {
                   string name= Request.Form["txtName"];
                   Response.Cookies["userName"].Value = name;
                   Response.Cookies["userName"].Expires = DateTime.Now.AddDays(3);
                }
            }
        }
    }
}