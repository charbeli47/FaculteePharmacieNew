using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.en
{
    public partial class events : System.Web.UI.Page
    {
        protected List<CMSGetEventsResult> result;
        protected void Page_Load(object sender, EventArgs e)
        {
            dcDataContext dc = new dcDataContext();
            result = dc.CMSGetEvents().OrderByDescending(x=>x.date_start).ToList();
        }
    }
}