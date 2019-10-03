using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.en
{
    public partial class graduation : System.Web.UI.Page
    {
        protected List<CMSGetGraduationCategoriesResult> categories;
        protected dcDataContext dc = new dcDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            categories = dc.CMSGetGraduationCategories().ToList();
        }
    }
}