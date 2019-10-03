using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.fr
{
    public partial class continuous_education : System.Web.UI.Page
    {
        protected List<CMSGetContinuousEducationResult> result;
        protected void Page_Load(object sender, EventArgs e)
        {
            dcDataContext dc = new dcDataContext();
            result = dc.CMSGetContinuousEducation().Where(x => x.status == 1).OrderBy(x => x.sort).ToList();
        }
    }
}