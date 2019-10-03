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
    public partial class orientation : System.Web.UI.Page
    {
        protected List<CMSGetOrientationFilesResult> result;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/cms/config.config"));
            DataTable dt = new DataTable();
            dt = ds.Tables["Settings"];
            enOrientation.Text = dt.Select("Name='enOrientation'")[0]["Value"].ToString();
            dcDataContext dc = new dcDataContext();
            result = dc.CMSGetOrientationFiles().ToList();
        }
    }
}