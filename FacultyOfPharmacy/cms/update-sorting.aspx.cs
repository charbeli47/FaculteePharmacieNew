using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.cms
{
    public partial class update_sorting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string table = Request["table"];
            int id = int.Parse(Request["id"]);
            int sort = int.Parse(Request["sort"]);
            dcDataContext dc = new dcDataContext();
            dc.UpdateSorting(id, sort,table);
            Response.Write("success");

        }
    }
}