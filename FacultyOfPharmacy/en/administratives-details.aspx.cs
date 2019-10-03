using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.en
{
    public partial class administratives_details : System.Web.UI.Page
    {
        protected CMSGetAdministrativeByIDResult result;
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request["administrativesId"]);
            dcDataContext dc = new dcDataContext();
            result = dc.CMSGetAdministrativeByID(id).SingleOrDefault();
        }
    }
}