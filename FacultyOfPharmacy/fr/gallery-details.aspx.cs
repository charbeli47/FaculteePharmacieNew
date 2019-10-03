using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.fr
{
    public partial class gallery_details : System.Web.UI.Page
    {
        protected CMSGetGalleryByIDResult result;
        protected List<CMSGetGalleryImagesByGalleryIDResult> images;

        protected void Page_Load(object sender, EventArgs e)
        {
            int num = int.Parse(this.Request["id"]);
            dcDataContext dcDataContext = new dcDataContext();
            this.result = dcDataContext.CMSGetGalleryByID(new int?(num)).SingleOrDefault<CMSGetGalleryByIDResult>();
            this.images = dcDataContext.CMSGetGalleryImagesByGalleryID(num).ToList();
        }
    }
}