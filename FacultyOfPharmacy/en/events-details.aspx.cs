using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.en
{
    public partial class events_details : System.Web.UI.Page
    {
        protected CMSGetEventsByIDResult result;
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request["id"]);
            dcDataContext dc = new dcDataContext();
            result = dc.CMSGetEventsByID(id).SingleOrDefault();
        }
    }
}