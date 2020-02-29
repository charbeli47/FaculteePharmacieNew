using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace FacultyOfPharmacy.cms
{
    public partial class delete_table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string table = Request["table"];
            int id = int.Parse(Request["id"]);
            string redirect_url = Request["redirect_url"];
            dcDataContext dc = new dcDataContext();
            switch (table)
            {
                case "department":
                    dc.DeleteDepartment(id);
                    break;                
                case "academics":
                    dc.DeleteAcademics(id);
                    break;
                case "administratifs":
                    dc.DeleteAdministratifs(id);
                    break;
                case "continuous_learning":
                    dc.DeleteContinuousEducation(id);
                    break;
                case "official_statements":
                    dc.DeleteOfficialStatement(id);
                    break;
                case "education":
                    dc.DeleteEducation(id);
                    break;
                case "speciality":
                    dc.DeleteSpeciality(id);
                    break;
                case "semester":
                    dc.DeleteSemester(id);
                    break;
                case "AlumniEvents":
                    dc.DeleteAlumniEvents(id);
                    break;
                case "Activities":
                    dc.DeleteActivities(id);
                    break;
                case "Services":
                    dc.DeleteServices(id);
                    break;
                case "QuickLinks":
                    dc.DeleteQuickLinks(id);
                    break;
                case "GraduationCategories":
                    dc.DeleteGraduationCategory(id);
                    break;
                case "graduation":
                    dc.DeleteGraduation(id);
                    break;
                case "GraduationFiles":
                    dc.DeleteGraduationFile(id);
                    break;
                case "HomeGallery":
                    dc.DeleteHomeGallery(id);
                    break;
                case "Events":
                    dc.DeleteEvents(id);
                    break;
                case "ReasearchTeams":
                    dc.DeleteResearchTeams(id);
                    break;
                case "calendar":
                    dc.DeleteCalendar(id);
                    break;
                case "News":
                    dc.DeleteNews(id);
                    break;
            }
            Response.Redirect(redirect_url);
        }
    }
}