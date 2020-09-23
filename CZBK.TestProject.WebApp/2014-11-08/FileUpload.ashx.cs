using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Drawing;
namespace CZBK.TestProject.WebApp._2014_11_8
{
    /// <summary>
    /// FileUpload 的摘要说明
    /// </summary>
    public class FileUpload : IHttpHandler
    {

        public void ProcessRequestAsync(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            HttpPostedFile file=context.Request.Files["fileUp"];//接收文件数据.
            if (file == null)
            {
                context.Response.Write("请选择文件!!");
            }
            else
            {
                //判断上传的文件的类型.
               string fileName= Path.GetFileName(file.FileName);//获取文件名与扩张名. aa.jpg
               string fileExt = Path.GetExtension(fileName);//获取扩展名.
               if (fileExt == ".jpg"||fileExt==".gif")
               {
                   string dir = "/ImagePath/"+DateTime.Now.Year+"/"+DateTime.Now.Month+"/"+DateTime.Now.Day+"/";
                   //创建文件夹.
                   Directory.CreateDirectory(Path.GetDirectoryName(context.Request.MapPath(dir)));
                   //需要对上传的文件进行重命名.
                   string newfileName = Guid.NewGuid().ToString();
                   string fullDir = dir + newfileName + fileExt;//构建了完整文件路径.
                 //  file.SaveAs(context.Request.MapPath(fullDir));
                 //  file.SaveAs(context.Request.MapPath("/ImagePath/"+fileName));//保存文件
                   using (Image imge = Image.FromStream(file.InputStream))//根据上传的文件流创建Image
                   {
                       using (Bitmap map = new Bitmap(imge.Width,imge.Height))
                       {
                           using (Graphics g = Graphics.FromImage(map))
                           {
                               //设置高质量插值法
                               g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;

                               //设置高质量,低速度呈现平滑程度
                               g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                               //先将图片画到画布上.
                               g.DrawImage(imge, new Rectangle(0, 0, imge.Width, imge.Height));
                               //在右下角添加水印.
                               g.DrawString("传智播客", new Font("黑体", 14.0f, FontStyle.Bold), Brushes.Red, new PointF(imge.Width-100,imge.Height-30));
                               map.Save(context.Request.MapPath(fullDir),System.Drawing.Imaging.ImageFormat.Jpeg);
                           }
                       }
                   }

                   context.Response.Write("<html><head></head><body><img src='"+fullDir+"'/></body></html>");
                   //最后将上传成功的图片的路径存储到数据库。
               }
               else
               {
                   context.Response.Write("文件类型错误!!");
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