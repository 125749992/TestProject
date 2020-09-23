using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CZBK.TestProject.Common
{
    public class CheckSessionState : System.Web.UI.Page
    {
       protected void Page_Init(object sender, EventArgs e)
       {
           if (Session["userInfo"] == null)
           {
           Response.Redirect("Login.aspx");
           }
       }
    }
}
