using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.fr
{
    public partial class _default : System.Web.UI.Page
    {
        protected List<CMSGetHomeGalleryResult> homegallery;
        protected List<CMSGetNewsResult> news;
        protected List<CMSGetEventsResult> events;
        protected void Page_Load(object sender, EventArgs e)
        {
            dcDataContext dc = new dcDataContext();
            homegallery = dc.CMSGetHomeGallery().OrderBy(x=>x.sort).ToList();
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/cms/config.config"));
            DataTable dt = new DataTable();
            dt = ds.Tables["Settings"];
            string desc = dt.Select("Name='frHistory'")[0]["Value"].ToString();
            news = dc.CMSGetNews().OrderByDescending(x => x.date_in).Take(4).ToList();
            events = dc.CMSGetEvents().OrderByDescending(x => x.date_start).Take(3).ToList();
            aboutTxt.Text = desc.Length>600?desc.Substring(0, 600)+"...":desc;
        }
    }
}