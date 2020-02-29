using Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.cms
{
    /// <summary>
    /// Summary description for deleteGalleryImage
    /// </summary>
    public class deleteGalleryImage : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            dcDataContext dc = new dcDataContext();
            dc.DeleteGalleryImage(int.Parse(context.Request["id"]));
            context.Response.Write("success");
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