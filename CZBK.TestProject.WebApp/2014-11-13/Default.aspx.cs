using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.TestProject.WebApp._2014_11_13
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
         Response.Write(this.GetType().Assembly.Location + "<br/>");
         Button button2 = new Button();
         button2.Text = "Btton2";
         button2.ID = "btn";
          
            button2.Click+=button2_Click;
         this.form1.Controls.Add(button2);
        }
        protected void button2_Click(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}