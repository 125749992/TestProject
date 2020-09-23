using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace CZBK.TestProject.WebApp
{
    /// <summary>
    /// Thum 的摘要说明
    /// </summary>
    public class Thum : IHttpHandler
    {

        public void ProcessRequestAsync(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string filePath = context.Request.MapPath("/ImagePath/mm.jpg");
            //using (Bitmap map = new Bitmap(40, 40))
            //{
            //    using (Graphics g = Graphics.FromImage(map))
            //    {
            //        using (Image image = Image.FromFile(filePath))
            //        {
            //            g.DrawImage(image, new Rectangle(0,0,map.Width,map.Height));
            //            string fileName=Guid.NewGuid().ToString();
            //            map.Save(context.Request.MapPath("/ImagePath/"+fileName+".jpg"),System.Drawing.Imaging.ImageFormat.Jpeg);
            //        }
            //    }
            //}
             string fileName=Guid.NewGuid().ToString();
             Common.ImageHelper.MakeThumbnail(filePath, context.Request.MapPath("/ImagePath/" + fileName + ".jpg"), 40, 40, "W");
            // context.Response.Write();
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