using CZBK.TestProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.TestProject.WebApp._2014_11_13
{
    public partial class AdminIndex :Common.CheckSessionState // System.Web.UI.Page
    {
        public UserInfo UserInfo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
          //  if (Session["userInfo"] == null)
            //{
             //   Response.Redirect("Login.aspx");
            //}
          ///  else
           // {
                UserInfo=(UserInfo)Session["userInfo"];
           // }
        }
    }
}