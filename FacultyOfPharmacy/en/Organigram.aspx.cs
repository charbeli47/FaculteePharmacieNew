using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FacultyOfPharmacy.en
{
    public partial class Organigram : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/cms/config.config"));
            DataTable dt = new DataTable();
            dt = ds.Tables["Settings"];
            organigramTxt.Text = dt.Select("Name='enOrganigrame'")[0]["Value"].ToString();
            organigramImage.ImageUrl = "~/Media/Organigrame/" + dt.Select("Name='thumbOrganigrame'")[0]["Value"].ToString();
        }
    }
}