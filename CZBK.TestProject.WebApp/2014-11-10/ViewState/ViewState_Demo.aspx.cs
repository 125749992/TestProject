using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.TestProject.WebApp._2014_11_10.ViewState
{
    public partial class ViewState_Demo : System.Web.UI.Page
    {
        public int Count { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["count"] != null)
            {
                int count = Convert.ToInt32(ViewState["count"]);
                count++;
                Count = count;
            }
            ViewState["count"] = Count;
        }
    }
}