using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.fr
{
    public partial class graduation_details : System.Web.UI.Page
    {
        protected CMSGetGraduationByIDResult result;
        protected List<CMSGetGraduationFilesByGraduationIdResult> files;
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request["gradId"]);
            dcDataContext dc = new dcDataContext();
            result = dc.CMSGetGraduationByID(id).SingleOrDefault();
            files = dc.CMSGetGraduationFilesByGraduationId(result.id).ToList();
        }
    }
}