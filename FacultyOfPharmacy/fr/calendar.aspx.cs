using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.fr
{
    public partial class calendar : System.Web.UI.Page
    {
        protected List<CMSGetCalendarResult> result;
        protected void Page_Load(object sender, EventArgs e)
        {
            dcDataContext dc = new dcDataContext();
            result = dc.CMSGetCalendar().OrderByDescending(x => x.id).ToList();
        }
    }
}