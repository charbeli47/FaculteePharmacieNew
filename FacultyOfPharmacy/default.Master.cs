using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using Utils;

namespace FacultyOfPharmacy
{
    public partial class _default : System.Web.UI.MasterPage
    {
        protected string path;
        protected void Page_Load(object sender, EventArgs e)
        {
            path = Request.Url.AbsoluteUri;
            dcDataContext dc = new dcDataContext();
            dc.AddPageVisit(path, Request.ServerVariables["REMOTE_ADDR"].ToString(), Request.Browser.Browser, DateTime.Now);
            path = path.Substring(path.LastIndexOf("/"));
        }
    }
}