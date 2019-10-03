using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.fr
{
    public partial class administratives : System.Web.UI.Page
    {
        protected List<CMSGetAdministrativeResult> result;
        protected void Page_Load(object sender, EventArgs e)
        {
            dcDataContext dc = new dcDataContext();
            result = dc.CMSGetAdministrative().Where(x => x.status == 1).OrderBy(x => x.sort).ToList();
        }
    }
}