using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace FacultyOfPharmacy
{
    public partial class _default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            switch (Thread.CurrentThread.CurrentCulture.Name)
            {
               /* case "ar-LB":
                    Response.Redirect("~/ar");
                    break;*/
                case "en-US":
                    Response.Redirect("~/fr");
                    break;
                case "fr-FR":
                    Response.Redirect("~/fr");
                    break;
                default:
                    Response.Redirect("~/fr");
                    break;
            }
            
        }
    }
}