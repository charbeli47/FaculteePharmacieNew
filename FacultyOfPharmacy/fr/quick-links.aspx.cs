using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.fr
{
    public partial class quick_links : System.Web.UI.Page
    {
        protected List<CMSGetQuickLinksResult> result;
        protected void Page_Load(object sender, EventArgs e)
        {
            dcDataContext dc = new dcDataContext();
            result = dc.CMSGetQuickLinks().ToList();
        }
        protected void GetMetaTagsDetails(string strUrl, out string description, out string keywords)
        {
            //Get Meta Tags
            description = "";
            keywords = "";
            var webGet = new HtmlWeb();
            var document = webGet.Load(strUrl);
            var metaTags = document.DocumentNode.SelectNodes("//meta");
            if (metaTags != null)
            {
                foreach (var tag in metaTags)
                {
                    if (tag.Attributes["name"] != null && tag.Attributes["content"] != null && tag.Attributes["name"].Value == "description")
                    {
                        description = tag.Attributes["content"].Value;
                    }

                    if (tag.Attributes["name"] != null && tag.Attributes["content"] != null && tag.Attributes["name"].Value == "keywords")
                    {
                        keywords = tag.Attributes["content"].Value;
                    }
                }
            }
        }
    }
}