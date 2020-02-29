using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.cms
{
    public partial class education : System.Web.UI.Page
    {
        protected dynamic result;
        protected string semesterSpecialityName;
        protected int semesterId;
        protected void Page_Load(object sender, EventArgs e)
        {
            semesterId = int.Parse(Request["semesterId"]);
            
            dcDataContext dc = new dcDataContext();
            result = dc.CMSGetEducationBySemesterID(semesterId).ToArray().OrderBy(x => x.sort);
            var semester = dc.CMSGetSemestersByID(semesterId).SingleOrDefault();
            var speciality = dc.CMSGetSpecialityByID(semester.specialityId).SingleOrDefault();
            semesterSpecialityName = speciality.enname + " - " + semester.enname;
        }
    }
}