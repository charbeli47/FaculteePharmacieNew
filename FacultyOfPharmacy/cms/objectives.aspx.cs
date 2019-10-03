using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace FacultyOfPharmacy.cms
{
    public partial class objectives : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string path = Server.MapPath("~/cms/config.config");
            ds.ReadXml(path);
            DataTable dt = ds.Tables["Objective"];
            DataRow[] dr3 = dt.Select("Name='Text'");
            ar.Text = dr3[0]["ar"].ToString();
            en.Text = dr3[0]["en"].ToString();
            fr.Text = dr3[0]["fr"].ToString();
        }
        protected void SaveFOPBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string path = Server.MapPath("~/cms/config.config");
            ds.ReadXml(path);
            DataTable dt = ds.Tables["Objective"];
            DataRow[] dr = dt.Select("Name='Text'");
            dr[0]["ar"] = Request.Form["ctl00$main$ar"];
            dr[0]["en"] = Request.Form["ctl00$main$en"];
            dr[0]["fr"] = Request.Form["ctl00$main$fr"];
            dt.AcceptChanges();
            ds.WriteXml(path);
            ar.Text = Request.Form["ctl00$main$ar"];
            en.Text = Request.Form["ctl00$main$en"];
            fr.Text = Request.Form["ctl00$main$fr"];
            Response.Redirect("objectives.aspx");
        }
    }
}