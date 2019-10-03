using Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace Web.cms
{
    /// <summary>
    /// Summary description for uploadGalleryImage
    /// </summary>
    public class uploadGalleryImage : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = SaveImage(context, context.Request.Form["img"]);
            context.Response.Write(id);
        }
        public int SaveImage(HttpContext context, string base64)
        {
            string basea = base64.Substring(0, base64.LastIndexOf(";base64,")+8);
            int id = 0;
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(base64.Replace(basea,""))))
            {
                using (Bitmap bm2 = new Bitmap(ms))
                {
                    string guid = Guid.NewGuid().ToString();
                    bm2.Save(context.Server.MapPath("~/Media/") + guid + ".jpg");
                    dcDataContext dc = new dcDataContext();
                    id = dc.CreateGalleryImage(guid + ".jpg", int.Parse(context.Request["galleryId"]));
                }
            }
            return id;
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