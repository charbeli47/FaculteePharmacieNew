using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace FacultyOfPharmacy.cms
{
    public partial class faculty_of_pharmacy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string path = Server.MapPath("~/cms/config.config");
            ds.ReadXml(path);
            DataTable dt = ds.Tables["FacultyOfPharmacy"];
            DataRow[] dr3 = dt.Select("Name='DeanWord'");
            arDeanWord.Text = dr3[0]["ar"].ToString();
            enDeanWord.Text = dr3[0]["en"].ToString();
            frDeanWord.Text = dr3[0]["fr"].ToString();
        }
        protected void SaveFOPBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string path = Server.MapPath("~/cms/config.config");
            ds.ReadXml(path);
            DataTable dt = ds.Tables["FacultyOfPharmacy"];
            DataRow[] dr = dt.Select("Name='DeanWord'");
            dr[0]["ar"] = Request.Form["ctl00$main$arDeanWord"];
            dr[0]["en"] = Request.Form["ctl00$main$enDeanWord"];
            dr[0]["fr"] = Request.Form["ctl00$main$frDeanWord"];
            dt.AcceptChanges();
            ds.WriteXml(path);
            arDeanWord.Text = Request.Form["ctl00$main$arDeanWord"];
            enDeanWord.Text = Request.Form["ctl00$main$enDeanWord"];
            frDeanWord.Text = Request.Form["ctl00$main$frDeanWord"];
            Response.Redirect("faculty-of-pharmacy.aspx");
        }
    }
}