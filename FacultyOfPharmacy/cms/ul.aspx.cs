using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace FacultyOfPharmacy.cms
{
    public partial class ul : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string path = Server.MapPath("~/cms/config.config");
            ds.ReadXml(path);
            DataTable dt1 = ds.Tables["UL"];
            DataRow[] dr1 = dt1.Select("Name='WelcomeNote'");
            DataRow[] dr2 = dt1.Select("Name='DirectorWord'");
            arWelcomeNote.Text = dr1[0]["ar"].ToString();
            enWelcomeNote.Text = dr1[0]["en"].ToString();
            frWelcomeNote.Text = dr1[0]["fr"].ToString();
            arDirectorWord.Text = dr2[0]["ar"].ToString();
            enDirectorWord.Text = dr2[0]["en"].ToString();
            frDirectorWord.Text = dr2[0]["fr"].ToString();
        }
        protected void SaveULBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string path = Server.MapPath("~/cms/config.config");
            ds.ReadXml(path);
            DataTable dt = ds.Tables["UL"];
            DataRow[] dr1 = dt.Select("Name='WelcomeNote'");
            DataRow[] dr2 = dt.Select("Name='DirectorWord'");
            dr1[0]["ar"] = Request.Form["ctl00$main$arWelcomeNote"];
            dr1[0]["en"] = Request.Form["ctl00$main$enWelcomeNote"];
            dr1[0]["fr"] = Request.Form["ctl00$main$frWelcomeNote"];
            dr2[0]["ar"] = Request.Form["ctl00$main$arDirectorWord"];
            dr2[0]["en"] = Request.Form["ctl00$main$enDirectorWord"];
            dr2[0]["fr"] = Request.Form["ctl00$main$frDirectorWord"];
            dt.AcceptChanges();
            ds.WriteXml(path);
            arDirectorWord.Text = Request.Form["ctl00$main$arDirectorWord"];
            enDirectorWord.Text = Request.Form["ctl00$main$enDirectorWord"];
            frDirectorWord.Text = Request.Form["ctl00$main$frDirectorWord"];

            arWelcomeNote.Text = Request.Form["ctl00$main$arWelcomeNote"];
            enWelcomeNote.Text = Request.Form["ctl00$main$enWelcomeNote"];
            frWelcomeNote.Text = Request.Form["ctl00$main$frWelcomeNote"];
            Response.Redirect("ul.aspx");
        }
    }
}