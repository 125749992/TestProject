using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZBK.TestProject.WebApp._2014_11_8
{
    /// <summary>
    /// DownLoad 的摘要说明
    /// </summary>
    public class DownLoad : IHttpHandler
    {

        public void ProcessRequestAsync(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string encodeFileName = "aaa.txt";
            context.Response.AddHeader("Content-Disposition", string.Format("attachment;filename=\"{0}\"", encodeFileName));//在响应头中加上Content-Disposition，attachment表示以附件形式下载.
            context.Response.WriteFile("aaa.txt");
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