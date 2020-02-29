using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.cms
{
    public partial class _default : System.Web.UI.Page
    {
        protected string visitsToday;
        protected string visitsLastWeek;
        protected string visitsChrome, visitsFirefox, visitsIE, visitsSafari;
        protected void Page_Load(object sender, EventArgs e)
        {
            dcDataContext dc = new dcDataContext();
            string date = string.Format("{0}/{1}/{2}", DateTime.Now.Month.ToString().Length == 1 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString(), DateTime.Now.Day.ToString().Length==1?"0"+DateTime.Now.Day.ToString():DateTime.Now.Day.ToString(), DateTime.Now.Year);
            visitsToday = dc.CMSGetVisitsPerDate(date).Single().visits.ToString();
            visitsLastWeek = dc.CMSGetVisitsBetwee2Dates(DateTime.Now.AddDays(-8), DateTime.Now.AddDays(-1)).Single().visits.ToString();
            visitsChrome = dc.CMSGetVisitsPerBrowser("Chrome").Single().visits.ToString();
            visitsFirefox = dc.CMSGetVisitsPerBrowser("Firefox").Single().visits.ToString();
            visitsIE = dc.CMSGetVisitsPerBrowser("IE").Single().visits.ToString();
            visitsSafari = dc.CMSGetVisitsPerBrowser("Safari").Single().visits.ToString(); 
        }
    }
}