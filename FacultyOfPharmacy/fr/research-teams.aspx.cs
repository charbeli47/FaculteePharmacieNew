using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.fr
{
    public partial class research_teams : System.Web.UI.Page
    {
        protected CMSGetResearchTeamsByIdResult result;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.result = new dcDataContext().CMSGetResearchTeamsById(new int?(int.Parse(this.Request["id"]))).SingleOrDefault<CMSGetResearchTeamsByIdResult>();
        }
    }
}