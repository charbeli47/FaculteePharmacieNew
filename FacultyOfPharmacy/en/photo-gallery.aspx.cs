using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.en
{
    public partial class photo_gallery : System.Web.UI.Page
    {
        protected List<CMSGetGalleryCategoriesResult> categories;
        protected List<CMSGetGalleryResult> gallery;
        protected dcDataContext dc = new dcDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            categories = dc.CMSGetGalleryCategories().OrderBy(x => x.sort).ToList();
            gallery = dc.CMSGetGallery().OrderBy(x => x.sort).ToList();
        }
    }
}