using Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.cms
{
    public partial class gallery : System.Web.UI.Page
    {
        protected dynamic result;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            dcDataContext dc = new dcDataContext();
            result = dc.CMSGetGalleryCategories().OrderBy(x=>x.sort);
        }
    }
}