using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.cms
{
    public partial class graduation_files : System.Web.UI.Page
    {
        protected dynamic result;
        protected string graduationCategoryName;
        protected int graduationId;
        protected void Page_Load(object sender, EventArgs e)
        {
            graduationId = int.Parse(Request["graduationId"]);
            
            dcDataContext dc = new dcDataContext();
            result = dc.CMSGetGraduationFilesByGraduationId(graduationId).ToArray();
            var graduation = dc.CMSGetGraduationByID(graduationId).SingleOrDefault();
            var category = dc.CMSGetGraduationCategoriesByID(graduation.categoryId).SingleOrDefault();
            graduationCategoryName = category.enname + " / " + graduation.enname;
        }
    }
}