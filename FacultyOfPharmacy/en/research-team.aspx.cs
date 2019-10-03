using System;
using System.Linq;
using System.Web.UI;
using Utils;

namespace FacultyOfPharmacy.en
{
    public class research_team : Page
    {
        protected CMSGetResearchTeamsByIdResult result;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.result = new dcDataContext().CMSGetResearchTeamsById(new int?(int.Parse(this.Request["id"]))).SingleOrDefault<CMSGetResearchTeamsByIdResult>();
        }
    }
}