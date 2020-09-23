using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace CZBK.TestProject.WebApp._2014_11_8
{
    /// <summary>
    /// ImageCreate 的摘要说明
    /// </summary>
    public class ImageCreate : IHttpHandler
    {

        public void ProcessRequestAsync(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
          //访问该页面创建一张图片，并且该图片上写字.
            using (Bitmap map = new Bitmap(300, 400))//创建了一个画布
            {
                using (Graphics g = Graphics.FromImage(map))//为画布创建了一个画笔
                {
                    g.Clear(Color.Azure);
                    g.DrawString("传智播客", new Font("黑体", 14.0f, FontStyle.Bold), Brushes.Red, new PointF(80,90));
                    string fileName = Guid.NewGuid().ToString();
                    map.Save(context.Request.MapPath("/ImagePath/"+fileName+".jpg"),System.Drawing.Imaging.ImageFormat.Jpeg);//保存图片.
                }
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}