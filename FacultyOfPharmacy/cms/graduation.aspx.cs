using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.cms
{
    public partial class graduation : System.Web.UI.Page
    {
        protected dynamic result;
        protected int categoryId;
        protected string categoryName;
        protected void Page_Load(object sender, EventArgs e)
        {
            categoryId = int.Parse(Request["categoryId"]); 
            dcDataContext dc = new dcDataContext();
            result = dc.CMSGetGraduation().Where(x=>x.categoryId == categoryId).ToArray();
            categoryName = dc.CMSGetGraduationCategoriesByID(categoryId).SingleOrDefault().enname;
        }
    }
}