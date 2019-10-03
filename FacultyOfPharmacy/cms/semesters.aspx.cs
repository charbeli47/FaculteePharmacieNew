using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.cms
{
    public partial class semesters : System.Web.UI.Page
    {
        protected dynamic result;
        protected int specialityId;
        protected string specialityName;
        protected void Page_Load(object sender, EventArgs e)
        {
            specialityId = int.Parse(Request["specialityId"]); 
            dcDataContext dc = new dcDataContext();
            result = dc.CMSGetSemestersBySpecialityID(specialityId).ToArray();
            specialityName = dc.CMSGetSpecialityByID(specialityId).SingleOrDefault().enname;
        }
    }
}