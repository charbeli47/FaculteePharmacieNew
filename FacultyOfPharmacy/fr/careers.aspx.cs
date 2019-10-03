using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FacultyOfPharmacy.fr
{
    public partial class careers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/cms/config.config"));
            DataTable dt = new DataTable();
            dt = ds.Tables["Settings"];
            careersTxt.Text = dt.Select("Name='frEmployment'")[0]["Value"].ToString();
        }
    }
}