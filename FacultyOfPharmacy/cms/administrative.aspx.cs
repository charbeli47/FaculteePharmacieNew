using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.cms
{
    public partial class administrative : System.Web.UI.Page
    {
        protected dynamic result;
        protected void Page_Load(object sender, EventArgs e)
        {
            dcDataContext dc = new dcDataContext();
            result = dc.CMSGetAdministrative().ToArray().OrderBy(x => x.sort);
        }
    }
}