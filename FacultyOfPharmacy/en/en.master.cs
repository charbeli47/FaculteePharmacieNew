using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.en
{
    public partial class en : System.Web.UI.MasterPage
    {
        protected List<CMSGetResearchTeamsResult> reasearchTeams;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.reasearchTeams = ((IEnumerable<CMSGetResearchTeamsResult>)new dcDataContext().CMSGetResearchTeams()).ToList<CMSGetResearchTeamsResult>();
        }
    }
}