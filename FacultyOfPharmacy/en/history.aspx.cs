using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FacultyOfPharmacy.en
{
    public partial class history : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/cms/config.config"));
            DataTable dt = new DataTable();
            dt = ds.Tables["Settings"];
            historyTxt.Text = dt.Select("Name='enHistory'")[0]["Value"].ToString();
            historyImg.ImageUrl = "~/Media/History/" + dt.Select("Name='thumbHistory'")[0]["Value"].ToString();
        }
    }
}