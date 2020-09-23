using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.TestProject.WebApp._2014_11_11
{
    public partial class Cookie_Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // Response.Cookies["cp1"].Value = DateTime.Now.ToString();//如果这样创建Cookie,是将cookie的数据存储到浏览器的内存中，如果浏览器关闭了，该数据也就没有了。
            Response.Cookies["cp1"].Value = "admin";
            Response.Cookies["cp1"].Path = "/2014-11-11";
           // Response.Cookies["cp1"].Domain = "baidu.com";
            Response.Cookies["cp1"].Expires = DateTime.Now.AddDays(3);//如果指定的了过期时间，Cookie会持久到客户端的磁盘上。
            //Cookie与具体的浏览器有关，不同的浏览器存储的Cookie的位置不一样。
            //所以说在IE下面创建了Cookie,在其它浏览器是无法获取的。
            //删除Cookie
            //Response.Cookies["cp1"].Expires = DateTime.Now.AddDays(-1);


        }
    }
}