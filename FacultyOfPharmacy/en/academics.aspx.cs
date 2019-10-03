using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.en
{
    public partial class academics : System.Web.UI.Page
    {
        protected List<CMSGetAcademicsResult> result;
        protected void Page_Load(object sender, EventArgs e)
        {
            dcDataContext dc = new dcDataContext();
            string category = Request["category"].Replace("'", "''");
            result = dc.CMSGetAcademics().Where(x => x.status == 1 && x.category == category).OrderBy(x => x.sort).ToList();
            if (category == "Faculty Council")
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/cms/config.config"));
                DataTable dt = new DataTable();
                dt = ds.Tables["Settings"];
                council.Text = "<p>" + dt.Select("Name='enConseil'")[0]["Value"].ToString() + "</p>";
            }
        }
    }
}